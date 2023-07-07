namespace sccsr16
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            listBox1 = new ListBox();
            button5 = new Button();
            button6 = new Button();
            comboBox1 = new ComboBox();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            folderBrowserDialog1 = new FolderBrowserDialog();
            button16 = new Button();
            button17 = new Button();
            openFileDialog2 = new OpenFileDialog();
            folderBrowserDialog2 = new FolderBrowserDialog();
            folderBrowserDialog3 = new FolderBrowserDialog();
            folderBrowserDialog4 = new FolderBrowserDialog();
            openFileDialog1 = new OpenFileDialog();
            button18 = new Button();
            button19 = new Button();
            folderBrowserDialog5 = new FolderBrowserDialog();
            openFileDialog3 = new OpenFileDialog();
            folderBrowserDialog6 = new FolderBrowserDialog();
            openFileDialog4 = new OpenFileDialog();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(69, 12);
            button1.Name = "button1";
            button1.Size = new Size(40, 23);
            button1.TabIndex = 0;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 217);
            button2.Name = "button2";
            button2.Size = new Size(69, 23);
            button2.TabIndex = 1;
            button2.Text = "Del muls";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(161, 157);
            button3.Name = "button3";
            button3.Size = new Size(39, 23);
            button3.TabIndex = 2;
            button3.Text = "Mi";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(162, 128);
            button4.Name = "button4";
            button4.Size = new Size(38, 23);
            button4.TabIndex = 3;
            button4.Text = "Ci";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 41);
            listBox1.Name = "listBox1";
            listBox1.SelectionMode = SelectionMode.MultiExtended;
            listBox1.Size = new Size(144, 169);
            listBox1.TabIndex = 4;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button5
            // 
            button5.Location = new Point(162, 41);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 5;
            button5.Text = "Refresh";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(87, 217);
            button6.Name = "button6";
            button6.Size = new Size(69, 23);
            button6.TabIndex = 6;
            button6.Text = "Del mods";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "+cpu usage. faster del", "-cpu usage. slower del" });
            comboBox1.Location = new Point(12, 246);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(144, 23);
            comboBox1.TabIndex = 7;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button7
            // 
            button7.Location = new Point(12, 12);
            button7.Name = "button7";
            button7.Size = new Size(40, 23);
            button7.TabIndex = 8;
            button7.Text = "Exit";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(115, 12);
            button8.Name = "button8";
            button8.Size = new Size(40, 23);
            button8.TabIndex = 9;
            button8.Text = "Stop";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(161, 70);
            button9.Name = "button9";
            button9.Size = new Size(76, 23);
            button9.TabIndex = 10;
            button9.Text = "Hide";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Location = new Point(161, 99);
            button10.Name = "button10";
            button10.Size = new Size(76, 23);
            button10.TabIndex = 11;
            button10.Text = "UnDock";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.Location = new Point(161, 12);
            button11.Name = "button11";
            button11.Size = new Size(76, 23);
            button11.TabIndex = 12;
            button11.Text = "Recall";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button12
            // 
            button12.Location = new Point(171, 273);
            button12.Name = "button12";
            button12.Size = new Size(29, 23);
            button12.TabIndex = 13;
            button12.Text = "L";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // button13
            // 
            button13.Location = new Point(206, 273);
            button13.Name = "button13";
            button13.Size = new Size(29, 23);
            button13.TabIndex = 14;
            button13.Text = "R";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // button14
            // 
            button14.Location = new Point(189, 302);
            button14.Name = "button14";
            button14.Size = new Size(29, 24);
            button14.TabIndex = 15;
            button14.Text = "D";
            button14.UseVisualStyleBackColor = true;
            button14.Click += button14_Click;
            // 
            // button15
            // 
            button15.Location = new Point(189, 246);
            button15.Name = "button15";
            button15.Size = new Size(29, 23);
            button15.TabIndex = 16;
            button15.Text = "U";
            button15.UseVisualStyleBackColor = true;
            button15.Click += button15_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "+cpu usage. faster copy", "-cpu usage. slower copy" });
            comboBox2.Location = new Point(12, 275);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(144, 23);
            comboBox2.TabIndex = 17;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "+cpu usage. faster move", "-cpu usage. slower move" });
            comboBox3.Location = new Point(11, 304);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(144, 23);
            comboBox3.TabIndex = 18;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // folderBrowserDialog1
            // 
            folderBrowserDialog1.HelpRequest += folderBrowserDialog1_HelpRequest;
            // 
            // button16
            // 
            button16.Location = new Point(199, 128);
            button16.Name = "button16";
            button16.Size = new Size(38, 23);
            button16.TabIndex = 19;
            button16.Text = "Co";
            button16.UseVisualStyleBackColor = true;
            button16.Click += button16_Click;
            // 
            // button17
            // 
            button17.Location = new Point(199, 157);
            button17.Name = "button17";
            button17.Size = new Size(39, 23);
            button17.TabIndex = 20;
            button17.Text = "Mo";
            button17.UseVisualStyleBackColor = true;
            button17.Click += button17_Click;
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "openFileDialog2";
            openFileDialog2.FileOk += openFileDialog2_FileOk;
            // 
            // folderBrowserDialog4
            // 
            folderBrowserDialog4.HelpRequest += folderBrowserDialog4_HelpRequest;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // button18
            // 
            button18.Location = new Point(191, 188);
            button18.Name = "button18";
            button18.Size = new Size(46, 23);
            button18.TabIndex = 21;
            button18.Text = "copy";
            button18.UseVisualStyleBackColor = true;
            button18.Click += button18_Click;
            // 
            // button19
            // 
            button19.Location = new Point(191, 217);
            button19.Name = "button19";
            button19.Size = new Size(46, 23);
            button19.TabIndex = 22;
            button19.Text = "move";
            button19.UseVisualStyleBackColor = true;
            button19.Click += button19_Click;
            // 
            // openFileDialog3
            // 
            openFileDialog3.FileName = "openFileDialog3";
            // 
            // openFileDialog4
            // 
            openFileDialog4.FileName = "openFileDialog4";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(247, 339);
            Controls.Add(button19);
            Controls.Add(button18);
            Controls.Add(button17);
            Controls.Add(button16);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(comboBox1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(listBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private ListBox listBox1;
        private Button button5;
        private Button button6;
        private ComboBox comboBox1;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button button16;
        private Button button17;
        private OpenFileDialog openFileDialog2;
        private FolderBrowserDialog folderBrowserDialog2;
        private FolderBrowserDialog folderBrowserDialog3;
        private FolderBrowserDialog folderBrowserDialog4;
        private Button button18;
        private Button button19;
        private FolderBrowserDialog folderBrowserDialog5;
        private OpenFileDialog openFileDialog3;
        private FolderBrowserDialog folderBrowserDialog6;
        private OpenFileDialog openFileDialog4;
    }
}