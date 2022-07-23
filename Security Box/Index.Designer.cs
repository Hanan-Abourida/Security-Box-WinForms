namespace Security_Box
{
    partial class Index
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
            this.mainHeader = new System.Windows.Forms.Panel();
            this.welcome_text = new System.Windows.Forms.Label();
            this.Title_label = new System.Windows.Forms.Label();
            this.new_cash_out_btn = new System.Windows.Forms.Button();
            this.check_balance_btn = new System.Windows.Forms.Button();
            this.Reports_all_btn = new System.Windows.Forms.Button();
            this.close_btn = new System.Windows.Forms.Button();
            this.new_cash_in_btn = new System.Windows.Forms.Button();
            this.detailedIn_btn = new System.Windows.Forms.Button();
            this.detailedOut_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mainHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainHeader
            // 
            this.mainHeader.BackColor = System.Drawing.Color.Black;
            this.mainHeader.Controls.Add(this.welcome_text);
            this.mainHeader.Controls.Add(this.Title_label);
            this.mainHeader.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mainHeader.Location = new System.Drawing.Point(12, 12);
            this.mainHeader.Name = "mainHeader";
            this.mainHeader.Size = new System.Drawing.Size(695, 78);
            this.mainHeader.TabIndex = 16;
            // 
            // welcome_text
            // 
            this.welcome_text.AutoSize = true;
            this.welcome_text.Location = new System.Drawing.Point(23, 54);
            this.welcome_text.Name = "welcome_text";
            this.welcome_text.Size = new System.Drawing.Size(225, 13);
            this.welcome_text.TabIndex = 1;
            this.welcome_text.Text = "Welcome to Security Box management system";
            // 
            // Title_label
            // 
            this.Title_label.AutoSize = true;
            this.Title_label.Font = new System.Drawing.Font("Bernard MT Condensed", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_label.ForeColor = System.Drawing.Color.White;
            this.Title_label.Location = new System.Drawing.Point(22, 21);
            this.Title_label.Name = "Title_label";
            this.Title_label.Size = new System.Drawing.Size(96, 21);
            this.Title_label.TabIndex = 0;
            this.Title_label.Text = "Security Box";
            // 
            // new_cash_out_btn
            // 
            this.new_cash_out_btn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.new_cash_out_btn.Location = new System.Drawing.Point(236, 159);
            this.new_cash_out_btn.Name = "new_cash_out_btn";
            this.new_cash_out_btn.Size = new System.Drawing.Size(234, 45);
            this.new_cash_out_btn.TabIndex = 15;
            this.new_cash_out_btn.Text = "New Cash Out";
            this.new_cash_out_btn.UseVisualStyleBackColor = false;
            this.new_cash_out_btn.Click += new System.EventHandler(this.new_cash_out_btn_Click);
            // 
            // check_balance_btn
            // 
            this.check_balance_btn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.check_balance_btn.Location = new System.Drawing.Point(236, 206);
            this.check_balance_btn.Name = "check_balance_btn";
            this.check_balance_btn.Size = new System.Drawing.Size(234, 45);
            this.check_balance_btn.TabIndex = 14;
            this.check_balance_btn.Text = "Balance Inquiry";
            this.check_balance_btn.UseVisualStyleBackColor = false;
            this.check_balance_btn.Click += new System.EventHandler(this.check_balance_btn_Click);
            // 
            // Reports_all_btn
            // 
            this.Reports_all_btn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Reports_all_btn.Location = new System.Drawing.Point(65, 297);
            this.Reports_all_btn.Name = "Reports_all_btn";
            this.Reports_all_btn.Size = new System.Drawing.Size(169, 44);
            this.Reports_all_btn.TabIndex = 13;
            this.Reports_all_btn.Text = "All Transactions";
            this.Reports_all_btn.UseVisualStyleBackColor = false;
            this.Reports_all_btn.Click += new System.EventHandler(this.Reports_all_btn_Click);
            // 
            // close_btn
            // 
            this.close_btn.BackColor = System.Drawing.Color.IndianRed;
            this.close_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.close_btn.Location = new System.Drawing.Point(541, 401);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(114, 27);
            this.close_btn.TabIndex = 12;
            this.close_btn.Text = "Quit Application";
            this.close_btn.UseVisualStyleBackColor = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // new_cash_in_btn
            // 
            this.new_cash_in_btn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.new_cash_in_btn.Location = new System.Drawing.Point(236, 112);
            this.new_cash_in_btn.Name = "new_cash_in_btn";
            this.new_cash_in_btn.Size = new System.Drawing.Size(234, 45);
            this.new_cash_in_btn.TabIndex = 11;
            this.new_cash_in_btn.Text = "New Cash In";
            this.new_cash_in_btn.UseVisualStyleBackColor = false;
            this.new_cash_in_btn.Click += new System.EventHandler(this.new_cash_in_btn_Click);
            // 
            // detailedIn_btn
            // 
            this.detailedIn_btn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.detailedIn_btn.Location = new System.Drawing.Point(260, 297);
            this.detailedIn_btn.Name = "detailedIn_btn";
            this.detailedIn_btn.Size = new System.Drawing.Size(169, 44);
            this.detailedIn_btn.TabIndex = 20;
            this.detailedIn_btn.Text = "Detailed In Transactions";
            this.detailedIn_btn.UseVisualStyleBackColor = false;
            this.detailedIn_btn.Click += new System.EventHandler(this.detailedIn_btn_Click);
            // 
            // detailedOut_btn
            // 
            this.detailedOut_btn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.detailedOut_btn.Location = new System.Drawing.Point(451, 297);
            this.detailedOut_btn.Name = "detailedOut_btn";
            this.detailedOut_btn.Size = new System.Drawing.Size(169, 44);
            this.detailedOut_btn.TabIndex = 19;
            this.detailedOut_btn.Text = "Detailed Out Transactions";
            this.detailedOut_btn.UseVisualStyleBackColor = false;
            this.detailedOut_btn.Click += new System.EventHandler(this.detailedOut_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Reports";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(52, 289);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(602, 2);
            this.panel1.TabIndex = 17;
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 447);
            this.ControlBox = false;
            this.Controls.Add(this.mainHeader);
            this.Controls.Add(this.new_cash_out_btn);
            this.Controls.Add(this.check_balance_btn);
            this.Controls.Add(this.Reports_all_btn);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.new_cash_in_btn);
            this.Controls.Add(this.detailedIn_btn);
            this.Controls.Add(this.detailedOut_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Index";
            this.Text = "Index";
            this.mainHeader.ResumeLayout(false);
            this.mainHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainHeader;
        private System.Windows.Forms.Label welcome_text;
        private System.Windows.Forms.Label Title_label;
        private System.Windows.Forms.Button new_cash_out_btn;
        private System.Windows.Forms.Button check_balance_btn;
        private System.Windows.Forms.Button Reports_all_btn;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.Button new_cash_in_btn;
        private System.Windows.Forms.Button detailedIn_btn;
        private System.Windows.Forms.Button detailedOut_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}

