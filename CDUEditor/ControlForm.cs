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

namespace CDUEditor
{
    public partial class ControlForm : Form
    {
        BrowserForm browserForm;
        JSHandler jsHandler;
        public Point clickPoint;

        public ControlForm()
        {
            InitializeComponent();
            jsHandler = new JSHandler();
            jsHandler.parent = this;
        }

        private string GenerateURL()
        {
            string screen = ScreenNumber.Value.ToString();
            string size = ElementSize.Text;
            string template = ElementStyle.Text;
            string host ;

            label1.Text = "#/cdu/screen" + screen + "/" + size + "/" + template;
            if (URLRadioButton.Checked)
            {
                host = "http://" + URLText.Text + "/" ;
            }
            else
            {
                host = "file://" + FileText.Text;
            }
            return host + label1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (browserForm is null)
            {
                browserForm = new BrowserForm(jsHandler);
            }
            browserForm.URL = GenerateURL();
            try
            {
                browserForm.Show();
//                timer1.Enabled = true;
            }
            catch (ObjectDisposedException ex)
            {
                // they closed the form... reset and try a new one
                browserForm = null;
                button1_Click(sender, e);
            }
        }

        private void ControlForm_Load(object sender, EventArgs e)
        {
            GenerateURL();
        }

        private async void LoadCssTimer_TickAsync(object sender, EventArgs e)
        {
            if (jsHandler.Click)
            {
                // User has clicked on an element in the browser, so handler class is signalling us
                int X = jsHandler.X;
                int Y = jsHandler.Y;
                jsHandler.Click = false;
                
                StylesList.Items.Clear();
                Debug.Print($"Click at ({jsHandler.X},{jsHandler.Y})");

                string S = await browserForm.ExecJSAsync($"(function() {{ return document.elementsFromPoint({X}, {Y}).length }})();");
                string N;
                string ClassNames;
                int NumElements = Int32.Parse(S);
                for (int i=0; i<NumElements; i++)
                {
                    //                    S = await browserForm.ExecJSAsync($"(function() {{ return document.elementsFromPoint({X}, {Y})[{i}].attributes }})();");
                    N = await browserForm.ExecJSAsync($"(function() {{ return document.elementsFromPoint({X}, {Y})[{i}].nodeName }})();");
                    ClassNames = await browserForm.ExecJSAsync($"(function() {{ return document.elementsFromPoint({X}, {Y})[{i}].className }})();");
                    bool bFoundOne = false;
                    foreach (string ClassName in ClassNames.Split(' '))
                    {
                        foreach (StyleSheet SS in browserForm.StyleSheets)
                        {
                            if (!(SS.cssRules is null))
                            {
                                StyleSheetRule SSR = SS.FindRuleByClass(ClassName);
                                if (!(SSR is null))
                                {
                                    StylesList.Items.Add(SSR);
                                    bFoundOne = true;
                                }
                            }

                        }
                    }
                    if (!bFoundOne)
                    {
                        StylesList.Items.Add($"[{i}]<{N}> {ClassNames}");
                    }

                    //            var x = event.clientX, y = event.clientY,
                    //    elementMouseIsOver = document.elementsFromPoint(x, y);
                    /*
                    if (! (browserForm is null))
                    {
                        if (browserForm.unPacked)
                        {
                            loadCssTimer.Enabled = false;
                            listBox1.Items.Clear();

                            foreach(StyleSheet S in browserForm.StyleSheets)
                            {
                                if (!(S.cssRules is null))
                                {
                                    foreach (StyleSheetRule SSR in S.cssRules)
                                    {
                                        if (!(SSR.selectorText is null))
                                            listBox1.Items.Add("" + S.index + "," + SSR.index + "," + SSR.selectorText);
                                    }
                                }
                            } */
                } 
            } 
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            object O = StylesList.SelectedItem;
            if (O.GetType() == typeof(StyleSheetRule))
            {
                StyleSheetRule SSR = (StyleSheetRule)O;
                SSR.EditAsync(EditsList);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private async void button3_ClickAsync(object sender, EventArgs e)
        {
            foreach(object O in EditsList.Items)
            {
                if (O.GetType() == typeof(StyleSheetEdit))
                {
                    StyleSheetEdit E = (StyleSheetEdit)O;
                    await E.ExecuteAsync(browserForm);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!(EditsList.SelectedItem is null)) {
                EditsList.Items.Remove(EditsList.SelectedItem);
            }
        }

        //        (function() { return document.styleSheets[1].href})();
        //          https://www.w3.org/wiki/Dynamic_style_-_manipulating_CSS_with_JavaScript
        //   document.styleSheets[1].cssRules[244].style.backgroundColor = 'rgb(127, 127, 127)'


    }
}
