using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDUEditor
{
    class StyleSheet
    {
        public StyleSheetRule[] cssRules;
        public string href;
        public int index;
        // selectorText
        // styleMap

        public StyleSheet(int vIndex)
        {
            index = vIndex;
        }

        public async void UnPackAsync (BrowserForm form)
        {
            int NumStyles = 0;
            string S;

            S = await form.ExecJSAsync($"(function() {{ return document.styleSheets[{index}].cssRules.length}})();");
            NumStyles = Int32.Parse(S);
            if (NumStyles > 0)
            {
                S = await form.ExecJSAsync($"(function() {{ return document.styleSheets[{index}].href}})();");
                href = S;
                cssRules = new StyleSheetRule[NumStyles];
                Debug.Print(S);
                for (int j = 0; j < NumStyles; j++)
                {
                    cssRules[j] = new StyleSheetRule(index, j);
                    await cssRules[j].UnPackAsync(form);
                }
            }
        }

        public StyleSheetRule FindRuleByClass(string Class)
        {
            foreach(StyleSheetRule rule in cssRules)
            {
                if (rule.selectorText.Contains(Class))
                {
                    return rule;
                }
            }
            return null;
        }
    }
}
