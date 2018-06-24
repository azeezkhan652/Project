namespace BMSusingCsharp
{
    partial class F2newuser
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
            this.lblmsg = new System.Windows.Forms.Label();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.txtanswer = new System.Windows.Forms.TextBox();
            this.txtquestion = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.lblanswer = new System.Windows.Forms.Label();
            this.lblquestion = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.bMSCsharpDataSet = new BMSusingCsharp.BMSCsharpDataSet();
            this.loginBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bMSCsharpDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblmsg
            // 
            this.lblmsg.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblmsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmsg.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblmsg.Location = new System.Drawing.Point(126, 426);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(398, 45);
            this.lblmsg.TabIndex = 19;
            // 
            // btnsubmit
            // 
            this.btnsubmit.BackColor = System.Drawing.Color.Black;
            this.btnsubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnsubmit.FlatAppearance.BorderSize = 0;
            this.btnsubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubmit.ForeColor = System.Drawing.Color.White;
            this.btnsubmit.Location = new System.Drawing.Point(0, 464);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(317, 97);
            this.btnsubmit.TabIndex = 18;
            this.btnsubmit.Text = "SUBMIT";
            this.btnsubmit.UseVisualStyleBackColor = false;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // txtanswer
            // 
            this.txtanswer.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtanswer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtanswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtanswer.ForeColor = System.Drawing.SystemColors.Info;
            this.txtanswer.Location = new System.Drawing.Point(332, 353);
            this.txtanswer.Name = "txtanswer";
            this.txtanswer.Size = new System.Drawing.Size(241, 24);
            this.txtanswer.TabIndex = 17;
            this.txtanswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtquestion
            // 
            this.txtquestion.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtquestion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtquestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquestion.ForeColor = System.Drawing.SystemColors.Info;
            this.txtquestion.Location = new System.Drawing.Point(29, 353);
            this.txtquestion.Name = "txtquestion";
            this.txtquestion.Size = new System.Drawing.Size(244, 24);
            this.txtquestion.TabIndex = 15;
            this.txtquestion.Text = "Your childhood friend?";
            this.txtquestion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtpassword
            // 
            this.txtpassword.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.ForeColor = System.Drawing.SystemColors.Info;
            this.txtpassword.Location = new System.Drawing.Point(332, 159);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(241, 24);
            this.txtpassword.TabIndex = 13;
            this.txtpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtusername
            // 
            this.txtusername.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtusername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.ForeColor = System.Drawing.SystemColors.Info;
            this.txtusername.Location = new System.Drawing.Point(29, 159);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(244, 24);
            this.txtusername.TabIndex = 11;
            this.txtusername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblanswer
            // 
            this.lblanswer.AutoSize = true;
            this.lblanswer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblanswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblanswer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblanswer.Location = new System.Drawing.Point(403, 258);
            this.lblanswer.Name = "lblanswer";
            this.lblanswer.Size = new System.Drawing.Size(110, 25);
            this.lblanswer.TabIndex = 16;
            this.lblanswer.Text = "ANSWER";
            // 
            // lblquestion
            // 
            this.lblquestion.AutoSize = true;
            this.lblquestion.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblquestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblquestion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblquestion.Location = new System.Drawing.Point(91, 258);
            this.lblquestion.Name = "lblquestion";
            this.lblquestion.Size = new System.Drawing.Size(128, 25);
            this.lblquestion.TabIndex = 14;
            this.lblquestion.Text = "QUESTION";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblpassword.Location = new System.Drawing.Point(382, 61);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(142, 25);
            this.lblpassword.TabIndex = 12;
            this.lblpassword.Text = "PASSWORD";
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblusername.Location = new System.Drawing.Point(80, 61);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(139, 25);
            this.lblusername.TabIndex = 10;
            this.lblusername.Text = "USERNAME";
            // 
            // bMSCsharpDataSet
            // 
            this.bMSCsharpDataSet.DataSetName = "BMSCsharpDataSet";
            this.bMSCsharpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loginBindingSource
            // 
            this.loginBindingSource.DataMember = "login";
            this.loginBindingSource.DataSource = this.bMSCsharpDataSet;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(323, 464);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(230, 97);
            this.button1.TabIndex = 20;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Lime;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(600, 40);
            this.label1.TabIndex = 21;
            this.label1.Text = "NEW USER";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // F2newuser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::BMSusingCsharp.Properties.Resources.Untitled155;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.txtanswer);
            this.Controls.Add(this.txtquestion);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.lblanswer);
            this.Controls.Add(this.lblquestion);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblusername);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F2newuser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F2newuser";
            this.Load += new System.EventHandler(this.F2newuser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bMSCsharpDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.TextBox txtanswer;
        internal System.Windows.Forms.TextBox txtquestion;
        internal System.Windows.Forms.TextBox txtpassword;
        internal System.Windows.Forms.TextBox txtusername;
        internal System.Windows.Forms.Label lblanswer;
        internal System.Windows.Forms.Label lblquestion;
        internal System.Windows.Forms.Label lblpassword;
        internal System.Windows.Forms.Label lblusername;
        private BMSCsharpDataSet bMSCsharpDataSet;
        private System.Windows.Forms.BindingSource loginBindingSource;
        public System.Windows.Forms.Label lblmsg;
        public System.Windows.Forms.Button btnsubmit;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}