namespace Mo_telepulesei_GUI
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
            label1 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            listBox1 = new ListBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            toolStripStatusLabel3 = new ToolStripStatusLabel();
            button2 = new Button();
            comboBox2 = new ComboBox();
            label21 = new Label();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 0;
            label1.Text = "Megyék";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 27);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 118);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 2;
            label2.Text = "Kereső";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 152);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(128, 23);
            textBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(161, 152);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Keresés";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 190);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(224, 184);
            listBox1.TabIndex = 5;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 382);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 6;
            label3.Text = "Találatok száma:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(121, 382);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 7;
            label4.Text = "xxxxx";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label5.Location = new Point(312, 30);
            label5.Name = "label5";
            label5.Size = new Size(90, 30);
            label5.TabIndex = 8;
            label5.Text = "Adatlap";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label6.Location = new Point(580, 30);
            label6.Name = "label6";
            label6.Size = new Size(139, 30);
            label6.TabIndex = 9;
            label6.Text = "Irányítószám";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(312, 85);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 10;
            label7.Text = "Jogállás:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(312, 118);
            label8.Name = "label8";
            label8.Size = new Size(46, 15);
            label8.TabIndex = 11;
            label8.Text = "Megye:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(312, 160);
            label9.Name = "label9";
            label9.Size = new Size(90, 15);
            label9.TabIndex = 12;
            label9.Text = "Megyeszékhely:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(313, 202);
            label10.Name = "label10";
            label10.Size = new Size(45, 15);
            label10.TabIndex = 13;
            label10.Text = "Terület:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(312, 235);
            label11.Name = "label11";
            label11.Size = new Size(58, 15);
            label11.TabIndex = 14;
            label11.Text = "Lakosság:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(312, 274);
            label12.Name = "label12";
            label12.Size = new Size(88, 15);
            label12.TabIndex = 15;
            label12.Text = "Lakások száma:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(417, 85);
            label13.Name = "label13";
            label13.Size = new Size(31, 15);
            label13.TabIndex = 16;
            label13.Text = "xxxx";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(417, 118);
            label14.Name = "label14";
            label14.Size = new Size(31, 15);
            label14.TabIndex = 17;
            label14.Text = "xxxx";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(417, 160);
            label15.Name = "label15";
            label15.Size = new Size(31, 15);
            label15.TabIndex = 18;
            label15.Text = "xxxx";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(417, 202);
            label16.Name = "label16";
            label16.Size = new Size(31, 15);
            label16.TabIndex = 19;
            label16.Text = "xxxx";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(417, 235);
            label17.Name = "label17";
            label17.Size = new Size(31, 15);
            label17.TabIndex = 20;
            label17.Text = "xxxx";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(417, 274);
            label18.Name = "label18";
            label18.Size = new Size(31, 15);
            label18.TabIndex = 21;
            label18.Text = "xxxx";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label19.ForeColor = Color.IndianRed;
            label19.Location = new Point(395, 30);
            label19.Name = "label19";
            label19.Size = new Size(53, 30);
            label19.TabIndex = 22;
            label19.Text = "xxxx";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label20.Location = new Point(731, 30);
            label20.Name = "label20";
            label20.Size = new Size(57, 30);
            label20.TabIndex = 23;
            label20.Text = "xxxx";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2, toolStripStatusLabel3 });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 24;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(118, 17);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(118, 17);
            toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new Size(118, 17);
            toolStripStatusLabel3.Text = "toolStripStatusLabel3";
            // 
            // button2
            // 
            button2.Location = new Point(713, 402);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 25;
            button2.Text = "Kilépés";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(12, 77);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 26;
            comboBox2.Visible = false;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(12, 59);
            label21.Name = "label21";
            label21.Size = new Size(37, 15);
            label21.TabIndex = 27;
            label21.Text = "xxxxx";
            label21.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label21);
            Controls.Add(comboBox2);
            Controls.Add(button2);
            Controls.Add(statusStrip1);
            Controls.Add(label20);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Magyarország települései";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private TextBox textBox1;
        private Button button1;
        private ListBox listBox1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private Button button2;
        private ComboBox comboBox2;
        private Label label21;
    }
}
