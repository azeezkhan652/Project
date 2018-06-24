namespace BMSusingCsharp
{
    partial class Fm9editinvoice
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
            this.txtclthdesc = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtqnt = new System.Windows.Forms.TextBox();
            this.txtavialable = new System.Windows.Forms.Label();
            this.txtsinglprice = new System.Windows.Forms.Label();
            this.customerTableAdapter = new BMSusingCsharp.clthsellTableAdapters.customerTableAdapter();
            this.txtinvisible = new System.Windows.Forms.TextBox();
            this.txtsellprice = new System.Windows.Forms.TextBox();
            this.lblsellingprice = new System.Windows.Forms.Label();
            this.lbltitle = new System.Windows.Forms.Label();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.cmbclthtype = new System.Windows.Forms.ComboBox();
            this.lblqnt = new System.Windows.Forms.Label();
            this.cmbcustname = new System.Windows.Forms.ComboBox();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbclthid = new System.Windows.Forms.ComboBox();
            this.sellclothesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bMSCsharpDataSet9 = new BMSusingCsharp.BMSCsharpDataSet9();
            this.cmbclthname = new System.Windows.Forms.ComboBox();
            this.cmbcustid = new System.Windows.Forms.ComboBox();
            this.lblselectcust = new System.Windows.Forms.Label();
            this.lblinvoiceno = new System.Windows.Forms.Label();
            this.lblclthtype = new System.Windows.Forms.Label();
            this.lblsinglprice = new System.Windows.Forms.Label();
            this.lblavailable = new System.Windows.Forms.Label();
            this.lbldesc = new System.Windows.Forms.Label();
            this.lblselectclth = new System.Windows.Forms.Label();
            this.sellclothesTableAdapter = new BMSusingCsharp.BMSCsharpDataSet9TableAdapters.sellclothesTableAdapter();
            this.bMSCsharpDataSet10 = new BMSusingCsharp.BMSCsharpDataSet10();
            this.sellclothesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sellclothesTableAdapter1 = new BMSusingCsharp.BMSCsharpDataSet10TableAdapters.sellclothesTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellclothesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bMSCsharpDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bMSCsharpDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellclothesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtclthdesc
            // 
            this.txtclthdesc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtclthdesc.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.sellclothesBindingSource, "clthdesc", true));
            this.txtclthdesc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sellclothesBindingSource, "clthdesc", true));
            this.txtclthdesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtclthdesc.Location = new System.Drawing.Point(254, 290);
            this.txtclthdesc.Name = "txtclthdesc";
            this.txtclthdesc.Size = new System.Drawing.Size(512, 33);
            this.txtclthdesc.TabIndex = 64;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sellclothesBindingSource, "selldate", true));
            this.dateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.sellclothesBindingSource, "selldate", true));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(254, 338);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker1.Size = new System.Drawing.Size(512, 31);
            this.dateTimePicker1.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 35);
            this.label1.TabIndex = 85;
            this.label1.Text = "SELLING DATE";
            // 
            // txtqnt
            // 
            this.txtqnt.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtqnt.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.sellclothesBindingSource, "qntpurchased", true));
            this.txtqnt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sellclothesBindingSource, "qntpurchased", true));
            this.txtqnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqnt.ForeColor = System.Drawing.SystemColors.Info;
            this.txtqnt.Location = new System.Drawing.Point(291, 591);
            this.txtqnt.Name = "txtqnt";
            this.txtqnt.Size = new System.Drawing.Size(202, 31);
            this.txtqnt.TabIndex = 70;
            // 
            // txtavialable
            // 
            this.txtavialable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtavialable.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.sellclothesBindingSource, "available", true));
            this.txtavialable.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sellclothesBindingSource, "available", true));
            this.txtavialable.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtavialable.Location = new System.Drawing.Point(38, 468);
            this.txtavialable.Name = "txtavialable";
            this.txtavialable.Size = new System.Drawing.Size(202, 33);
            this.txtavialable.TabIndex = 66;
            // 
            // txtsinglprice
            // 
            this.txtsinglprice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtsinglprice.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.sellclothesBindingSource, "singlprice", true));
            this.txtsinglprice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sellclothesBindingSource, "singlprice", true));
            this.txtsinglprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsinglprice.Location = new System.Drawing.Point(564, 470);
            this.txtsinglprice.Name = "txtsinglprice";
            this.txtsinglprice.Size = new System.Drawing.Size(202, 31);
            this.txtsinglprice.TabIndex = 68;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // txtinvisible
            // 
            this.txtinvisible.BackColor = System.Drawing.Color.Gray;
            this.txtinvisible.Location = new System.Drawing.Point(21, 17);
            this.txtinvisible.Name = "txtinvisible";
            this.txtinvisible.Size = new System.Drawing.Size(100, 20);
            this.txtinvisible.TabIndex = 86;
            this.txtinvisible.Visible = false;
            // 
            // txtsellprice
            // 
            this.txtsellprice.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtsellprice.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.sellclothesBindingSource, "sellprice", true));
            this.txtsellprice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sellclothesBindingSource, "sellprice", true));
            this.txtsellprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsellprice.ForeColor = System.Drawing.SystemColors.Info;
            this.txtsellprice.Location = new System.Drawing.Point(564, 591);
            this.txtsellprice.Name = "txtsellprice";
            this.txtsellprice.Size = new System.Drawing.Size(202, 31);
            this.txtsellprice.TabIndex = 71;
            // 
            // lblsellingprice
            // 
            this.lblsellingprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsellingprice.Location = new System.Drawing.Point(542, 541);
            this.lblsellingprice.Name = "lblsellingprice";
            this.lblsellingprice.Size = new System.Drawing.Size(224, 35);
            this.lblsellingprice.TabIndex = 84;
            this.lblsellingprice.Text = "SINGLE SELLING PRICE";
            // 
            // lbltitle
            // 
            this.lbltitle.BackColor = System.Drawing.Color.Black;
            this.lbltitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbltitle.Location = new System.Drawing.Point(270, 59);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(288, 46);
            this.lbltitle.TabIndex = 83;
            this.lbltitle.Text = "CLOTHES SELLING";
            this.lbltitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Black;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btndelete.Location = new System.Drawing.Point(546, 681);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(230, 42);
            this.btndelete.TabIndex = 74;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Black;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnexit.Location = new System.Drawing.Point(286, 681);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(230, 42);
            this.btnexit.TabIndex = 73;
            this.btnexit.Text = "EXIT";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Black;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnupdate.Location = new System.Drawing.Point(20, 681);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(230, 42);
            this.btnupdate.TabIndex = 72;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.UseVisualStyleBackColor = false;
            // 
            // cmbclthtype
            // 
            this.cmbclthtype.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cmbclthtype.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.sellclothesBindingSource, "clthtype", true));
            this.cmbclthtype.DataSource = this.sellclothesBindingSource;
            this.cmbclthtype.DisplayMember = "clthtype";
            this.cmbclthtype.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbclthtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbclthtype.ForeColor = System.Drawing.SystemColors.Info;
            this.cmbclthtype.FormattingEnabled = true;
            this.cmbclthtype.Location = new System.Drawing.Point(291, 468);
            this.cmbclthtype.Name = "cmbclthtype";
            this.cmbclthtype.Size = new System.Drawing.Size(202, 33);
            this.cmbclthtype.TabIndex = 67;
            // 
            // lblqnt
            // 
            this.lblqnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblqnt.Location = new System.Drawing.Point(278, 541);
            this.lblqnt.Name = "lblqnt";
            this.lblqnt.Size = new System.Drawing.Size(258, 35);
            this.lblqnt.TabIndex = 82;
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
            this.cmbcustname.Location = new System.Drawing.Point(453, 192);
            this.cmbcustname.Name = "cmbcustname";
            this.cmbcustname.Size = new System.Drawing.Size(313, 33);
            this.cmbcustname.TabIndex = 61;
            this.cmbcustname.ValueMember = "custname";
            // 
            // cmbclthid
            // 
            this.cmbclthid.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cmbclthid.DataSource = this.sellclothesBindingSource;
            this.cmbclthid.DisplayMember = "clthid";
            this.cmbclthid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbclthid.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbclthid.ForeColor = System.Drawing.SystemColors.Info;
            this.cmbclthid.FormattingEnabled = true;
            this.cmbclthid.Location = new System.Drawing.Point(254, 243);
            this.cmbclthid.Name = "cmbclthid";
            this.cmbclthid.Size = new System.Drawing.Size(193, 33);
            this.cmbclthid.TabIndex = 62;
            this.cmbclthid.ValueMember = "clthid";
            // 
            // sellclothesBindingSource
            // 
            this.sellclothesBindingSource.DataMember = "sellclothes";
            this.sellclothesBindingSource.DataSource = this.bMSCsharpDataSet9;
            // 
            // bMSCsharpDataSet9
            // 
            this.bMSCsharpDataSet9.DataSetName = "BMSCsharpDataSet9";
            this.bMSCsharpDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbclthname
            // 
            this.cmbclthname.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cmbclthname.DataSource = this.sellclothesBindingSource;
            this.cmbclthname.DisplayMember = "clthname";
            this.cmbclthname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbclthname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbclthname.ForeColor = System.Drawing.SystemColors.Info;
            this.cmbclthname.FormattingEnabled = true;
            this.cmbclthname.Location = new System.Drawing.Point(453, 243);
            this.cmbclthname.Name = "cmbclthname";
            this.cmbclthname.Size = new System.Drawing.Size(313, 33);
            this.cmbclthname.TabIndex = 63;
            this.cmbclthname.ValueMember = "clthname";
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
            this.cmbcustid.Location = new System.Drawing.Point(254, 192);
            this.cmbcustid.Name = "cmbcustid";
            this.cmbcustid.Size = new System.Drawing.Size(193, 33);
            this.cmbcustid.TabIndex = 60;
            this.cmbcustid.ValueMember = "custcode";
            // 
            // lblselectcust
            // 
            this.lblselectcust.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblselectcust.Location = new System.Drawing.Point(5, 192);
            this.lblselectcust.Name = "lblselectcust";
            this.lblselectcust.Size = new System.Drawing.Size(258, 35);
            this.lblselectcust.TabIndex = 81;
            this.lblselectcust.Text = "SELECT CUSTOMER";
            // 
            // lblinvoiceno
            // 
            this.lblinvoiceno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinvoiceno.Location = new System.Drawing.Point(48, 541);
            this.lblinvoiceno.Name = "lblinvoiceno";
            this.lblinvoiceno.Size = new System.Drawing.Size(202, 35);
            this.lblinvoiceno.TabIndex = 80;
            this.lblinvoiceno.Text = "INVOICE NUMBER";
            // 
            // lblclthtype
            // 
            this.lblclthtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblclthtype.Location = new System.Drawing.Point(321, 416);
            this.lblclthtype.Name = "lblclthtype";
            this.lblclthtype.Size = new System.Drawing.Size(151, 35);
            this.lblclthtype.TabIndex = 79;
            this.lblclthtype.Text = "CLOTH TYPE";
            // 
            // lblsinglprice
            // 
            this.lblsinglprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsinglprice.Location = new System.Drawing.Point(564, 416);
            this.lblsinglprice.Name = "lblsinglprice";
            this.lblsinglprice.Size = new System.Drawing.Size(202, 35);
            this.lblsinglprice.TabIndex = 78;
            this.lblsinglprice.Text = "SINGLE PRICE";
            this.lblsinglprice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblavailable
            // 
            this.lblavailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblavailable.Location = new System.Drawing.Point(39, 416);
            this.lblavailable.Name = "lblavailable";
            this.lblavailable.Size = new System.Drawing.Size(215, 35);
            this.lblavailable.TabIndex = 77;
            this.lblavailable.Text = "AVAILABLE QUANTITY";
            // 
            // lbldesc
            // 
            this.lbldesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldesc.Location = new System.Drawing.Point(38, 288);
            this.lbldesc.Name = "lbldesc";
            this.lbldesc.Size = new System.Drawing.Size(202, 35);
            this.lbldesc.TabIndex = 76;
            this.lbldesc.Text = "DESCRIPTION";
            // 
            // lblselectclth
            // 
            this.lblselectclth.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblselectclth.Location = new System.Drawing.Point(38, 241);
            this.lblselectclth.Name = "lblselectclth";
            this.lblselectclth.Size = new System.Drawing.Size(202, 35);
            this.lblselectclth.TabIndex = 75;
            this.lblselectclth.Text = "SELECT CLOTH";
            // 
            // sellclothesTableAdapter
            // 
            this.sellclothesTableAdapter.ClearBeforeFill = true;
            // 
            // bMSCsharpDataSet10
            // 
            this.bMSCsharpDataSet10.DataSetName = "BMSCsharpDataSet10";
            this.bMSCsharpDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sellclothesBindingSource1
            // 
            this.sellclothesBindingSource1.DataMember = "sellclothes";
            this.sellclothesBindingSource1.DataSource = this.bMSCsharpDataSet10;
            // 
            // sellclothesTableAdapter1
            // 
            this.sellclothesTableAdapter1.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(38, 591);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(202, 29);
            this.textBox1.TabIndex = 87;
            // 
            // Fm9editinvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(780, 741);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtclthdesc);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtqnt);
            this.Controls.Add(this.txtavialable);
            this.Controls.Add(this.txtsinglprice);
            this.Controls.Add(this.txtinvisible);
            this.Controls.Add(this.txtsellprice);
            this.Controls.Add(this.lblsellingprice);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.cmbclthtype);
            this.Controls.Add(this.lblqnt);
            this.Controls.Add(this.cmbcustname);
            this.Controls.Add(this.cmbclthid);
            this.Controls.Add(this.cmbclthname);
            this.Controls.Add(this.cmbcustid);
            this.Controls.Add(this.lblselectcust);
            this.Controls.Add(this.lblinvoiceno);
            this.Controls.Add(this.lblclthtype);
            this.Controls.Add(this.lblsinglprice);
            this.Controls.Add(this.lblavailable);
            this.Controls.Add(this.lbldesc);
            this.Controls.Add(this.lblselectclth);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Fm9editinvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fm9editinvoice";
            this.Load += new System.EventHandler(this.Fm9editinvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellclothesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bMSCsharpDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bMSCsharpDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellclothesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txtclthdesc;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox txtqnt;
        private System.Windows.Forms.Label txtavialable;
        private System.Windows.Forms.Label txtsinglprice;
        private clthsellTableAdapters.customerTableAdapter customerTableAdapter;
        public System.Windows.Forms.TextBox txtinvisible;
        internal System.Windows.Forms.TextBox txtsellprice;
        internal System.Windows.Forms.Label lblsellingprice;
        internal System.Windows.Forms.Label lbltitle;
        internal System.Windows.Forms.Button btndelete;
        internal System.Windows.Forms.Button btnexit;
        internal System.Windows.Forms.Button btnupdate;
        internal System.Windows.Forms.ComboBox cmbclthtype;
        internal System.Windows.Forms.Label lblqnt;
        internal System.Windows.Forms.ComboBox cmbcustname;
        private System.Windows.Forms.BindingSource customerBindingSource;
        internal System.Windows.Forms.ComboBox cmbclthid;
        internal System.Windows.Forms.ComboBox cmbclthname;
        internal System.Windows.Forms.ComboBox cmbcustid;
        internal System.Windows.Forms.Label lblselectcust;
        internal System.Windows.Forms.Label lblinvoiceno;
        internal System.Windows.Forms.Label lblclthtype;
        internal System.Windows.Forms.Label lblsinglprice;
        internal System.Windows.Forms.Label lblavailable;
        internal System.Windows.Forms.Label lbldesc;
        internal System.Windows.Forms.Label lblselectclth;
        private BMSCsharpDataSet9 bMSCsharpDataSet9;
        private System.Windows.Forms.BindingSource sellclothesBindingSource;
        private BMSCsharpDataSet9TableAdapters.sellclothesTableAdapter sellclothesTableAdapter;
        private BMSCsharpDataSet10 bMSCsharpDataSet10;
        private System.Windows.Forms.BindingSource sellclothesBindingSource1;
        private BMSCsharpDataSet10TableAdapters.sellclothesTableAdapter sellclothesTableAdapter1;
        private System.Windows.Forms.TextBox textBox1;
    }
}