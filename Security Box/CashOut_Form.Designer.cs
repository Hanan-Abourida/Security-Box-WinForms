namespace Security_Box
{
    partial class CashOut_Form
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
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.save_cash_out = new System.Windows.Forms.Button();
            this.notes_txt = new System.Windows.Forms.TextBox();
            this.currency_Combo = new System.Windows.Forms.ComboBox();
            this.quantity_txt = new System.Windows.Forms.TextBox();
            this.date_time = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mainHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainHeader
            // 
            this.mainHeader.BackColor = System.Drawing.Color.Black;
            this.mainHeader.Controls.Add(this.Title_label);
            this.mainHeader.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mainHeader.Location = new System.Drawing.Point(32, 12);
            this.mainHeader.Name = "mainHeader";
            this.mainHeader.Size = new System.Drawing.Size(1041, 78);
            this.mainHeader.TabIndex = 33;
            // 
            // Title_label
            // 
            this.Title_label.AutoSize = true;
            this.Title_label.Font = new System.Drawing.Font("Book Antiqua", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_label.ForeColor = System.Drawing.Color.White;
            this.Title_label.Location = new System.Drawing.Point(17, 27);
            this.Title_label.Name = "Title_label";
            this.Title_label.Size = new System.Drawing.Size(121, 22);
            this.Title_label.TabIndex = 0;
            this.Title_label.Text = "New Cash Out";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(955, 567);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 29);
            this.button1.TabIndex = 45;
            this.button1.Text = "Back to Main";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Today cash-out transactions";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 330);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1041, 231);
            this.dataGridView1.TabIndex = 43;
            // 
            // save_cash_out
            // 
            this.save_cash_out.BackColor = System.Drawing.Color.ForestGreen;
            this.save_cash_out.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.save_cash_out.ForeColor = System.Drawing.Color.White;
            this.save_cash_out.Location = new System.Drawing.Point(116, 282);
            this.save_cash_out.Name = "save_cash_out";
            this.save_cash_out.Size = new System.Drawing.Size(62, 29);
            this.save_cash_out.TabIndex = 42;
            this.save_cash_out.Text = "save";
            this.save_cash_out.UseVisualStyleBackColor = false;
            this.save_cash_out.Click += new System.EventHandler(this.save_cash_out_Click);
            // 
            // notes_txt
            // 
            this.notes_txt.Location = new System.Drawing.Point(116, 191);
            this.notes_txt.Multiline = true;
            this.notes_txt.Name = "notes_txt";
            this.notes_txt.Size = new System.Drawing.Size(309, 85);
            this.notes_txt.TabIndex = 41;
            // 
            // currency_Combo
            // 
            this.currency_Combo.FormattingEnabled = true;
            this.currency_Combo.Location = new System.Drawing.Point(116, 163);
            this.currency_Combo.Name = "currency_Combo";
            this.currency_Combo.Size = new System.Drawing.Size(200, 21);
            this.currency_Combo.TabIndex = 40;
            // 
            // quantity_txt
            // 
            this.quantity_txt.Location = new System.Drawing.Point(116, 136);
            this.quantity_txt.Name = "quantity_txt";
            this.quantity_txt.Size = new System.Drawing.Size(200, 20);
            this.quantity_txt.TabIndex = 39;
            // 
            // date_time
            // 
            this.date_time.Location = new System.Drawing.Point(116, 109);
            this.date_time.Name = "date_time";
            this.date_time.Size = new System.Drawing.Size(200, 20);
            this.date_time.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 37;
            this.label4.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 36;
            this.label3.Text = "Currency";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 35;
            this.label2.Text = "Notes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 34;
            this.label1.Text = "Date";
            // 
            // CashOut_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 624);
            this.ControlBox = false;
            this.Controls.Add(this.mainHeader);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.save_cash_out);
            this.Controls.Add(this.notes_txt);
            this.Controls.Add(this.currency_Combo);
            this.Controls.Add(this.quantity_txt);
            this.Controls.Add(this.date_time);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CashOut_Form";
            this.Text = "CashOut_Form";
            this.Load += new System.EventHandler(this.CashOut_Form_Load);
            this.mainHeader.ResumeLayout(false);
            this.mainHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainHeader;
        private System.Windows.Forms.Label Title_label;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button save_cash_out;
        private System.Windows.Forms.TextBox notes_txt;
        private System.Windows.Forms.ComboBox currency_Combo;
        private System.Windows.Forms.TextBox quantity_txt;
        private System.Windows.Forms.DateTimePicker date_time;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}