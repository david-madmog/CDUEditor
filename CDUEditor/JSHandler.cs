using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDUEditor
{
    public class JSHandler
    {
        public ControlForm parent;
        public int X, Y;
        public bool Click = false;


        public void HandleMouseClick(int vX, int vY)
        {
            X = vX;
            Y = vY;
            Click = true;
//            parent.BrowserClick(X, Y);
            //MessageBox.Show($"Value Provided From JavaScript: ({X},{Y})", "Form Clicked");
        }

        public void JSCallback(object Object)
        {
            MessageBox.Show("Hello World");
        }
    }
}
