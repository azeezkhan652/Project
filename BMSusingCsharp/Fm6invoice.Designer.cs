namespace BMSusingCsharp
{
    partial class Fm6invoice
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.sellclothesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BMSCsharpDataSet7 = new BMSusingCsharp.BMSCsharpDataSet7();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtcustomer = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtinvoicedate = new System.Windows.Forms.TextBox();
            this.txtinvoicenno = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label17 = new System.Windows.Forms.Label();
            this.Label16 = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.Label14 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.txtitemspurchased = new System.Windows.Forms.TextBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.txttotalprice = new System.Windows.Forms.TextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.TextBox8 = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.TextBox7 = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sellclothesTableAdapter = new BMSusingCsharp.BMSCsharpDataSet7TableAdapters.sellclothesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sellclothesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BMSCsharpDataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // sellclothesBindingSource
            // 
            this.sellclothesBindingSource.DataMember = "sellclothes";
            this.sellclothesBindingSource.DataSource = this.BMSCsharpDataSet7;
            // 
            // BMSCsharpDataSet7
            // 
            this.BMSCsharpDataSet7.DataSetName = "BMSCsharpDataSet7";
            this.BMSCsharpDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(191, 211);
            this.dateTimePicker1.MaxDate = new System.DateTime(2017, 10, 20, 12, 4, 59, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2017, 10, 20, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(222, 26);
            this.dateTimePicker1.TabIndex = 84;
            this.dateTimePicker1.Value = new System.DateTime(2017, 10, 20, 0, 0, 0, 0);
            // 
            // txtphone
            // 
            this.txtphone.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.sellclothesBindingSource, "phone", true));
            this.txtphone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sellclothesBindingSource, "phone", true));
            this.txtphone.Enabled = false;
            this.txtphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphone.Location = new System.Drawing.Point(637, 164);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(222, 26);
            this.txtphone.TabIndex = 68;
            // 
            // txtcustomer
            // 
            this.txtcustomer.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.sellclothesBindingSource, "custname", true));
            this.txtcustomer.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sellclothesBindingSource, "clthname", true));
            this.txtcustomer.Enabled = false;
            this.txtcustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcustomer.Location = new System.Drawing.Point(637, 120);
            this.txtcustomer.Name = "txtcustomer";
            this.txtcustomer.Size = new System.Drawing.Size(222, 26);
            this.txtcustomer.TabIndex = 67;
            // 
            // Label8
            // 
            this.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(471, 166);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(160, 28);
            this.Label8.TabIndex = 66;
            this.Label8.Text = "ADDRESS";
            this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label7
            // 
            this.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(471, 209);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(160, 28);
            this.Label7.TabIndex = 65;
            this.Label7.Text = "PHONE";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label6
            // 
            this.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(471, 122);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(160, 28);
            this.Label6.TabIndex = 64;
            this.Label6.Text = "CUSTOMER";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtinvoicedate
            // 
            this.txtinvoicedate.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.sellclothesBindingSource, "selldate", true));
            this.txtinvoicedate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sellclothesBindingSource, "selldate", true));
            this.txtinvoicedate.Enabled = false;
            this.txtinvoicedate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtinvoicedate.Location = new System.Drawing.Point(191, 166);
            this.txtinvoicedate.Name = "txtinvoicedate";
            this.txtinvoicedate.Size = new System.Drawing.Size(222, 26);
            this.txtinvoicedate.TabIndex = 63;
            // 
            // txtinvoicenno
            // 
            this.txtinvoicenno.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.sellclothesBindingSource, "invoiceno", true));
            this.txtinvoicenno.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sellclothesBindingSource, "invoiceno", true));
            this.txtinvoicenno.Enabled = false;
            this.txtinvoicenno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtinvoicenno.Location = new System.Drawing.Point(191, 122);
            this.txtinvoicenno.Name = "txtinvoicenno";
            this.txtinvoicenno.Size = new System.Drawing.Size(222, 26);
            this.txtinvoicenno.TabIndex = 62;
            // 
            // Label5
            // 
            this.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(25, 210);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(159, 28);
            this.Label5.TabIndex = 61;
            this.Label5.Text = "PRINT DATE";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label4
            // 
            this.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(25, 166);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(160, 28);
            this.Label4.TabIndex = 60;
            this.Label4.Text = "INVOICE DATE";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label3
            // 
            this.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(25, 122);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(160, 28);
            this.Label3.TabIndex = 59;
            this.Label3.Text = "INVOICE NUMBER";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label2
            // 
            this.Label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(0, 44);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(884, 34);
            this.Label2.TabIndex = 58;
            this.Label2.Text = "SELLING INVOICE";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label1
            // 
            this.Label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(0, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(884, 44);
            this.Label1.TabIndex = 57;
            this.Label1.Text = "BOUTIQUE MANAGEMENT SYSTEM";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label17
            // 
            this.Label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label17.Location = new System.Drawing.Point(767, 266);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(92, 23);
            this.Label17.TabIndex = 82;
            this.Label17.Text = "TOTAL";
            // 
            // Label16
            // 
            this.Label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label16.Location = new System.Drawing.Point(599, 266);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(162, 23);
            this.Label16.TabIndex = 81;
            this.Label16.Text = "SINGLE PRICE";
            // 
            // Label15
            // 
            this.Label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label15.Location = new System.Drawing.Point(474, 266);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(119, 23);
            this.Label15.TabIndex = 80;
            this.Label15.Text = "QUANTITY";
            // 
            // Label14
            // 
            this.Label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label14.Location = new System.Drawing.Point(153, 266);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(195, 23);
            this.Label14.TabIndex = 79;
            this.Label14.Text = "CLOTHES NAME";
            // 
            // Label13
            // 
            this.Label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label13.Location = new System.Drawing.Point(27, 266);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(104, 23);
            this.Label13.TabIndex = 78;
            this.Label13.Text = "NUMBER";
            // 
            // txtitemspurchased
            // 
            this.txtitemspurchased.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtitemspurchased.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtitemspurchased.Location = new System.Drawing.Point(604, 516);
            this.txtitemspurchased.Name = "txtitemspurchased";
            this.txtitemspurchased.Size = new System.Drawing.Size(255, 31);
            this.txtitemspurchased.TabIndex = 77;
            this.txtitemspurchased.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label12
            // 
            this.Label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.Location = new System.Drawing.Point(20, 524);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(296, 23);
            this.Label12.TabIndex = 76;
            this.Label12.Text = "TOTAL ITEMS PURCHASED";
            // 
            // txttotalprice
            // 
            this.txttotalprice.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txttotalprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalprice.Location = new System.Drawing.Point(604, 560);
            this.txttotalprice.Name = "txttotalprice";
            this.txttotalprice.Size = new System.Drawing.Size(255, 31);
            this.txttotalprice.TabIndex = 75;
            this.txttotalprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label11
            // 
            this.Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.Location = new System.Drawing.Point(20, 568);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(157, 23);
            this.Label11.TabIndex = 74;
            this.Label11.Text = "TOTAL PRICE";
            // 
            // TextBox8
            // 
            this.TextBox8.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.TextBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox8.Location = new System.Drawing.Point(536, 676);
            this.TextBox8.Name = "TextBox8";
            this.TextBox8.Size = new System.Drawing.Size(255, 31);
            this.TextBox8.TabIndex = 73;
            this.TextBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label10
            // 
            this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(564, 630);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(191, 33);
            this.Label10.TabIndex = 72;
            this.Label10.Text = "CHECKED BY";
            this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBox7
            // 
            this.TextBox7.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.TextBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox7.Location = new System.Drawing.Point(93, 676);
            this.TextBox7.Name = "TextBox7";
            this.TextBox7.Size = new System.Drawing.Size(255, 31);
            this.TextBox7.TabIndex = 71;
            this.TextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label9
            // 
            this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(125, 630);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(191, 33);
            this.Label9.TabIndex = 70;
            this.Label9.Text = "PREPARED BY";
            this.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtaddress
            // 
            this.txtaddress.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.sellclothesBindingSource, "address", true));
            this.txtaddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sellclothesBindingSource, "address", true));
            this.txtaddress.Enabled = false;
            this.txtaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddress.Location = new System.Drawing.Point(637, 211);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(222, 26);
            this.txtaddress.TabIndex = 69;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.Black;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.sellclothesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BMSusingCsharp.Report4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(6, 292);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.ShowToolBar = false;
            this.reportViewer1.Size = new System.Drawing.Size(866, 299);
            this.reportViewer1.TabIndex = 85;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // sellclothesTableAdapter
            // 
            this.sellclothesTableAdapter.ClearBeforeFill = true;
            // 
            // Fm6invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::BMSusingCsharp.Properties.Resources.Untitled156;
            this.ClientSize = new System.Drawing.Size(884, 721);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.txtcustomer);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.txtinvoicedate);
            this.Controls.Add(this.txtinvoicenno);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Label17);
            this.Controls.Add(this.Label16);
            this.Controls.Add(this.Label15);
            this.Controls.Add(this.Label14);
            this.Controls.Add(this.Label13);
            this.Controls.Add(this.txtitemspurchased);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.txttotalprice);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.TextBox8);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.TextBox7);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.txtaddress);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Fm6invoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fm6invoice";
            this.Load += new System.EventHandler(this.Fm6invoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sellclothesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BMSCsharpDataSet7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        internal System.Windows.Forms.TextBox txtphone;
        internal System.Windows.Forms.TextBox txtcustomer;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox txtinvoicedate;
        internal System.Windows.Forms.TextBox txtinvoicenno;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label17;
        internal System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.TextBox txtitemspurchased;
        internal System.Windows.Forms.Label Label12;
        public System.Windows.Forms.TextBox txttotalprice;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.TextBox TextBox8;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.TextBox TextBox7;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.TextBox txtaddress;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sellclothesBindingSource;
        private BMSCsharpDataSet7 BMSCsharpDataSet7;
        private BMSCsharpDataSet7TableAdapters.sellclothesTableAdapter sellclothesTableAdapter;
    }
}