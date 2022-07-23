using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Security_Box
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void new_cash_in_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CashIn_Form cashIn_Form = new CashIn_Form();
            cashIn_Form.Show();
        }

        private void new_cash_out_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CashOut_Form cashOut_Form = new CashOut_Form();
            cashOut_Form.Show();
        }

        private void check_balance_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inquiry inquiry = new Inquiry();
            inquiry.Show();
        }

        private void Reports_all_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllTrans_report allTrans_Report = new AllTrans_report();
            allTrans_Report.Show();
        }

        private void detailedIn_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            InTrans_Report inTrans_Report = new InTrans_Report();
            inTrans_Report.Show();
        }

        private void detailedOut_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            OutTrans_Report outTrans_Report = new OutTrans_Report();
            outTrans_Report.Show();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
