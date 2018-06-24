namespace BMSusingCsharp
{
    partial class Fm8employee
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cmb1designation = new System.Windows.Forms.ComboBox();
            this.btnexit1 = new System.Windows.Forms.Button();
            this.btnsave1 = new System.Windows.Forms.Button();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.txtsalary1 = new System.Windows.Forms.TextBox();
            this.txtphone1 = new System.Windows.Forms.TextBox();
            this.txtadd1 = new System.Windows.Forms.TextBox();
            this.txtempname1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtempcode1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.cmb2empname = new System.Windows.Forms.ComboBox();
            this.employeeSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bMSCsharpDataSet8 = new BMSusingCsharp.BMSCsharpDataSet8();
            this.cmb2empcode = new System.Windows.Forms.ComboBox();
            this.cmb2designation = new System.Windows.Forms.ComboBox();
            this.btnexit2 = new System.Windows.Forms.Button();
            this.btnsave2 = new System.Windows.Forms.Button();
            this.dtp2 = new System.Windows.Forms.DateTimePicker();
            this.txtsalary2 = new System.Windows.Forms.TextBox();
            this.txtphone2 = new System.Windows.Forms.TextBox();
            this.txtadd2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtaddemployee = new System.Windows.Forms.Button();
            this.employeeSTableAdapter = new BMSusingCsharp.BMSCsharpDataSet8TableAdapters.employeeSTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bMSCsharpDataSet8)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(706, 592);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gray;
            this.tabPage1.BackgroundImage = global::BMSusingCsharp.Properties.Resources._151;
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.cmb1designation);
            this.tabPage1.Controls.Add(this.btnexit1);
            this.tabPage1.Controls.Add(this.btnsave1);
            this.tabPage1.Controls.Add(this.dtp1);
            this.tabPage1.Controls.Add(this.txtsalary1);
            this.tabPage1.Controls.Add(this.txtphone1);
            this.tabPage1.Controls.Add(this.txtadd1);
            this.tabPage1.Controls.Add(this.txtempname1);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.txtempcode1);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.button7);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(679, 584);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ADD EMPLOYEE";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label18.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(28, 571);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(623, 10);
            this.label18.TabIndex = 45;
            this.label18.Text = "\r\n";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label17.Dock = System.Windows.Forms.DockStyle.Left;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(3, 41);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(25, 540);
            this.label17.TabIndex = 44;
            this.label17.Text = "\r\n";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label16.Dock = System.Windows.Forms.DockStyle.Right;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(651, 41);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(25, 540);
            this.label16.TabIndex = 43;
            this.label16.Text = "\r\n";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label15.Dock = System.Windows.Forms.DockStyle.Top;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(3, 3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(673, 38);
            this.label15.TabIndex = 42;
            this.label15.Text = "EMPLOYEE DETAILS";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb1designation
            // 
            this.cmb1designation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cmb1designation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb1designation.FormattingEnabled = true;
            this.cmb1designation.Items.AddRange(new object[] {
            "Manager",
            "Sales executive",
            "General staff",
            "Accountants",
            "Cleaning staff",
            "Watchmen"});
            this.cmb1designation.Location = new System.Drawing.Point(259, 372);
            this.cmb1designation.Name = "cmb1designation";
            this.cmb1designation.Size = new System.Drawing.Size(357, 32);
            this.cmb1designation.TabIndex = 41;
            // 
            // btnexit1
            // 
            this.btnexit1.BackColor = System.Drawing.Color.Red;
            this.btnexit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit1.ForeColor = System.Drawing.Color.White;
            this.btnexit1.Location = new System.Drawing.Point(344, 535);
            this.btnexit1.Name = "btnexit1";
            this.btnexit1.Size = new System.Drawing.Size(174, 40);
            this.btnexit1.TabIndex = 40;
            this.btnexit1.Text = "EXIT";
            this.btnexit1.UseVisualStyleBackColor = false;
            this.btnexit1.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnsave1
            // 
            this.btnsave1.BackColor = System.Drawing.Color.Red;
            this.btnsave1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave1.ForeColor = System.Drawing.Color.White;
            this.btnsave1.Location = new System.Drawing.Point(110, 535);
            this.btnsave1.Name = "btnsave1";
            this.btnsave1.Size = new System.Drawing.Size(174, 40);
            this.btnsave1.TabIndex = 39;
            this.btnsave1.Text = "SAVE";
            this.btnsave1.UseVisualStyleBackColor = false;
            this.btnsave1.Click += new System.EventHandler(this.btnsave1_Click);
            // 
            // dtp1
            // 
            this.dtp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp1.Location = new System.Drawing.Point(259, 475);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(357, 31);
            this.dtp1.TabIndex = 38;
            // 
            // txtsalary1
            // 
            this.txtsalary1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtsalary1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsalary1.ForeColor = System.Drawing.Color.White;
            this.txtsalary1.Location = new System.Drawing.Point(259, 424);
            this.txtsalary1.Name = "txtsalary1";
            this.txtsalary1.Size = new System.Drawing.Size(357, 29);
            this.txtsalary1.TabIndex = 37;
            // 
            // txtphone1
            // 
            this.txtphone1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtphone1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphone1.ForeColor = System.Drawing.Color.White;
            this.txtphone1.Location = new System.Drawing.Point(259, 297);
            this.txtphone1.Name = "txtphone1";
            this.txtphone1.Size = new System.Drawing.Size(357, 29);
            this.txtphone1.TabIndex = 36;
            // 
            // txtadd1
            // 
            this.txtadd1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtadd1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadd1.ForeColor = System.Drawing.Color.White;
            this.txtadd1.Location = new System.Drawing.Point(259, 246);
            this.txtadd1.Name = "txtadd1";
            this.txtadd1.Size = new System.Drawing.Size(357, 29);
            this.txtadd1.TabIndex = 35;
            // 
            // txtempname1
            // 
            this.txtempname1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtempname1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtempname1.ForeColor = System.Drawing.Color.White;
            this.txtempname1.Location = new System.Drawing.Point(259, 189);
            this.txtempname1.Name = "txtempname1";
            this.txtempname1.Size = new System.Drawing.Size(357, 29);
            this.txtempname1.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(40, 475);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(190, 31);
            this.label8.TabIndex = 33;
            this.label8.Text = "DATE OF JOINING";
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(40, 424);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(190, 31);
            this.label9.TabIndex = 32;
            this.label9.Text = "SALARY";
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(40, 374);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(190, 31);
            this.label10.TabIndex = 31;
            this.label10.Text = "DESIGNATION";
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Navy;
            this.label11.Location = new System.Drawing.Point(40, 295);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(190, 31);
            this.label11.TabIndex = 30;
            this.label11.Text = "PHONE NO.";
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Navy;
            this.label12.Location = new System.Drawing.Point(40, 248);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(190, 31);
            this.label12.TabIndex = 29;
            this.label12.Text = "ADDRESS";
            // 
            // label13
            // 
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Navy;
            this.label13.Location = new System.Drawing.Point(40, 187);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(190, 31);
            this.label13.TabIndex = 28;
            this.label13.Text = "EMPLOYEE NAME";
            // 
            // txtempcode1
            // 
            this.txtempcode1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtempcode1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtempcode1.ForeColor = System.Drawing.Color.White;
            this.txtempcode1.Location = new System.Drawing.Point(259, 138);
            this.txtempcode1.Name = "txtempcode1";
            this.txtempcode1.Size = new System.Drawing.Size(357, 29);
            this.txtempcode1.TabIndex = 27;
            this.txtempcode1.TextChanged += new System.EventHandler(this.txtempcode1_TextChanged);
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Navy;
            this.label14.Location = new System.Drawing.Point(40, 140);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(190, 31);
            this.label14.TabIndex = 26;
            this.label14.Text = "EMPLOYEE CODE";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(335, 53);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(321, 35);
            this.button6.TabIndex = 25;
            this.button6.Text = "EDIT EMPLOYEE";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Gray;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Location = new System.Drawing.Point(8, 53);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(321, 35);
            this.button7.TabIndex = 24;
            this.button7.Text = "ADD EMPLOYEE";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPage2.BackgroundImage = global::BMSusingCsharp.Properties.Resources._152;
            this.tabPage2.Controls.Add(this.label22);
            this.tabPage2.Controls.Add(this.label21);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.cmb2empname);
            this.tabPage2.Controls.Add(this.cmb2empcode);
            this.tabPage2.Controls.Add(this.cmb2designation);
            this.tabPage2.Controls.Add(this.btnexit2);
            this.tabPage2.Controls.Add(this.btnsave2);
            this.tabPage2.Controls.Add(this.dtp2);
            this.tabPage2.Controls.Add(this.txtsalary2);
            this.tabPage2.Controls.Add(this.txtphone2);
            this.tabPage2.Controls.Add(this.txtadd2);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.txtaddemployee);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(679, 584);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "EDIT EMPLOYEE";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label22.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(28, 571);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(623, 10);
            this.label22.TabIndex = 30;
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label21.Dock = System.Windows.Forms.DockStyle.Left;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(3, 48);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(25, 533);
            this.label21.TabIndex = 29;
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label20.Dock = System.Windows.Forms.DockStyle.Right;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(651, 48);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(25, 533);
            this.label20.TabIndex = 28;
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label19.Dock = System.Windows.Forms.DockStyle.Top;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(3, 3);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(673, 45);
            this.label19.TabIndex = 27;
            this.label19.Text = "EMPLOYEE DETAILS";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(444, 525);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 40);
            this.button2.TabIndex = 26;
            this.button2.Text = "DELETE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmb2empname
            // 
            this.cmb2empname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cmb2empname.DataSource = this.employeeSBindingSource;
            this.cmb2empname.DisplayMember = "empname";
            this.cmb2empname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb2empname.FormattingEnabled = true;
            this.cmb2empname.Location = new System.Drawing.Point(261, 152);
            this.cmb2empname.Name = "cmb2empname";
            this.cmb2empname.Size = new System.Drawing.Size(357, 32);
            this.cmb2empname.TabIndex = 25;
            this.cmb2empname.SelectedIndexChanged += new System.EventHandler(this.cmb2empname_SelectedIndexChanged);
            // 
            // employeeSBindingSource
            // 
            this.employeeSBindingSource.DataMember = "employeeS";
            this.employeeSBindingSource.DataSource = this.bMSCsharpDataSet8;
            // 
            // bMSCsharpDataSet8
            // 
            this.bMSCsharpDataSet8.DataSetName = "BMSCsharpDataSet8";
            this.bMSCsharpDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmb2empcode
            // 
            this.cmb2empcode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cmb2empcode.DataSource = this.employeeSBindingSource;
            this.cmb2empcode.DisplayMember = "empcode";
            this.cmb2empcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb2empcode.FormattingEnabled = true;
            this.cmb2empcode.Location = new System.Drawing.Point(261, 105);
            this.cmb2empcode.Name = "cmb2empcode";
            this.cmb2empcode.Size = new System.Drawing.Size(357, 32);
            this.cmb2empcode.TabIndex = 24;
            this.cmb2empcode.SelectedIndexChanged += new System.EventHandler(this.cmb2empcode_SelectedIndexChanged);
            // 
            // cmb2designation
            // 
            this.cmb2designation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cmb2designation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb2designation.FormattingEnabled = true;
            this.cmb2designation.Items.AddRange(new object[] {
            "Manager",
            "Sales executive",
            "General staff",
            "Accountants",
            "Cleaning staff",
            "Watchmen"});
            this.cmb2designation.Location = new System.Drawing.Point(261, 362);
            this.cmb2designation.Name = "cmb2designation";
            this.cmb2designation.Size = new System.Drawing.Size(357, 32);
            this.cmb2designation.TabIndex = 23;
            // 
            // btnexit2
            // 
            this.btnexit2.BackColor = System.Drawing.Color.Red;
            this.btnexit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit2.ForeColor = System.Drawing.Color.White;
            this.btnexit2.Location = new System.Drawing.Point(247, 525);
            this.btnexit2.Name = "btnexit2";
            this.btnexit2.Size = new System.Drawing.Size(174, 40);
            this.btnexit2.TabIndex = 22;
            this.btnexit2.Text = "EXIT";
            this.btnexit2.UseVisualStyleBackColor = false;
            this.btnexit2.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnsave2
            // 
            this.btnsave2.BackColor = System.Drawing.Color.Red;
            this.btnsave2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave2.ForeColor = System.Drawing.Color.White;
            this.btnsave2.Location = new System.Drawing.Point(42, 525);
            this.btnsave2.Name = "btnsave2";
            this.btnsave2.Size = new System.Drawing.Size(174, 40);
            this.btnsave2.TabIndex = 21;
            this.btnsave2.Text = "UPDATE";
            this.btnsave2.UseVisualStyleBackColor = false;
            this.btnsave2.Click += new System.EventHandler(this.btnsave2_Click);
            // 
            // dtp2
            // 
            this.dtp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp2.Location = new System.Drawing.Point(261, 465);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(357, 31);
            this.dtp2.TabIndex = 20;
            // 
            // txtsalary2
            // 
            this.txtsalary2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtsalary2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsalary2.ForeColor = System.Drawing.Color.Black;
            this.txtsalary2.Location = new System.Drawing.Point(261, 414);
            this.txtsalary2.Name = "txtsalary2";
            this.txtsalary2.Size = new System.Drawing.Size(357, 29);
            this.txtsalary2.TabIndex = 19;
            // 
            // txtphone2
            // 
            this.txtphone2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtphone2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphone2.ForeColor = System.Drawing.Color.Black;
            this.txtphone2.Location = new System.Drawing.Point(261, 287);
            this.txtphone2.Name = "txtphone2";
            this.txtphone2.Size = new System.Drawing.Size(357, 29);
            this.txtphone2.TabIndex = 17;
            // 
            // txtadd2
            // 
            this.txtadd2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtadd2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadd2.ForeColor = System.Drawing.Color.Black;
            this.txtadd2.Location = new System.Drawing.Point(261, 236);
            this.txtadd2.Name = "txtadd2";
            this.txtadd2.Size = new System.Drawing.Size(357, 29);
            this.txtadd2.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(42, 465);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 31);
            this.label7.TabIndex = 14;
            this.label7.Text = "DATE OF JOINING";
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(42, 414);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 31);
            this.label6.TabIndex = 12;
            this.label6.Text = "SALARY";
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(42, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 31);
            this.label5.TabIndex = 10;
            this.label5.Text = "DESIGNATION";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(42, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "PHONE NO.";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(42, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "ADDRESS";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(42, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "EMPLOYEE NAME";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(42, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "EMPLOYEE CODE";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(347, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(321, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "EDIT EMPLOYEE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtaddemployee
            // 
            this.txtaddemployee.BackColor = System.Drawing.Color.Gray;
            this.txtaddemployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddemployee.ForeColor = System.Drawing.Color.Black;
            this.txtaddemployee.Location = new System.Drawing.Point(3, 51);
            this.txtaddemployee.Name = "txtaddemployee";
            this.txtaddemployee.Size = new System.Drawing.Size(321, 35);
            this.txtaddemployee.TabIndex = 0;
            this.txtaddemployee.Text = "ADD EMPLOYEE";
            this.txtaddemployee.UseVisualStyleBackColor = false;
            this.txtaddemployee.Click += new System.EventHandler(this.txtaddemployee_Click);
            // 
            // employeeSTableAdapter
            // 
            this.employeeSTableAdapter.ClearBeforeFill = true;
            // 
            // Fm8employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(731, 592);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Fm8employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fm8employee";
            this.Load += new System.EventHandler(this.Fm8employee_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bMSCsharpDataSet8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button txtaddemployee;
        private System.Windows.Forms.TextBox txtsalary2;
        private System.Windows.Forms.TextBox txtphone2;
        private System.Windows.Forms.TextBox txtadd2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp2;
        private System.Windows.Forms.ComboBox cmb2designation;
        private System.Windows.Forms.Button btnexit2;
        private System.Windows.Forms.Button btnsave2;
        private System.Windows.Forms.ComboBox cmb1designation;
        private System.Windows.Forms.Button btnexit1;
        private System.Windows.Forms.Button btnsave1;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.TextBox txtsalary1;
        private System.Windows.Forms.TextBox txtphone1;
        private System.Windows.Forms.TextBox txtadd1;
        private System.Windows.Forms.TextBox txtempname1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtempcode1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ComboBox cmb2empname;
        private System.Windows.Forms.ComboBox cmb2empcode;
        private BMSCsharpDataSet8 bMSCsharpDataSet8;
        private System.Windows.Forms.BindingSource employeeSBindingSource;
        private BMSCsharpDataSet8TableAdapters.employeeSTableAdapter employeeSTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
    }
}