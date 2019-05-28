using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDUEditor
{
    class StyleSheetRule
    {
        public string cssText;
        public int index;
        public int parentIndex;
        public string selectorText;

        private BrowserForm pForm;
        // selectorText
        // styleMap

        public StyleSheetRule(int vParentIndex, int vIndex)
        {
            parentIndex = vParentIndex;
            index = vIndex;
        }

        public async 
        Task
UnPackAsync(BrowserForm form)
        {
            string S;

            pForm = form;

            S = await form.ExecJSAsync($"(function() {{ return document.styleSheets[{parentIndex}].cssRules[{index}].cssText}})();");
            cssText = S;
            S = await form.ExecJSAsync($"(function() {{ return document.styleSheets[{parentIndex}].cssRules[{index}].selectorText}})();");
            selectorText = S;
        }

        public override string ToString()
        {
            return $"{parentIndex},{index} {selectorText}";
        }

        public async void EditAsync(ListBox EditsBox)
        {
            ssRuleEditor SSRE = new ssRuleEditor(cssText);
            if (SSRE.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StyleSheetEdit E = new StyleSheetEdit();
                E.Rule = this;
                E.Edit = SSRE.text;
                await E.ExecuteAsync(pForm);
                await UnPackAsync(pForm);
                EditsBox.Items.Add(E);
            }
        }
    }
}
