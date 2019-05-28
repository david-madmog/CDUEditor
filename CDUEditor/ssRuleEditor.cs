using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDUEditor
{
    public partial class ssRuleEditor : Form
    {
        public string text;
        public ssRuleEditor(string label)
        {
            InitializeComponent();
            label1.Text = label;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            text = textBox1.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            text = "";
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
