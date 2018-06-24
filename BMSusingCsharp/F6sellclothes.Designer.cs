namespace BMSusingCsharp
{
    partial class F6sellclothes
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
            this.lbltitle = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnnewinvoice = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            this.cmbclthtype = new System.Windows.Forms.ComboBox();
            this.lblqnt = new System.Windows.Forms.Label();
            this.cmbcustname = new System.Windows.Forms.ComboBox();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clthsell = new BMSusingCsharp.clthsell();
            this.cmbcustid = new System.Windows.Forms.ComboBox();
            this.lblselectcust = new System.Windows.Forms.Label();
            this.txtinvoiceno = new System.Windows.Forms.TextBox();
            this.lblinvoiceno = new System.Windows.Forms.Label();
            this.cmbclthname = new System.Windows.Forms.ComboBox();
            this.clothesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clthsell2 = new BMSusingCsharp.clthsell2();
            this.cmbclthid = new System.Windows.Forms.ComboBox();
            this.lblclthtype = new System.Windows.Forms.Label();
            this.lblsinglprice = new System.Windows.Forms.Label();
            this.lblavailable = new System.Windows.Forms.Label();
            this.lbldesc = new System.Windows.Forms.Label();
            this.lblselectclth = new System.Windows.Forms.Label();
            this.lblsellingprice = new System.Windows.Forms.Label();
            this.txtsellprice = new System.Windows.Forms.TextBox();
            this.customerTableAdapter = new BMSusingCsharp.clthsellTableAdapters.customerTableAdapter();
            this.clothesTableAdapter = new BMSusingCsharp.clthsell2TableAdapters.clothesTableAdapter();
            this.txtsinglprice = new System.Windows.Forms.Label();
            this.txtavialable = new System.Windows.Forms.Label();
            this.txtqnt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtclthdesc = new System.Windows.Forms.Label();
            this.txtinvisible = new System.Windows.Forms.TextBox();
            this.btneditinvoice = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clthsell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clothesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clthsell2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltitle
            // 
            this.lbltitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbltitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.Color.Black;
            this.lbltitle.Location = new System.Drawing.Point(192, 44);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(406, 45);
            this.lbltitle.TabIndex = 49;
            this.lbltitle.Text = "SALES AND INVOICE";
            this.lbltitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.DimGray;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsave.Location = new System.Drawing.Point(538, 677);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(230, 42);
            this.btnsave.TabIndex = 15;
            this.btnsave.Text = "SAVE";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnnewinvoice
            // 
            this.btnnewinvoice.BackColor = System.Drawing.Color.DimGray;
            this.btnnewinvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnewinvoice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnnewinvoice.Location = new System.Drawing.Point(278, 677);
            this.btnnewinvoice.Name = "btnnewinvoice";
            this.btnnewinvoice.Size = new System.Drawing.Size(230, 42);
            this.btnnewinvoice.TabIndex = 14;
            this.btnnewinvoice.Text = "NEW INVOICE";
            this.btnnewinvoice.UseVisualStyleBackColor = false;
            this.btnnewinvoice.Click += new System.EventHandler(this.btnnewinvoice_Click);
            // 
            // btnprint
            // 
            this.btnprint.BackColor = System.Drawing.Color.DimGray;
            this.btnprint.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnprint.Location = new System.Drawing.Point(12, 677);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(230, 42);
            this.btnprint.TabIndex = 13;
            this.btnprint.Text = "PRINT";
            this.btnprint.UseVisualStyleBackColor = false;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // cmbclthtype
            // 
            this.cmbclthtype.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cmbclthtype.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbclthtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbclthtype.ForeColor = System.Drawing.SystemColors.Info;
            this.cmbclthtype.FormattingEnabled = true;
            this.cmbclthtype.Items.AddRange(new object[] {
            "Stitched ",
            "Unstitched"});
            this.cmbclthtype.Location = new System.Drawing.Point(281, 423);
            this.cmbclthtype.Name = "cmbclthtype";
            this.cmbclthtype.Size = new System.Drawing.Size(202, 33);
            this.cmbclthtype.TabIndex = 8;
            // 
            // lblqnt
            // 
            this.lblqnt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblqnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblqnt.Location = new System.Drawing.Point(268, 496);
            this.lblqnt.Name = "lblqnt";
            this.lblqnt.Size = new System.Drawing.Size(226, 35);
            this.lblqnt.TabIndex = 43;
            this.lblqnt.Text = "QUANTITY PURCHASED";
            // 
            // cmbcustname
            // 
            this.cmbcustname.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cmbcustname.DataSource = this.customerBindingSource;
            this.cmbcustname.DisplayMember = "custname";
            this.cmbcustname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbcustname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcustname.ForeColor = System.Drawing.SystemColors.Info;
            this.cmbcustname.FormattingEnabled = true;
            this.cmbcustname.Location = new System.Drawing.Point(443, 147);
            this.cmbcustname.Name = "cmbcustname";
            this.cmbcustname.Size = new System.Drawing.Size(313, 33);
            this.cmbcustname.TabIndex = 2;
            this.cmbcustname.ValueMember = "custname";
            this.cmbcustname.SelectedIndexChanged += new System.EventHandler(this.cmbcustname_SelectedIndexChanged);
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "customer";
            this.customerBindingSource.DataSource = this.clthsell;
            // 
            // clthsell
            // 
            this.clthsell.DataSetName = "clthsell";
            this.clthsell.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbcustid
            // 
            this.cmbcustid.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cmbcustid.DataSource = this.customerBindingSource;
            this.cmbcustid.DisplayMember = "custcode";
            this.cmbcustid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbcustid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcustid.ForeColor = System.Drawing.SystemColors.Info;
            this.cmbcustid.FormattingEnabled = true;
            this.cmbcustid.Location = new System.Drawing.Point(244, 147);
            this.cmbcustid.Name = "cmbcustid";
            this.cmbcustid.Size = new System.Drawing.Size(193, 33);
            this.cmbcustid.TabIndex = 1;
            this.cmbcustid.ValueMember = "custcode";
            this.cmbcustid.SelectedIndexChanged += new System.EventHandler(this.cmbcustid_SelectedIndexChanged);
            // 
            // lblselectcust
            // 
            this.lblselectcust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblselectcust.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblselectcust.Location = new System.Drawing.Point(-5, 147);
            this.lblselectcust.Name = "lblselectcust";
            this.lblselectcust.Size = new System.Drawing.Size(258, 35);
            this.lblselectcust.TabIndex = 40;
            this.lblselectcust.Text = "SELECT CUSTOMER";
            // 
            // txtinvoiceno
            // 
            this.txtinvoiceno.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtinvoiceno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtinvoiceno.ForeColor = System.Drawing.SystemColors.Info;
            this.txtinvoiceno.Location = new System.Drawing.Point(24, 546);
            this.txtinvoiceno.Name = "txtinvoiceno";
            this.txtinvoiceno.Size = new System.Drawing.Size(202, 31);
            this.txtinvoiceno.TabIndex = 10;
            // 
            // lblinvoiceno
            // 
            this.lblinvoiceno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblinvoiceno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinvoiceno.Location = new System.Drawing.Point(28, 496);
            this.lblinvoiceno.Name = "lblinvoiceno";
            this.lblinvoiceno.Size = new System.Drawing.Size(202, 35);
            this.lblinvoiceno.TabIndex = 36;
            this.lblinvoiceno.Text = "INVOICE NUMBER";
            // 
            // cmbclthname
            // 
            this.cmbclthname.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cmbclthname.DataSource = this.clothesBindingSource;
            this.cmbclthname.DisplayMember = "clothname";
            this.cmbclthname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbclthname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbclthname.ForeColor = System.Drawing.SystemColors.Info;
            this.cmbclthname.FormattingEnabled = true;
            this.cmbclthname.Location = new System.Drawing.Point(443, 198);
            this.cmbclthname.Name = "cmbclthname";
            this.cmbclthname.Size = new System.Drawing.Size(313, 33);
            this.cmbclthname.TabIndex = 4;
            this.cmbclthname.ValueMember = "clothname";
            this.cmbclthname.SelectedIndexChanged += new System.EventHandler(this.cmbclthname_SelectedIndexChanged);
            // 
            // clothesBindingSource
            // 
            this.clothesBindingSource.DataMember = "clothes";
            this.clothesBindingSource.DataSource = this.clthsell2;
            // 
            // clthsell2
            // 
            this.clthsell2.DataSetName = "clthsell2";
            this.clthsell2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbclthid
            // 
            this.cmbclthid.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cmbclthid.DataSource = this.clothesBindingSource;
            this.cmbclthid.DisplayMember = "clothnumber";
            this.cmbclthid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbclthid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbclthid.ForeColor = System.Drawing.SystemColors.Info;
            this.cmbclthid.FormattingEnabled = true;
            this.cmbclthid.Location = new System.Drawing.Point(244, 198);
            this.cmbclthid.Name = "cmbclthid";
            this.cmbclthid.Size = new System.Drawing.Size(193, 33);
            this.cmbclthid.TabIndex = 3;
            this.cmbclthid.ValueMember = "clothnumber";
            this.cmbclthid.SelectedIndexChanged += new System.EventHandler(this.cmbclthid_SelectedIndexChanged);
            // 
            // lblclthtype
            // 
            this.lblclthtype.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblclthtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblclthtype.Location = new System.Drawing.Point(311, 371);
            this.lblclthtype.Name = "lblclthtype";
            this.lblclthtype.Size = new System.Drawing.Size(151, 35);
            this.lblclthtype.TabIndex = 31;
            this.lblclthtype.Text = "CLOTH TYPE";
            // 
            // lblsinglprice
            // 
            this.lblsinglprice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblsinglprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsinglprice.Location = new System.Drawing.Point(554, 371);
            this.lblsinglprice.Name = "lblsinglprice";
            this.lblsinglprice.Size = new System.Drawing.Size(202, 35);
            this.lblsinglprice.TabIndex = 30;
            this.lblsinglprice.Text = "SINGLE PRICE";
            this.lblsinglprice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblavailable
            // 
            this.lblavailable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblavailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblavailable.Location = new System.Drawing.Point(29, 371);
            this.lblavailable.Name = "lblavailable";
            this.lblavailable.Size = new System.Drawing.Size(215, 35);
            this.lblavailable.TabIndex = 29;
            this.lblavailable.Text = "AVAILABLE QUANTITY";
            // 
            // lbldesc
            // 
            this.lbldesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbldesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldesc.Location = new System.Drawing.Point(28, 243);
            this.lbldesc.Name = "lbldesc";
            this.lbldesc.Size = new System.Drawing.Size(202, 35);
            this.lbldesc.TabIndex = 28;
            this.lbldesc.Text = "DESCRIPTION";
            // 
            // lblselectclth
            // 
            this.lblselectclth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblselectclth.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblselectclth.Location = new System.Drawing.Point(28, 196);
            this.lblselectclth.Name = "lblselectclth";
            this.lblselectclth.Size = new System.Drawing.Size(202, 35);
            this.lblselectclth.TabIndex = 26;
            this.lblselectclth.Text = "SELECT CLOTH";
            // 
            // lblsellingprice
            // 
            this.lblsellingprice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblsellingprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsellingprice.Location = new System.Drawing.Point(544, 496);
            this.lblsellingprice.Name = "lblsellingprice";
            this.lblsellingprice.Size = new System.Drawing.Size(224, 35);
            this.lblsellingprice.TabIndex = 50;
            this.lblsellingprice.Text = "SINGLE SELLING PRICE";
            // 
            // txtsellprice
            // 
            this.txtsellprice.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtsellprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsellprice.ForeColor = System.Drawing.SystemColors.Info;
            this.txtsellprice.Location = new System.Drawing.Point(554, 546);
            this.txtsellprice.Name = "txtsellprice";
            this.txtsellprice.Size = new System.Drawing.Size(202, 31);
            this.txtsellprice.TabIndex = 12;
            this.txtsellprice.TextChanged += new System.EventHandler(this.txtsellprice_TextChanged);
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // clothesTableAdapter
            // 
            this.clothesTableAdapter.ClearBeforeFill = true;
            // 
            // txtsinglprice
            // 
            this.txtsinglprice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtsinglprice.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.clothesBindingSource, "singleprice", true));
            this.txtsinglprice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clothesBindingSource, "singleprice", true));
            this.txtsinglprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsinglprice.Location = new System.Drawing.Point(554, 425);
            this.txtsinglprice.Name = "txtsinglprice";
            this.txtsinglprice.Size = new System.Drawing.Size(202, 31);
            this.txtsinglprice.TabIndex = 9;
            // 
            // txtavialable
            // 
            this.txtavialable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtavialable.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtavialable.Location = new System.Drawing.Point(28, 423);
            this.txtavialable.Name = "txtavialable";
            this.txtavialable.Size = new System.Drawing.Size(202, 33);
            this.txtavialable.TabIndex = 7;
            // 
            // txtqnt
            // 
            this.txtqnt.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtqnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqnt.ForeColor = System.Drawing.SystemColors.Info;
            this.txtqnt.Location = new System.Drawing.Point(281, 546);
            this.txtqnt.Name = "txtqnt";
            this.txtqnt.Size = new System.Drawing.Size(202, 31);
            this.txtqnt.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 35);
            this.label1.TabIndex = 55;
            this.label1.Text = "SELLING DATE";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(244, 293);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker1.Size = new System.Drawing.Size(512, 31);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // txtclthdesc
            // 
            this.txtclthdesc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtclthdesc.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.clothesBindingSource, "clothdesc", true));
            this.txtclthdesc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clothesBindingSource, "clothdesc", true));
            this.txtclthdesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtclthdesc.Location = new System.Drawing.Point(244, 245);
            this.txtclthdesc.Name = "txtclthdesc";
            this.txtclthdesc.Size = new System.Drawing.Size(512, 33);
            this.txtclthdesc.TabIndex = 5;
            // 
            // txtinvisible
            // 
            this.txtinvisible.BackColor = System.Drawing.Color.Gray;
            this.txtinvisible.Location = new System.Drawing.Point(13, 13);
            this.txtinvisible.Name = "txtinvisible";
            this.txtinvisible.Size = new System.Drawing.Size(100, 20);
            this.txtinvisible.TabIndex = 58;
            this.txtinvisible.Visible = false;
            // 
            // btneditinvoice
            // 
            this.btneditinvoice.BackColor = System.Drawing.Color.DimGray;
            this.btneditinvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditinvoice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btneditinvoice.Location = new System.Drawing.Point(119, 629);
            this.btneditinvoice.Name = "btneditinvoice";
            this.btneditinvoice.Size = new System.Drawing.Size(230, 42);
            this.btneditinvoice.TabIndex = 59;
            this.btneditinvoice.Text = "EDIT INVOICE";
            this.btneditinvoice.UseVisualStyleBackColor = false;
            this.btneditinvoice.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.DimGray;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnexit.Location = new System.Drawing.Point(411, 629);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(230, 42);
            this.btnexit.TabIndex = 60;
            this.btnexit.Text = "EXIT";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Fuchsia;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(780, 23);
            this.label2.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Fuchsia;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Location = new System.Drawing.Point(770, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 718);
            this.label3.TabIndex = 62;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Fuchsia;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Location = new System.Drawing.Point(0, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 718);
            this.label4.TabIndex = 63;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Fuchsia;
            this.label5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label5.Location = new System.Drawing.Point(10, 726);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(760, 15);
            this.label5.TabIndex = 64;
            // 
            // F6sellclothes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::BMSusingCsharp.Properties.Resources._148;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(780, 741);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btneditinvoice);
            this.Controls.Add(this.txtinvisible);
            this.Controls.Add(this.txtclthdesc);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtqnt);
            this.Controls.Add(this.txtavialable);
            this.Controls.Add(this.txtsinglprice);
            this.Controls.Add(this.txtsellprice);
            this.Controls.Add(this.lblsellingprice);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnnewinvoice);
            this.Controls.Add(this.btnprint);
            this.Controls.Add(this.cmbclthtype);
            this.Controls.Add(this.lblqnt);
            this.Controls.Add(this.cmbcustname);
            this.Controls.Add(this.cmbcustid);
            this.Controls.Add(this.lblselectcust);
            this.Controls.Add(this.txtinvoiceno);
            this.Controls.Add(this.lblinvoiceno);
            this.Controls.Add(this.cmbclthname);
            this.Controls.Add(this.cmbclthid);
            this.Controls.Add(this.lblclthtype);
            this.Controls.Add(this.lblsinglprice);
            this.Controls.Add(this.lblavailable);
            this.Controls.Add(this.lbldesc);
            this.Controls.Add(this.lblselectclth);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F6sellclothes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F6sellclothes";
            this.Load += new System.EventHandler(this.F6sellclothes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clthsell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clothesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clthsell2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lbltitle;
        internal System.Windows.Forms.Button btnsave;
        internal System.Windows.Forms.Button btnnewinvoice;
        internal System.Windows.Forms.Button btnprint;
        internal System.Windows.Forms.ComboBox cmbclthtype;
        internal System.Windows.Forms.Label lblqnt;
        internal System.Windows.Forms.ComboBox cmbcustname;
        internal System.Windows.Forms.ComboBox cmbcustid;
        internal System.Windows.Forms.Label lblselectcust;
        internal System.Windows.Forms.TextBox txtinvoiceno;
        internal System.Windows.Forms.Label lblinvoiceno;
        internal System.Windows.Forms.ComboBox cmbclthname;
        internal System.Windows.Forms.ComboBox cmbclthid;
        internal System.Windows.Forms.Label lblclthtype;
        internal System.Windows.Forms.Label lblsinglprice;
        internal System.Windows.Forms.Label lblavailable;
        internal System.Windows.Forms.Label lbldesc;
        internal System.Windows.Forms.Label lblselectclth;
        internal System.Windows.Forms.Label lblsellingprice;
        internal System.Windows.Forms.TextBox txtsellprice;
        private clthsell clthsell;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private clthsellTableAdapters.customerTableAdapter customerTableAdapter;
        private clthsell2 clthsell2;
        private System.Windows.Forms.BindingSource clothesBindingSource;
        private clthsell2TableAdapters.clothesTableAdapter clothesTableAdapter;
        private System.Windows.Forms.Label txtsinglprice;
        private System.Windows.Forms.Label txtavialable;
        internal System.Windows.Forms.TextBox txtqnt;
        internal System.Windows.Forms.Label label1;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label txtclthdesc;
        public System.Windows.Forms.TextBox txtinvisible;
        internal System.Windows.Forms.Button btneditinvoice;
        internal System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}