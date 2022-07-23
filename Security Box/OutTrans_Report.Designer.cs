namespace Security_Box
{
    partial class OutTrans_Report
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
            this.cashTransactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.securityBoxDS = new Security_Box.SecurityBoxDS();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.show_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.mainHeader = new System.Windows.Forms.Panel();
            this.Title_label = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cash_TransactionTableAdapter = new Security_Box.SecurityBoxDSTableAdapters.Cash_TransactionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cashTransactionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.securityBoxDS)).BeginInit();
            this.panel1.SuspendLayout();
            this.mainHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // cashTransactionBindingSource
            // 
            this.cashTransactionBindingSource.DataMember = "Cash_Transaction";
            this.cashTransactionBindingSource.DataSource = this.securityBoxDS;
            // 
            // securityBoxDS
            // 
            this.securityBoxDS.DataSetName = "SecurityBoxDS";
            this.securityBoxDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(963, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 27);
            this.button1.TabIndex = 26;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.show_btn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Location = new System.Drawing.Point(12, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1061, 91);
            this.panel1.TabIndex = 25;
            // 
            // show_btn
            // 
            this.show_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.show_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_btn.Location = new System.Drawing.Point(115, 59);
            this.show_btn.Name = "show_btn";
            this.show_btn.Size = new System.Drawing.Size(97, 28);
            this.show_btn.TabIndex = 16;
            this.show_btn.Text = "Show Report";
            this.show_btn.UseVisualStyleBackColor = false;
            this.show_btn.Click += new System.EventHandler(this.show_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "To date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "From date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(115, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(115, 33);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 12;
            // 
            // mainHeader
            // 
            this.mainHeader.BackColor = System.Drawing.Color.Black;
            this.mainHeader.Controls.Add(this.Title_label);
            this.mainHeader.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mainHeader.Location = new System.Drawing.Point(12, 12);
            this.mainHeader.Name = "mainHeader";
            this.mainHeader.Size = new System.Drawing.Size(1061, 78);
            this.mainHeader.TabIndex = 24;
            // 
            // Title_label
            // 
            this.Title_label.AutoSize = true;
            this.Title_label.Font = new System.Drawing.Font("Book Antiqua", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_label.ForeColor = System.Drawing.Color.White;
            this.Title_label.Location = new System.Drawing.Point(17, 27);
            this.Title_label.Name = "Title_label";
            this.Title_label.Size = new System.Drawing.Size(206, 22);
            this.Title_label.TabIndex = 0;
            this.Title_label.Text = "Detailed Cash-Out Report";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.cashTransactionBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Security_Box.Detailed_CashOut.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 227);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1061, 385);
            this.reportViewer1.TabIndex = 27;
            // 
            // cash_TransactionTableAdapter
            // 
            this.cash_TransactionTableAdapter.ClearBeforeFill = true;
            // 
            // OutTrans_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 624);
            this.ControlBox = false;
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainHeader);
            this.Name = "OutTrans_Report";
            this.Text = "OutTrans_Report";
            this.Load += new System.EventHandler(this.OutTrans_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cashTransactionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.securityBoxDS)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.mainHeader.ResumeLayout(false);
            this.mainHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button show_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Panel mainHeader;
        private System.Windows.Forms.Label Title_label;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private SecurityBoxDS securityBoxDS;
        private System.Windows.Forms.BindingSource cashTransactionBindingSource;
        private SecurityBoxDSTableAdapters.Cash_TransactionTableAdapter cash_TransactionTableAdapter;
    }
}