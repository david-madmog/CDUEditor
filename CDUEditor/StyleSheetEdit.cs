using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDUEditor
{
    class StyleSheetEdit
    {
        internal StyleSheetRule Rule;
        internal string Edit;

        internal async Task ExecuteAsync(BrowserForm pForm)
        {
            string CMD = $"document.styleSheets[{Rule.parentIndex}].cssRules[{Rule.index}].style.";
            CMD += Edit;
            Debug.Print(CMD);
            string S = await pForm.ExecJSAsync(CMD);
            Debug.Print(S);
        }

        public override string ToString()
        {
            return $"{Rule.parentIndex},{Rule.index} ==> {Edit}";
        }
    }
}
