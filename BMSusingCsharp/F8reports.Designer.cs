namespace BMSusingCsharp
{
    partial class F8reports
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
            this.btnexit = new System.Windows.Forms.Button();
            this.btnallcust = new System.Windows.Forms.Button();
            this.btntotalsell = new System.Windows.Forms.Button();
            this.btnstkalert = new System.Windows.Forms.Button();
            this.btnstkcloth = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            this.Label6 = new System.Windows.Forms.Label();
            this.btnsellstt = new System.Windows.Forms.Button();
            this.dtpto2 = new System.Windows.Forms.DateTimePicker();
            this.Label5 = new System.Windows.Forms.Label();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.sellclothesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bMSCsharpDataSet4 = new BMSusingCsharp.BMSCsharpDataSet4();
            this.dtpfrom2 = new System.Windows.Forms.DateTimePicker();
            this.btntotalprint = new System.Windows.Forms.Button();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.btnprintstt = new System.Windows.Forms.Button();
            this.dtpto1 = new System.Windows.Forms.DateTimePicker();
            this.Label3 = new System.Windows.Forms.Label();
            this.dtpfrom1 = new System.Windows.Forms.DateTimePicker();
            this.Label2 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.sellclothesTableAdapter = new BMSusingCsharp.BMSCsharpDataSet4TableAdapters.sellclothesTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.GroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sellclothesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bMSCsharpDataSet4)).BeginInit();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnexit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(650, 607);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(270, 51);
            this.btnexit.TabIndex = 19;
            this.btnexit.Text = "EXIT";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnallcust
            // 
            this.btnallcust.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnallcust.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnallcust.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnallcust.Location = new System.Drawing.Point(343, 607);
            this.btnallcust.Name = "btnallcust";
            this.btnallcust.Size = new System.Drawing.Size(270, 51);
            this.btnallcust.TabIndex = 17;
            this.btnallcust.Text = "ALL CUSTOMERS";
            this.btnallcust.UseVisualStyleBackColor = false;
            this.btnallcust.Click += new System.EventHandler(this.btnallcust_Click);
            // 
            // btntotalsell
            // 
            this.btntotalsell.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btntotalsell.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntotalsell.Location = new System.Drawing.Point(343, 512);
            this.btntotalsell.Name = "btntotalsell";
            this.btntotalsell.Size = new System.Drawing.Size(270, 51);
            this.btntotalsell.TabIndex = 16;
            this.btntotalsell.Text = "TOTAL SELLING";
            this.btntotalsell.UseVisualStyleBackColor = false;
            this.btntotalsell.Click += new System.EventHandler(this.btntotalsell_Click);
            // 
            // btnstkalert
            // 
            this.btnstkalert.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnstkalert.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstkalert.Location = new System.Drawing.Point(30, 607);
            this.btnstkalert.Name = "btnstkalert";
            this.btnstkalert.Size = new System.Drawing.Size(270, 51);
            this.btnstkalert.TabIndex = 15;
            this.btnstkalert.Text = "STOCK ALERT";
            this.btnstkalert.UseVisualStyleBackColor = false;
            this.btnstkalert.Click += new System.EventHandler(this.btnstkalert_Click);
            // 
            // btnstkcloth
            // 
            this.btnstkcloth.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnstkcloth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstkcloth.Location = new System.Drawing.Point(30, 512);
            this.btnstkcloth.Name = "btnstkcloth";
            this.btnstkcloth.Size = new System.Drawing.Size(270, 51);
            this.btnstkcloth.TabIndex = 14;
            this.btnstkcloth.Text = "STOCK CLOTHES";
            this.btnstkcloth.UseVisualStyleBackColor = false;
            this.btnstkcloth.Click += new System.EventHandler(this.btnstkcloth_Click);
            // 
            // btnprint
            // 
            this.btnprint.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnprint.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprint.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnprint.Location = new System.Drawing.Point(11, 290);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(270, 41);
            this.btnprint.TabIndex = 6;
            this.btnprint.Text = "PRINT";
            this.btnprint.UseVisualStyleBackColor = false;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // Label6
            // 
            this.Label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(55, 96);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(171, 54);
            this.Label6.TabIndex = 6;
            this.Label6.Text = "TYPE INVOICE NUMBER";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnsellstt
            // 
            this.btnsellstt.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnsellstt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsellstt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsellstt.Location = new System.Drawing.Point(11, 290);
            this.btnsellstt.Name = "btnsellstt";
            this.btnsellstt.Size = new System.Drawing.Size(270, 41);
            this.btnsellstt.TabIndex = 4;
            this.btnsellstt.Text = "SELLING STATEMENT";
            this.btnsellstt.UseVisualStyleBackColor = false;
            this.btnsellstt.Click += new System.EventHandler(this.btnsellstt_Click);
            // 
            // dtpto2
            // 
            this.dtpto2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpto2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpto2.Location = new System.Drawing.Point(11, 203);
            this.dtpto2.Name = "dtpto2";
            this.dtpto2.Size = new System.Drawing.Size(270, 26);
            this.dtpto2.TabIndex = 4;
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(84, 164);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(142, 23);
            this.Label5.TabIndex = 4;
            this.Label5.Text = "DATE TO";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GroupBox3
            // 
            this.GroupBox3.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox3.Controls.Add(this.comboBox1);
            this.GroupBox3.Controls.Add(this.btnprint);
            this.GroupBox3.Controls.Add(this.Label6);
            this.GroupBox3.Location = new System.Drawing.Point(639, 94);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(287, 348);
            this.GroupBox3.TabIndex = 13;
            this.GroupBox3.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.sellclothesBindingSource;
            this.comboBox1.DisplayMember = "invoiceno";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(11, 203);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(270, 28);
            this.comboBox1.TabIndex = 5;
            // 
            // sellclothesBindingSource
            // 
            this.sellclothesBindingSource.DataMember = "sellclothes";
            this.sellclothesBindingSource.DataSource = this.bMSCsharpDataSet4;
            // 
            // bMSCsharpDataSet4
            // 
            this.bMSCsharpDataSet4.DataSetName = "BMSCsharpDataSet4";
            this.bMSCsharpDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtpfrom2
            // 
            this.dtpfrom2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfrom2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfrom2.Location = new System.Drawing.Point(11, 83);
            this.dtpfrom2.Name = "dtpfrom2";
            this.dtpfrom2.Size = new System.Drawing.Size(270, 26);
            this.dtpfrom2.TabIndex = 4;
            // 
            // btntotalprint
            // 
            this.btntotalprint.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btntotalprint.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntotalprint.Location = new System.Drawing.Point(650, 512);
            this.btntotalprint.Name = "btntotalprint";
            this.btntotalprint.Size = new System.Drawing.Size(270, 51);
            this.btntotalprint.TabIndex = 18;
            this.btntotalprint.Text = "TOTAL PROFIT";
            this.btntotalprint.UseVisualStyleBackColor = false;
            this.btntotalprint.Click += new System.EventHandler(this.btntotalprint_Click);
            // 
            // GroupBox2
            // 
            this.GroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox2.Controls.Add(this.btnsellstt);
            this.GroupBox2.Controls.Add(this.dtpto2);
            this.GroupBox2.Controls.Add(this.Label5);
            this.GroupBox2.Controls.Add(this.dtpfrom2);
            this.GroupBox2.Controls.Add(this.Label4);
            this.GroupBox2.Location = new System.Drawing.Point(332, 94);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(287, 348);
            this.GroupBox2.TabIndex = 12;
            this.GroupBox2.TabStop = false;
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(84, 40);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(142, 23);
            this.Label4.TabIndex = 4;
            this.Label4.Text = "DATE FROM";
            // 
            // btnprintstt
            // 
            this.btnprintstt.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnprintstt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprintstt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnprintstt.Location = new System.Drawing.Point(11, 290);
            this.btnprintstt.Name = "btnprintstt";
            this.btnprintstt.Size = new System.Drawing.Size(270, 41);
            this.btnprintstt.TabIndex = 5;
            this.btnprintstt.Text = "PROFIT STATEMENT";
            this.btnprintstt.UseVisualStyleBackColor = false;
            this.btnprintstt.Click += new System.EventHandler(this.btnprintstt_Click);
            // 
            // dtpto1
            // 
            this.dtpto1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpto1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpto1.Location = new System.Drawing.Point(11, 203);
            this.dtpto1.Name = "dtpto1";
            this.dtpto1.Size = new System.Drawing.Size(270, 26);
            this.dtpto1.TabIndex = 3;
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(76, 164);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(142, 23);
            this.Label3.TabIndex = 2;
            this.Label3.Text = "DATE TO";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpfrom1
            // 
            this.dtpfrom1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfrom1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfrom1.Location = new System.Drawing.Point(11, 83);
            this.dtpfrom1.Name = "dtpfrom1";
            this.dtpfrom1.Size = new System.Drawing.Size(270, 26);
            this.dtpfrom1.TabIndex = 1;
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(76, 40);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(142, 23);
            this.Label2.TabIndex = 0;
            this.Label2.Text = "DATE FROM";
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.GroupBox1.Controls.Add(this.btnprintstt);
            this.GroupBox1.Controls.Add(this.dtpto1);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.dtpfrom1);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Location = new System.Drawing.Point(19, 94);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(287, 348);
            this.GroupBox1.TabIndex = 11;
            this.GroupBox1.TabStop = false;
            // 
            // sellclothesTableAdapter
            // 
            this.sellclothesTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(944, 23);
            this.label1.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Right;
            this.label7.Location = new System.Drawing.Point(934, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 658);
            this.label7.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Left;
            this.label8.Location = new System.Drawing.Point(0, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 658);
            this.label8.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label9.Location = new System.Drawing.Point(10, 661);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(924, 20);
            this.label9.TabIndex = 23;
            // 
            // F8reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::BMSusingCsharp.Properties.Resources._149;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(944, 681);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnallcust);
            this.Controls.Add(this.btntotalsell);
            this.Controls.Add(this.btnstkalert);
            this.Controls.Add(this.btnstkcloth);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.btntotalprint);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F8reports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F8reports";
            this.Load += new System.EventHandler(this.F8reports_Load);
            this.GroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sellclothesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bMSCsharpDataSet4)).EndInit();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnexit;
        internal System.Windows.Forms.Button btnallcust;
        internal System.Windows.Forms.Button btntotalsell;
        internal System.Windows.Forms.Button btnstkalert;
        internal System.Windows.Forms.Button btnstkcloth;
        internal System.Windows.Forms.Button btnprint;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Button btnsellstt;
        internal System.Windows.Forms.DateTimePicker dtpto2;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.DateTimePicker dtpfrom2;
        internal System.Windows.Forms.Button btntotalprint;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Button btnprintstt;
        internal System.Windows.Forms.DateTimePicker dtpto1;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.DateTimePicker dtpfrom1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private BMSCsharpDataSet4 bMSCsharpDataSet4;
        private System.Windows.Forms.BindingSource sellclothesBindingSource;
        private BMSCsharpDataSet4TableAdapters.sellclothesTableAdapter sellclothesTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}