namespace Store_Products
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            textBox6 = new TextBox();
            label9 = new Label();
            textBox5 = new TextBox();
            label3 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            txtResult = new TextBox();
            label10 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label8 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label7 = new Label();
            textBox3 = new TextBox();
            label6 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            txtid = new TextBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            listView1 = new ListView();
            ChID = new ColumnHeader();
            ChPDN = new ColumnHeader();
            ChQT = new ColumnHeader();
            ChTT = new ColumnHeader();
            ChDT = new ColumnHeader();
            ChEXD = new ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._44f9081d41eeb6bb7ec4ef47ade8e8e7;
            pictureBox1.Location = new Point(6, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 192, 192);
            label1.CausesValidation = false;
            label1.Font = new Font("Segoe Print", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Tomato;
            label1.Location = new Point(168, 11);
            label1.Name = "label1";
            label1.Size = new Size(613, 85);
            label1.TabIndex = 1;
            label1.Text = "Store Products Unilever";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(button7);
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txtResult);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtid);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(17, 127);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(885, 383);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Information Products";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button7
            // 
            button7.Location = new Point(474, 297);
            button7.Name = "button7";
            button7.Size = new Size(121, 48);
            button7.TabIndex = 40;
            button7.Text = "Check S&tock";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Location = new Point(614, 297);
            button6.Name = "button6";
            button6.Size = new Size(162, 48);
            button6.TabIndex = 39;
            button6.Text = "Change &Language";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(383, 297);
            button5.Name = "button5";
            button5.Size = new Size(75, 48);
            button5.TabIndex = 38;
            button5.Text = "&Save";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(292, 297);
            button4.Name = "button4";
            button4.Size = new Size(75, 48);
            button4.TabIndex = 37;
            button4.Text = "&Delete";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(682, 121);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(178, 32);
            textBox6.TabIndex = 36;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(493, 128);
            label9.Name = "label9";
            label9.Size = new Size(71, 24);
            label9.TabIndex = 35;
            label9.Text = "Profit Cost";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(133, 114);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(178, 32);
            textBox5.TabIndex = 34;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 118);
            label3.Name = "label3";
            label3.Size = new Size(70, 24);
            label3.TabIndex = 33;
            label3.Text = "Price Cost";
            // 
            // button3
            // 
            button3.Location = new Point(197, 297);
            button3.Name = "button3";
            button3.Size = new Size(75, 48);
            button3.TabIndex = 32;
            button3.Text = "&Clear";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(104, 297);
            button2.Name = "button2";
            button2.Size = new Size(75, 48);
            button2.TabIndex = 31;
            button2.Text = "&Edit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(11, 297);
            button1.Name = "button1";
            button1.Size = new Size(75, 48);
            button1.TabIndex = 30;
            button1.Text = "&Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(133, 223);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(727, 32);
            txtResult.TabIndex = 29;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(39, 230);
            label10.Name = "label10";
            label10.Size = new Size(38, 24);
            label10.TabIndex = 28;
            label10.Text = "Total";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(682, 165);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(178, 32);
            dateTimePicker2.TabIndex = 26;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(493, 172);
            label8.Name = "label8";
            label8.Size = new Size(139, 24);
            label8.TabIndex = 25;
            label8.Text = "Expire Date              .";
            label8.Click += label8_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(133, 158);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(178, 32);
            dateTimePicker1.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(37, 158);
            label7.Name = "label7";
            label7.Size = new Size(37, 24);
            label7.TabIndex = 23;
            label7.Text = "Date";
            label7.Click += label7_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(682, 77);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(178, 32);
            textBox3.TabIndex = 22;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(493, 80);
            label6.Name = "label6";
            label6.Size = new Size(69, 24);
            label6.TabIndex = 21;
            label6.Text = "Price Sale";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(133, 71);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(178, 32);
            textBox2.TabIndex = 20;
            textBox2.TextChanged += textBox2_TextChanged;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 71);
            label5.Name = "label5";
            label5.Size = new Size(60, 24);
            label5.TabIndex = 19;
            label5.Text = "Quantity";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.ForeColor = SystemColors.WindowText;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Clear Men", "Dove", "Sunsilk", "Pond", "Nivea", "Vaseline", "Citra" });
            comboBox1.Location = new Point(682, 31);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(178, 32);
            comboBox1.TabIndex = 18;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(493, 37);
            label4.Name = "label4";
            label4.Size = new Size(99, 24);
            label4.TabIndex = 17;
            label4.Text = "Name Products";
            // 
            // txtid
            // 
            txtid.Location = new Point(133, 31);
            txtid.Name = "txtid";
            txtid.Size = new Size(178, 32);
            txtid.TabIndex = 16;
            txtid.KeyPress += txtid_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 31);
            label2.Name = "label2";
            label2.Size = new Size(23, 24);
            label2.TabIndex = 15;
            label2.Text = "ID";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(listView1);
            groupBox2.Location = new Point(16, 516);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(886, 230);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "List Item Products";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { ChID, ChPDN, ChQT, ChTT, ChDT, ChEXD });
            listView1.FullRowSelect = true;
            listView1.Location = new Point(6, 31);
            listView1.Name = "listView1";
            listView1.Size = new Size(873, 193);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SizeChanged += listView1_SizeChanged;
            // 
            // ChID
            // 
            ChID.Text = "ID";
            // 
            // ChPDN
            // 
            ChPDN.Text = "Products Name";
            ChPDN.Width = 135;
            // 
            // ChQT
            // 
            ChQT.Text = "Quantity";
            ChQT.TextAlign = HorizontalAlignment.Center;
            ChQT.Width = 90;
            // 
            // ChTT
            // 
            ChTT.Text = "Total";
            ChTT.TextAlign = HorizontalAlignment.Center;
            ChTT.Width = 100;
            // 
            // ChDT
            // 
            ChDT.Text = "Date";
            ChDT.Width = 125;
            // 
            // ChEXD
            // 
            ChEXD.Text = "Expire Date";
            ChEXD.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(914, 749);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("Khmer OS Battambang", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 5, 3, 5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private GroupBox groupBox1;
        private DateTimePicker dateTimePicker2;
        private Label label8;
        private DateTimePicker dateTimePicker1;
        private Label label7;
        private TextBox textBox3;
        private Label label6;
        private TextBox textBox2;
        private Label label5;
        private ComboBox comboBox1;
        private Label label4;
        private TextBox txtid;
        private Label label2;
        private Label label10;
        private TextBox txtResult;
        private Button button2;
        private Button button1;
        private Button button3;
        private TextBox textBox5;
        private Label label3;
        private TextBox textBox6;
        private Label label9;
        private Button button4;
        private Button button6;
        private Button button5;
        private GroupBox groupBox2;
        private ListView listView1;
        private Button button7;
        private ColumnHeader ChID;
        private ColumnHeader ChPDN;
        private ColumnHeader ChQT;
        private ColumnHeader ChTT;
        private ColumnHeader ChDT;
        private ColumnHeader ChEXD;
    }
}