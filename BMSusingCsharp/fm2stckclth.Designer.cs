namespace BMSusingCsharp
{
    partial class fm2stckclth
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
            this.clothesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BMSCsharpDataSet7 = new BMSusingCsharp.BMSCsharpDataSet7();
            this.Label13 = new System.Windows.Forms.Label();
            this.TextBox8 = new System.Windows.Forms.TextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.TextBox7 = new System.Windows.Forms.TextBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.TextBox3 = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.clothesTableAdapter = new BMSusingCsharp.BMSCsharpDataSet7TableAdapters.clothesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.clothesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BMSCsharpDataSet7)).BeginInit();
            this.SuspendLayout();
            // 
            // clothesBindingSource
            // 
            this.clothesBindingSource.DataMember = "clothes";
            this.clothesBindingSource.DataSource = this.BMSCsharpDataSet7;
            // 
            // BMSCsharpDataSet7
            // 
            this.BMSCsharpDataSet7.DataSetName = "BMSCsharpDataSet7";
            this.BMSCsharpDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label13.Location = new System.Drawing.Point(809, 173);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(159, 27);
            this.Label13.TabIndex = 76;
            this.Label13.Text = "SINGLE PRICE";
            // 
            // TextBox8
            // 
            this.TextBox8.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.TextBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox8.Location = new System.Drawing.Point(629, 692);
            this.TextBox8.Name = "TextBox8";
            this.TextBox8.Size = new System.Drawing.Size(255, 31);
            this.TextBox8.TabIndex = 75;
            this.TextBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label11
            // 
            this.Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.Location = new System.Drawing.Point(668, 656);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(191, 33);
            this.Label11.TabIndex = 74;
            this.Label11.Text = "CHECKED BY";
            this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBox7
            // 
            this.TextBox7.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.TextBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox7.Location = new System.Drawing.Point(103, 692);
            this.TextBox7.Name = "TextBox7";
            this.TextBox7.Size = new System.Drawing.Size(255, 31);
            this.TextBox7.TabIndex = 73;
            this.TextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label12
            // 
            this.Label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.Location = new System.Drawing.Point(134, 656);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(191, 33);
            this.Label12.TabIndex = 72;
            this.Label12.Text = "PREPARED BY";
            this.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBox3
            // 
            this.TextBox3.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.TextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox3.ForeColor = System.Drawing.SystemColors.Info;
            this.TextBox3.Location = new System.Drawing.Point(673, 583);
            this.TextBox3.Name = "TextBox3";
            this.TextBox3.Size = new System.Drawing.Size(295, 31);
            this.TextBox3.TabIndex = 71;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(8, 589);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(277, 25);
            this.Label9.TabIndex = 70;
            this.Label9.Text = "TOTAL STOCK AVAILABLE";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(129, 173);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(525, 27);
            this.Label7.TabIndex = 68;
            this.Label7.Text = "NAME                                                                           ";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(673, 173);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(120, 27);
            this.Label6.TabIndex = 67;
            this.Label6.Text = "QUANTITY";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(12, 173);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(111, 27);
            this.Label5.TabIndex = 66;
            this.Label5.Text = "CLOTH ID";
            // 
            // TextBox1
            // 
            this.TextBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox1.Enabled = false;
            this.TextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.TextBox1.Location = new System.Drawing.Point(219, 119);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(235, 19);
            this.TextBox1.TabIndex = 65;
            this.TextBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // Label3
            // 
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(10, 123);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(194, 23);
            this.Label3.TabIndex = 64;
            this.Label3.Text = "DATE AND TIME PRINTED";
            // 
            // Label2
            // 
            this.Label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(0, 47);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(994, 29);
            this.Label2.TabIndex = 63;
            this.Label2.Text = "STOCK CLOTHES";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Label1
            // 
            this.Label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(0, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(994, 47);
            this.Label1.TabIndex = 62;
            this.Label1.Text = "BOUTIQUE MANAGEMENT SYSTEM";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.Black;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.clothesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "BMSusingCsharp.Report5.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(6, 203);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.ShowToolBar = false;
            this.reportViewer1.Size = new System.Drawing.Size(962, 422);
            this.reportViewer1.TabIndex = 77;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // clothesTableAdapter
            // 
            this.clothesTableAdapter.ClearBeforeFill = true;
            // 
            // fm2stckclth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::BMSusingCsharp.Properties.Resources.Untitled157;
            this.ClientSize = new System.Drawing.Size(994, 731);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.Label13);
            this.Controls.Add(this.TextBox8);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.TextBox7);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.TextBox3);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "fm2stckclth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fm2stckclth";
            this.Load += new System.EventHandler(this.fm2stckclth_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clothesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BMSCsharpDataSet7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.TextBox TextBox8;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.TextBox TextBox7;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.TextBox TextBox3;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource clothesBindingSource;
        private BMSCsharpDataSet7 BMSCsharpDataSet7;
        private BMSCsharpDataSet7TableAdapters.clothesTableAdapter clothesTableAdapter;
    }
}