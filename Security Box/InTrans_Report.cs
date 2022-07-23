using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Security_Box
{
    public partial class InTrans_Report : Form
    {
        public InTrans_Report()
        {
            InitializeComponent();
        }

        //static string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\SecurityBox.accdb";
        static string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\Desktop\SecurityBox.accdb";

        private void InTrans_Report_Load(object sender, EventArgs e)
        {
            this.reportViewer1.Visible = false;
        }

        private void show_btn_Click(object sender, EventArgs e)
        {
            this.reportViewer1.Visible = true;
            this.cash_TransactionTableAdapter.FillByInBetweenDates(this.securityBoxDS.Cash_Transaction, dateTimePicker1.Value.Date, dateTimePicker2.Value.Date);
            fillParameters();
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Index index = new Index();
            index.Show();
        }

        private void fillParameters()
        {
            ReportParameter[] parms = new ReportParameter[4];
            parms[0] = new ReportParameter("fromdateparam", dateTimePicker1.Value.Date.ToShortDateString());
            parms[1] = new ReportParameter("todateparam", dateTimePicker2.Value.Date.ToShortDateString());
            parms[2] = new ReportParameter("balanceLBP", retreiveLastLebaneseBalance().ToString());
            parms[3] = new ReportParameter("balanceUSD", retreiveLastUSDBalance().ToString());
            this.reportViewer1.LocalReport.SetParameters(parms);
        }

        private double retreiveLastLebaneseBalance()
        {
            double lastBalance = 0;
            try
            {
                OleDbConnection connection = new OleDbConnection();
                connection.ConnectionString = connectionString;
                connection.Open();
                OleDbCommand command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                string query = "select [Balance] from Balance";
                command.CommandText = query;
                lastBalance = (double)command.ExecuteScalar();
            }
            catch (Exception exc)
            {
                Console.Write("Exception in retreiving last balance: \n" + exc.Message);
            }

            return lastBalance;
        }

        private double retreiveLastUSDBalance()
        {
            double lastBalance = 0;
            try
            {
                OleDbConnection connection = new OleDbConnection();
                connection.ConnectionString = connectionString;
                connection.Open();
                OleDbCommand command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                string query = "select [USDBalance] from Balance";
                command.CommandText = query;
                lastBalance = (double)command.ExecuteScalar();
            }
            catch (Exception exc)
            {
                Console.Write("Exception in retreiving last balance: \n" + exc.Message);
            }

            return lastBalance;
        }

    }
}
