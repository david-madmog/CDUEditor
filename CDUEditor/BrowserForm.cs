using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace CDUEditor
{
    public partial class BrowserForm : Form
    {
        private ChromiumWebBrowser browser;
        private string sURL = "www.google.com";
//        private string sDOM;
        private string EvaluateJavaScriptResult;
        private StyleSheet[] styleSheets;
        public bool unPacked = false;
        internal StyleSheet[] StyleSheets { get => styleSheets; set => styleSheets = value; }

        public string URL
        {
            get { return sURL; }
            set
            {
                sURL = value;
                if (! (browser is null))
                {
                    unPacked = false;
                    browser.Load(sURL);
                }
            }
        }

        public BrowserForm(JSHandler jsHandler)
        {
            InitializeComponent();
            InitBrowser(jsHandler);
        }

        private void BrowserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cef.Shutdown();
        }

        public async Task<string> ExecJSAsync(string JS)
        {
            JavascriptResponse Resp;
            Resp = await browser.GetBrowser().MainFrame.EvaluateScriptAsync(JS, null);
            try
            {
                if (Resp.Success)
                    if (Resp.Result is null)
                        EvaluateJavaScriptResult = "";
                    else
                        EvaluateJavaScriptResult = Resp.Result.ToString();
                else
                    EvaluateJavaScriptResult = "ERROR: " + Resp.Message.ToString();
            } catch (Exception ex)
            {
                    EvaluateJavaScriptResult = "EXCEPTION: " + ex.Message ;
            }

            return EvaluateJavaScriptResult;
        }

        private void InitBrowser(JSHandler jsHandler)
        {
            unPacked = false;
            // Setting to the embedded control to allow local file access
            CefSettings settings = new CefSettings();
            settings.CefCommandLineArgs.Add("allow-file-access-from-files", "");
            settings.CefCommandLineArgs.Add("disable-web-security", "");
            settings.CefCommandLineArgs.Add("user-data-dir", "");
            Cef.Initialize(settings);
            browser = new ChromiumWebBrowser(sURL);
            this.Controls.Add(browser);
            browser.Dock = DockStyle.Fill;

            // Register callback for when loading finished
            browser.LoadingStateChanged += Browser_LoadingStateChangedAsync;

            // Bind jshandler instance into javascript object, which will allow injected JS to call out
            BindingOptions options = new BindingOptions();
            options.CamelCaseJavascriptNames = false;
            browser.JavascriptObjectRepository.Register("jsHandler", jsHandler, false, options);
        
        }

        private void Browser_LoadingStateChangedAsync(object sender, LoadingStateChangedEventArgs e)
        {
            if (! e.IsLoading )
            {
                // Finished loading... fire off timer to kick off stuff we want to do
                timer1.Enabled = true;
            }
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;

            int NumStyleSheets = 0;
            string S;

            // Get all style information
            S = await ExecJSAsync("(function() { return document.styleSheets.length })();");
            NumStyleSheets = Int32.Parse(S);
            StyleSheets = new StyleSheet[NumStyleSheets];

            for (int i = 0; i<NumStyleSheets; i++)
            {
                StyleSheets[i] = new StyleSheet(i);
                StyleSheets[i].UnPackAsync(this);
            }

            // Inject "onClick" JS
            // First bind the jshandler class (previously registered in JS object repository
            S = await ExecJSAsync("(async function() {await CefSharp.BindObjectAsync(\"jsHandler\");})();");
            Debug.Print(S);

            // then add call to plumbed-in .NET class on click of body
            S = await ExecJSAsync("document.getElementsByTagName(\"body\")[0].onclick = function(event) {window.jsHandler.HandleMouseClick(event.clientX, event.clientY)}");
            Debug.Print(S);

            unPacked = true;

        }
    }
}
