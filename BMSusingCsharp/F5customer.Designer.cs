namespace BMSusingCsharp
{
    partial class F5customer
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
            this.txt1address = new System.Windows.Forms.TextBox();
            this.btn1phnno = new System.Windows.Forms.Label();
            this.btn1address = new System.Windows.Forms.Label();
            this.cmb2custname = new System.Windows.Forms.ComboBox();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cust = new BMSusingCsharp.cust();
            this.cmb2custcode = new System.Windows.Forms.ComboBox();
            this.lbl2selectcust = new System.Windows.Forms.Label();
            this.btn2exit = new System.Windows.Forms.Button();
            this.btn2update = new System.Windows.Forms.Button();
            this.btn1custname = new System.Windows.Forms.Label();
            this.txt2phnno = new System.Windows.Forms.TextBox();
            this.lbl2phnno = new System.Windows.Forms.Label();
            this.lbl2address = new System.Windows.Forms.Label();
            this.txt1custname = new System.Windows.Forms.TextBox();
            this.txt1custcode = new System.Windows.Forms.TextBox();
            this.lbl1custcode = new System.Windows.Forms.Label();
            this.txt2address = new System.Windows.Forms.TextBox();
            this.btn1newcust = new System.Windows.Forms.Button();
            this.btn1exit = new System.Windows.Forms.Button();
            this.btn1save = new System.Windows.Forms.Button();
            this.btn2editcust = new System.Windows.Forms.Button();
            this.btn2newcust = new System.Windows.Forms.Button();
            this.btn1editcust = new System.Windows.Forms.Button();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage2 = new System.Windows.Forms.TabPage();
            this.txt1phnno = new System.Windows.Forms.TextBox();
            this.customerTableAdapter = new BMSusingCsharp.custTableAdapters.customerTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cust)).BeginInit();
            this.TabPage1.SuspendLayout();
            this.TabControl1.SuspendLayout();
            this.TabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt1address
            // 
            this.txt1address.BackColor = System.Drawing.SystemColors.InfoText;
            this.txt1address.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1address.ForeColor = System.Drawing.SystemColors.Window;
            this.txt1address.Location = new System.Drawing.Point(308, 290);
            this.txt1address.Name = "txt1address";
            this.txt1address.Size = new System.Drawing.Size(300, 31);
            this.txt1address.TabIndex = 44;
            // 
            // btn1phnno
            // 
            this.btn1phnno.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btn1phnno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1phnno.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn1phnno.Location = new System.Drawing.Point(44, 358);
            this.btn1phnno.Name = "btn1phnno";
            this.btn1phnno.Size = new System.Drawing.Size(236, 35);
            this.btn1phnno.TabIndex = 42;
            this.btn1phnno.Text = "PHONE NUMBER";
            // 
            // btn1address
            // 
            this.btn1address.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btn1address.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1address.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn1address.Location = new System.Drawing.Point(44, 286);
            this.btn1address.Name = "btn1address";
            this.btn1address.Size = new System.Drawing.Size(236, 35);
            this.btn1address.TabIndex = 41;
            this.btn1address.Text = "ADDRESS";
            // 
            // cmb2custname
            // 
            this.cmb2custname.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cmb2custname.DataSource = this.customerBindingSource;
            this.cmb2custname.DisplayMember = "custname";
            this.cmb2custname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb2custname.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.cmb2custname.FormattingEnabled = true;
            this.cmb2custname.Location = new System.Drawing.Point(306, 214);
            this.cmb2custname.Name = "cmb2custname";
            this.cmb2custname.Size = new System.Drawing.Size(300, 32);
            this.cmb2custname.TabIndex = 38;
            this.cmb2custname.SelectedIndexChanged += new System.EventHandler(this.cmb2custname_SelectedIndexChanged);
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "customer";
            this.customerBindingSource.DataSource = this.cust;
            // 
            // cust
            // 
            this.cust.DataSetName = "cust";
            this.cust.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmb2custcode
            // 
            this.cmb2custcode.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cmb2custcode.DataSource = this.customerBindingSource;
            this.cmb2custcode.DisplayMember = "custcode";
            this.cmb2custcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb2custcode.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.cmb2custcode.FormattingEnabled = true;
            this.cmb2custcode.Location = new System.Drawing.Point(306, 130);
            this.cmb2custcode.Name = "cmb2custcode";
            this.cmb2custcode.Size = new System.Drawing.Size(300, 32);
            this.cmb2custcode.TabIndex = 37;
            this.cmb2custcode.SelectedIndexChanged += new System.EventHandler(this.cmb2custcode_SelectedIndexChanged);
            // 
            // lbl2selectcust
            // 
            this.lbl2selectcust.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl2selectcust.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2selectcust.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl2selectcust.Location = new System.Drawing.Point(42, 167);
            this.lbl2selectcust.Name = "lbl2selectcust";
            this.lbl2selectcust.Size = new System.Drawing.Size(236, 35);
            this.lbl2selectcust.TabIndex = 36;
            this.lbl2selectcust.Text = "SELECT CUSTOMER";
            // 
            // btn2exit
            // 
            this.btn2exit.BackColor = System.Drawing.Color.Black;
            this.btn2exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn2exit.Location = new System.Drawing.Point(232, 458);
            this.btn2exit.Name = "btn2exit";
            this.btn2exit.Size = new System.Drawing.Size(150, 35);
            this.btn2exit.TabIndex = 35;
            this.btn2exit.Text = "EXIT";
            this.btn2exit.UseVisualStyleBackColor = false;
            this.btn2exit.Click += new System.EventHandler(this.btn2exit_Click);
            // 
            // btn2update
            // 
            this.btn2update.BackColor = System.Drawing.Color.Black;
            this.btn2update.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2update.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn2update.Location = new System.Drawing.Point(59, 458);
            this.btn2update.Name = "btn2update";
            this.btn2update.Size = new System.Drawing.Size(150, 35);
            this.btn2update.TabIndex = 34;
            this.btn2update.Text = "UPDATE";
            this.btn2update.UseVisualStyleBackColor = false;
            this.btn2update.Click += new System.EventHandler(this.btn2update_Click);
            // 
            // btn1custname
            // 
            this.btn1custname.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btn1custname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1custname.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn1custname.Location = new System.Drawing.Point(44, 209);
            this.btn1custname.Name = "btn1custname";
            this.btn1custname.Size = new System.Drawing.Size(236, 35);
            this.btn1custname.TabIndex = 40;
            this.btn1custname.Text = "CUSTOMER NAME";
            // 
            // txt2phnno
            // 
            this.txt2phnno.BackColor = System.Drawing.SystemColors.InfoText;
            this.txt2phnno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt2phnno.ForeColor = System.Drawing.SystemColors.Window;
            this.txt2phnno.Location = new System.Drawing.Point(306, 364);
            this.txt2phnno.Name = "txt2phnno";
            this.txt2phnno.Size = new System.Drawing.Size(300, 31);
            this.txt2phnno.TabIndex = 30;
            this.txt2phnno.TextChanged += new System.EventHandler(this.txt2phnno_TextChanged);
            // 
            // lbl2phnno
            // 
            this.lbl2phnno.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl2phnno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2phnno.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl2phnno.Location = new System.Drawing.Point(42, 360);
            this.lbl2phnno.Name = "lbl2phnno";
            this.lbl2phnno.Size = new System.Drawing.Size(236, 35);
            this.lbl2phnno.TabIndex = 25;
            this.lbl2phnno.Text = "PHONE NUMBER";
            // 
            // lbl2address
            // 
            this.lbl2address.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl2address.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2address.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl2address.Location = new System.Drawing.Point(42, 288);
            this.lbl2address.Name = "lbl2address";
            this.lbl2address.Size = new System.Drawing.Size(236, 35);
            this.lbl2address.TabIndex = 24;
            this.lbl2address.Text = "ADDRESS";
            // 
            // txt1custname
            // 
            this.txt1custname.BackColor = System.Drawing.SystemColors.InfoText;
            this.txt1custname.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt1custname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1custname.ForeColor = System.Drawing.SystemColors.Window;
            this.txt1custname.Location = new System.Drawing.Point(308, 213);
            this.txt1custname.Name = "txt1custname";
            this.txt1custname.Size = new System.Drawing.Size(300, 31);
            this.txt1custname.TabIndex = 43;
            // 
            // txt1custcode
            // 
            this.txt1custcode.BackColor = System.Drawing.SystemColors.InfoText;
            this.txt1custcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1custcode.ForeColor = System.Drawing.SystemColors.Window;
            this.txt1custcode.Location = new System.Drawing.Point(308, 129);
            this.txt1custcode.Name = "txt1custcode";
            this.txt1custcode.Size = new System.Drawing.Size(300, 31);
            this.txt1custcode.TabIndex = 39;
            // 
            // lbl1custcode
            // 
            this.lbl1custcode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl1custcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1custcode.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl1custcode.Location = new System.Drawing.Point(44, 125);
            this.lbl1custcode.Name = "lbl1custcode";
            this.lbl1custcode.Size = new System.Drawing.Size(236, 35);
            this.lbl1custcode.TabIndex = 38;
            this.lbl1custcode.Text = "CUSTOMER CODE";
            // 
            // txt2address
            // 
            this.txt2address.BackColor = System.Drawing.SystemColors.InfoText;
            this.txt2address.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt2address.ForeColor = System.Drawing.SystemColors.Window;
            this.txt2address.Location = new System.Drawing.Point(306, 292);
            this.txt2address.Name = "txt2address";
            this.txt2address.Size = new System.Drawing.Size(300, 31);
            this.txt2address.TabIndex = 29;
            // 
            // btn1newcust
            // 
            this.btn1newcust.BackColor = System.Drawing.Color.Cyan;
            this.btn1newcust.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1newcust.ForeColor = System.Drawing.Color.Fuchsia;
            this.btn1newcust.Location = new System.Drawing.Point(22, 56);
            this.btn1newcust.Name = "btn1newcust";
            this.btn1newcust.Size = new System.Drawing.Size(299, 50);
            this.btn1newcust.TabIndex = 36;
            this.btn1newcust.Text = "NEW CUSTOMER";
            this.btn1newcust.UseVisualStyleBackColor = false;
            this.btn1newcust.Click += new System.EventHandler(this.btn1newcust_Click);
            // 
            // btn1exit
            // 
            this.btn1exit.BackColor = System.Drawing.Color.Black;
            this.btn1exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn1exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn1exit.Location = new System.Drawing.Point(359, 458);
            this.btn1exit.Name = "btn1exit";
            this.btn1exit.Size = new System.Drawing.Size(150, 35);
            this.btn1exit.TabIndex = 47;
            this.btn1exit.Text = "EXIT";
            this.btn1exit.UseVisualStyleBackColor = false;
            this.btn1exit.Click += new System.EventHandler(this.btn1exit_Click);
            // 
            // btn1save
            // 
            this.btn1save.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1save.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn1save.Location = new System.Drawing.Point(95, 458);
            this.btn1save.Name = "btn1save";
            this.btn1save.Size = new System.Drawing.Size(150, 35);
            this.btn1save.TabIndex = 46;
            this.btn1save.Text = "SAVE";
            this.btn1save.UseVisualStyleBackColor = false;
            this.btn1save.Click += new System.EventHandler(this.btn1save_Click);
            // 
            // btn2editcust
            // 
            this.btn2editcust.BackColor = System.Drawing.Color.Cyan;
            this.btn2editcust.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2editcust.ForeColor = System.Drawing.Color.Fuchsia;
            this.btn2editcust.Location = new System.Drawing.Point(346, 56);
            this.btn2editcust.Name = "btn2editcust";
            this.btn2editcust.Size = new System.Drawing.Size(299, 50);
            this.btn2editcust.TabIndex = 20;
            this.btn2editcust.Text = "EDIT CUSTOMER";
            this.btn2editcust.UseVisualStyleBackColor = false;
            this.btn2editcust.Click += new System.EventHandler(this.btn2editcust_Click);
            // 
            // btn2newcust
            // 
            this.btn2newcust.BackColor = System.Drawing.Color.Cyan;
            this.btn2newcust.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2newcust.ForeColor = System.Drawing.Color.Fuchsia;
            this.btn2newcust.Location = new System.Drawing.Point(24, 56);
            this.btn2newcust.Name = "btn2newcust";
            this.btn2newcust.Size = new System.Drawing.Size(299, 50);
            this.btn2newcust.TabIndex = 19;
            this.btn2newcust.Text = "NEW CUSTOMER";
            this.btn2newcust.UseVisualStyleBackColor = false;
            this.btn2newcust.Click += new System.EventHandler(this.btn2newcust_Click);
            // 
            // btn1editcust
            // 
            this.btn1editcust.BackColor = System.Drawing.Color.Cyan;
            this.btn1editcust.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1editcust.ForeColor = System.Drawing.Color.Fuchsia;
            this.btn1editcust.Location = new System.Drawing.Point(342, 56);
            this.btn1editcust.Name = "btn1editcust";
            this.btn1editcust.Size = new System.Drawing.Size(299, 50);
            this.btn1editcust.TabIndex = 37;
            this.btn1editcust.Text = "EDIT CUSTOMER";
            this.btn1editcust.UseVisualStyleBackColor = false;
            this.btn1editcust.Click += new System.EventHandler(this.btn1editcust_Click);
            // 
            // TabPage1
            // 
            this.TabPage1.BackColor = System.Drawing.Color.Purple;
            this.TabPage1.BackgroundImage = global::BMSusingCsharp.Properties.Resources._147;
            this.TabPage1.Controls.Add(this.label8);
            this.TabPage1.Controls.Add(this.label7);
            this.TabPage1.Controls.Add(this.label6);
            this.TabPage1.Controls.Add(this.label1);
            this.TabPage1.Controls.Add(this.button1);
            this.TabPage1.Controls.Add(this.cmb2custname);
            this.TabPage1.Controls.Add(this.cmb2custcode);
            this.TabPage1.Controls.Add(this.lbl2selectcust);
            this.TabPage1.Controls.Add(this.btn2exit);
            this.TabPage1.Controls.Add(this.btn2update);
            this.TabPage1.Controls.Add(this.txt2phnno);
            this.TabPage1.Controls.Add(this.txt2address);
            this.TabPage1.Controls.Add(this.lbl2phnno);
            this.TabPage1.Controls.Add(this.lbl2address);
            this.TabPage1.Controls.Add(this.btn2editcust);
            this.TabPage1.Controls.Add(this.btn2newcust);
            this.TabPage1.Location = new System.Drawing.Point(4, 4);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(707, 639);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "CUSTOMER";
            this.TabPage1.Click += new System.EventHandler(this.TabPage1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(404, 458);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 35);
            this.button1.TabIndex = 39;
            this.button1.Text = "DELETE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TabControl1
            // 
            this.TabControl1.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this.TabPage2);
            this.TabControl1.Location = new System.Drawing.Point(2, 2);
            this.TabControl1.Multiline = true;
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(734, 647);
            this.TabControl1.TabIndex = 1;
            // 
            // TabPage2
            // 
            this.TabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.TabPage2.BackgroundImage = global::BMSusingCsharp.Properties.Resources._146;
            this.TabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TabPage2.Controls.Add(this.label5);
            this.TabPage2.Controls.Add(this.label4);
            this.TabPage2.Controls.Add(this.label3);
            this.TabPage2.Controls.Add(this.label2);
            this.TabPage2.Controls.Add(this.btn1exit);
            this.TabPage2.Controls.Add(this.btn1save);
            this.TabPage2.Controls.Add(this.txt1phnno);
            this.TabPage2.Controls.Add(this.txt1address);
            this.TabPage2.Controls.Add(this.txt1custname);
            this.TabPage2.Controls.Add(this.btn1phnno);
            this.TabPage2.Controls.Add(this.btn1address);
            this.TabPage2.Controls.Add(this.btn1custname);
            this.TabPage2.Controls.Add(this.txt1custcode);
            this.TabPage2.Controls.Add(this.lbl1custcode);
            this.TabPage2.Controls.Add(this.btn1editcust);
            this.TabPage2.Controls.Add(this.btn1newcust);
            this.TabPage2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.TabPage2.Location = new System.Drawing.Point(4, 4);
            this.TabPage2.Name = "TabPage2";
            this.TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage2.Size = new System.Drawing.Size(707, 639);
            this.TabPage2.TabIndex = 1;
            this.TabPage2.Text = "ADD OR MODIFY";
            // 
            // txt1phnno
            // 
            this.txt1phnno.BackColor = System.Drawing.SystemColors.InfoText;
            this.txt1phnno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1phnno.ForeColor = System.Drawing.SystemColors.Window;
            this.txt1phnno.Location = new System.Drawing.Point(308, 362);
            this.txt1phnno.Name = "txt1phnno";
            this.txt1phnno.Size = new System.Drawing.Size(300, 31);
            this.txt1phnno.TabIndex = 45;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(701, 50);
            this.label1.TabIndex = 40;
            this.label1.Text = "CUSTOMER DETAILS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(701, 50);
            this.label2.TabIndex = 48;
            this.label2.Text = "CUSTOMER DETAILS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Yellow;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Location = new System.Drawing.Point(654, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 583);
            this.label3.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Yellow;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Location = new System.Drawing.Point(3, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 583);
            this.label4.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Yellow;
            this.label5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label5.Location = new System.Drawing.Point(26, 506);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(628, 130);
            this.label5.TabIndex = 51;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Yellow;
            this.label6.Dock = System.Windows.Forms.DockStyle.Right;
            this.label6.Location = new System.Drawing.Point(654, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 583);
            this.label6.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Yellow;
            this.label7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label7.Location = new System.Drawing.Point(3, 506);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(651, 130);
            this.label7.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Yellow;
            this.label8.Dock = System.Windows.Forms.DockStyle.Left;
            this.label8.Location = new System.Drawing.Point(3, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 453);
            this.label8.TabIndex = 43;
            // 
            // F5customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(684, 531);
            this.Controls.Add(this.TabControl1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F5customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F5customer";
            this.Load += new System.EventHandler(this.F5customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cust)).EndInit();
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            this.TabControl1.ResumeLayout(false);
            this.TabPage2.ResumeLayout(false);
            this.TabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TextBox txt1address;
        internal System.Windows.Forms.Label btn1phnno;
        internal System.Windows.Forms.Label btn1address;
        internal System.Windows.Forms.ComboBox cmb2custname;
        internal System.Windows.Forms.ComboBox cmb2custcode;
        internal System.Windows.Forms.Label lbl2selectcust;
        internal System.Windows.Forms.Button btn2exit;
        internal System.Windows.Forms.Button btn2update;
        internal System.Windows.Forms.Label btn1custname;
        internal System.Windows.Forms.TextBox txt2phnno;
        internal System.Windows.Forms.Label lbl2phnno;
        internal System.Windows.Forms.Label lbl2address;
        internal System.Windows.Forms.TextBox txt1custname;
        internal System.Windows.Forms.TextBox txt1custcode;
        internal System.Windows.Forms.Label lbl1custcode;
        internal System.Windows.Forms.TextBox txt2address;
        internal System.Windows.Forms.Button btn1newcust;
        internal System.Windows.Forms.Button btn1exit;
        internal System.Windows.Forms.Button btn1save;
        internal System.Windows.Forms.Button btn2editcust;
        internal System.Windows.Forms.Button btn2newcust;
        internal System.Windows.Forms.Button btn1editcust;
        internal System.Windows.Forms.TabControl TabControl1;
        internal System.Windows.Forms.TabPage TabPage2;
        internal System.Windows.Forms.TextBox txt1phnno;
        private cust cust;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private custTableAdapters.customerTableAdapter customerTableAdapter;
        internal System.Windows.Forms.Button button1;
        public System.Windows.Forms.TabPage TabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}