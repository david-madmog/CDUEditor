namespace CDUEditor
{
    partial class ControlForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.StylesList = new System.Windows.Forms.ListBox();
            this.loadCssTimer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ElementStyle = new System.Windows.Forms.ComboBox();
            this.ElementSize = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ScreenNumber = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.FileText = new System.Windows.Forms.TextBox();
            this.URLText = new System.Windows.Forms.TextBox();
            this.ShowButton = new System.Windows.Forms.Button();
            this.FileRadioButton = new System.Windows.Forms.RadioButton();
            this.URLRadioButton = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.EditsList = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScreenNumber)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // StylesList
            // 
            this.StylesList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.StylesList.FormattingEnabled = true;
            this.StylesList.ItemHeight = 16;
            this.StylesList.Location = new System.Drawing.Point(12, 255);
            this.StylesList.Name = "StylesList";
            this.StylesList.Size = new System.Drawing.Size(661, 388);
            this.StylesList.TabIndex = 15;
            this.StylesList.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // loadCssTimer
            // 
            this.loadCssTimer.Enabled = true;
            this.loadCssTimer.Tick += new System.EventHandler(this.LoadCssTimer_TickAsync);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ElementStyle);
            this.groupBox1.Controls.Add(this.ElementSize);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ScreenNumber);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.FileText);
            this.groupBox1.Controls.Add(this.URLText);
            this.groupBox1.Controls.Add(this.ShowButton);
            this.groupBox1.Controls.Add(this.FileRadioButton);
            this.groupBox1.Controls.Add(this.URLRadioButton);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(661, 206);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Source";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Template";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Size";
            // 
            // ElementStyle
            // 
            this.ElementStyle.FormattingEnabled = true;
            this.ElementStyle.Items.AddRange(new object[] {
            "standard",
            "translux",
            "white"});
            this.ElementStyle.Location = new System.Drawing.Point(122, 166);
            this.ElementStyle.Name = "ElementStyle";
            this.ElementStyle.Size = new System.Drawing.Size(295, 24);
            this.ElementStyle.TabIndex = 21;
            this.ElementStyle.Text = "standard";
            // 
            // ElementSize
            // 
            this.ElementSize.FormattingEnabled = true;
            this.ElementSize.Items.AddRange(new object[] {
            "default",
            "small",
            "big"});
            this.ElementSize.Location = new System.Drawing.Point(122, 135);
            this.ElementSize.Name = "ElementSize";
            this.ElementSize.Size = new System.Drawing.Size(295, 24);
            this.ElementSize.TabIndex = 20;
            this.ElementSize.Text = "default";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Screen number";
            // 
            // ScreenNumber
            // 
            this.ScreenNumber.Location = new System.Drawing.Point(122, 107);
            this.ScreenNumber.Name = "ScreenNumber";
            this.ScreenNumber.Size = new System.Drawing.Size(120, 22);
            this.ScreenNumber.TabIndex = 18;
            this.ScreenNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(122, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(528, 22);
            this.label1.TabIndex = 17;
            this.label1.Text = "label1";
            // 
            // FileText
            // 
            this.FileText.Location = new System.Drawing.Point(122, 48);
            this.FileText.Name = "FileText";
            this.FileText.Size = new System.Drawing.Size(528, 22);
            this.FileText.TabIndex = 16;
            this.FileText.Text = "C:/Users/davidp/OneDrive%20-%20IGT%20PLC/Products/CDU/LocalDemo/index.html";
            // 
            // URLText
            // 
            this.URLText.Location = new System.Drawing.Point(122, 20);
            this.URLText.Name = "URLText";
            this.URLText.Size = new System.Drawing.Size(528, 22);
            this.URLText.TabIndex = 15;
            this.URLText.Text = "80.240.145.52:83";
            // 
            // ShowButton
            // 
            this.ShowButton.Location = new System.Drawing.Point(519, 142);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(131, 48);
            this.ShowButton.TabIndex = 14;
            this.ShowButton.Text = "Show";
            this.ShowButton.UseVisualStyleBackColor = true;
            this.ShowButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // FileRadioButton
            // 
            this.FileRadioButton.AutoSize = true;
            this.FileRadioButton.Location = new System.Drawing.Point(6, 49);
            this.FileRadioButton.Name = "FileRadioButton";
            this.FileRadioButton.Size = new System.Drawing.Size(51, 21);
            this.FileRadioButton.TabIndex = 13;
            this.FileRadioButton.Text = "File";
            this.FileRadioButton.UseVisualStyleBackColor = true;
            // 
            // URLRadioButton
            // 
            this.URLRadioButton.AutoSize = true;
            this.URLRadioButton.Checked = true;
            this.URLRadioButton.Location = new System.Drawing.Point(6, 21);
            this.URLRadioButton.Name = "URLRadioButton";
            this.URLRadioButton.Size = new System.Drawing.Size(57, 21);
            this.URLRadioButton.TabIndex = 12;
            this.URLRadioButton.TabStop = true;
            this.URLRadioButton.Text = "URL";
            this.URLRadioButton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Styles affecting selected element:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.EditsList);
            this.groupBox2.Location = new System.Drawing.Point(679, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(427, 644);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Edited Styles";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(322, 22);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 40);
            this.button4.TabIndex = 28;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(218, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 40);
            this.button3.TabIndex = 27;
            this.button3.Text = "Re-apply";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_ClickAsync);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(114, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 40);
            this.button2.TabIndex = 26;
            this.button2.Text = "Save...";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(10, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 40);
            this.button1.TabIndex = 25;
            this.button1.Text = "Load...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // EditsList
            // 
            this.EditsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EditsList.FormattingEnabled = true;
            this.EditsList.ItemHeight = 16;
            this.EditsList.Location = new System.Drawing.Point(10, 68);
            this.EditsList.Name = "EditsList";
            this.EditsList.Size = new System.Drawing.Size(410, 564);
            this.EditsList.TabIndex = 24;
            // 
            // ControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 660);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.StylesList);
            this.Name = "ControlForm";
            this.Text = "CDU Editor";
            this.Load += new System.EventHandler(this.ControlForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScreenNumber)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox StylesList;
        private System.Windows.Forms.Timer loadCssTimer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ElementStyle;
        private System.Windows.Forms.ComboBox ElementSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown ScreenNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FileText;
        private System.Windows.Forms.TextBox URLText;
        private System.Windows.Forms.Button ShowButton;
        private System.Windows.Forms.RadioButton FileRadioButton;
        private System.Windows.Forms.RadioButton URLRadioButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox EditsList;
    }
}

