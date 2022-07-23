namespace Security_Box
{
    partial class Inquiry
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
            this.Title_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.amount_lbp = new System.Windows.Forms.Label();
            this.date_lbp = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.date_usd = new System.Windows.Forms.Label();
            this.amount_usd = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.mainHeader.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainHeader
            // 
            this.mainHeader.BackColor = System.Drawing.Color.Black;
            this.mainHeader.Controls.Add(this.Title_label);
            this.mainHeader.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mainHeader.Location = new System.Drawing.Point(12, 12);
            this.mainHeader.Name = "mainHeader";
            this.mainHeader.Size = new System.Drawing.Size(695, 78);
            this.mainHeader.TabIndex = 17;
            // 
            // Title_label
            // 
            this.Title_label.AutoSize = true;
            this.Title_label.Font = new System.Drawing.Font("Bernard MT Condensed", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_label.ForeColor = System.Drawing.Color.White;
            this.Title_label.Location = new System.Drawing.Point(17, 25);
            this.Title_label.Name = "Title_label";
            this.Title_label.Size = new System.Drawing.Size(96, 21);
            this.Title_label.TabIndex = 0;
            this.Title_label.Text = "Security Box";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Available amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Last modified date";
            // 
            // amount_lbp
            // 
            this.amount_lbp.AutoSize = true;
            this.amount_lbp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount_lbp.Location = new System.Drawing.Point(168, 28);
            this.amount_lbp.Name = "amount_lbp";
            this.amount_lbp.Size = new System.Drawing.Size(35, 13);
            this.amount_lbp.TabIndex = 20;
            this.amount_lbp.Text = "label3";
            // 
            // date_lbp
            // 
            this.date_lbp.AutoSize = true;
            this.date_lbp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_lbp.Location = new System.Drawing.Point(168, 51);
            this.date_lbp.Name = "date_lbp";
            this.date_lbp.Size = new System.Drawing.Size(35, 13);
            this.date_lbp.TabIndex = 21;
            this.date_lbp.Text = "label4";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.date_lbp);
            this.groupBox1.Controls.Add(this.amount_lbp);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(154, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(411, 99);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Currency: LBP";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.date_usd);
            this.groupBox2.Controls.Add(this.amount_usd);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(154, 259);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(411, 99);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Currency: USD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Available amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Last modified date";
            // 
            // date_usd
            // 
            this.date_usd.AutoSize = true;
            this.date_usd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_usd.Location = new System.Drawing.Point(168, 53);
            this.date_usd.Name = "date_usd";
            this.date_usd.Size = new System.Drawing.Size(35, 13);
            this.date_usd.TabIndex = 25;
            this.date_usd.Text = "label7";
            // 
            // amount_usd
            // 
            this.amount_usd.AutoSize = true;
            this.amount_usd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount_usd.Location = new System.Drawing.Point(168, 30);
            this.amount_usd.Name = "amount_usd";
            this.amount_usd.Size = new System.Drawing.Size(35, 13);
            this.amount_usd.TabIndex = 24;
            this.amount_usd.Text = "label8";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(597, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 27);
            this.button1.TabIndex = 35;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Inquiry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 447);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mainHeader);
            this.Name = "Inquiry";
            this.Text = "Inquiry";
            this.Load += new System.EventHandler(this.Inquiry_Load);
            this.mainHeader.ResumeLayout(false);
            this.mainHeader.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainHeader;
        private System.Windows.Forms.Label Title_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label amount_lbp;
        private System.Windows.Forms.Label date_lbp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label date_usd;
        private System.Windows.Forms.Label amount_usd;
        private System.Windows.Forms.Button button1;
    }
}