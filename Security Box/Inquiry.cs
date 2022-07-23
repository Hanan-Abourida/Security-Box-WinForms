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
    public partial class Inquiry : Form
    {
        public Inquiry()
        {
            InitializeComponent();
        }

        //static string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\SecurityBox.accdb";
        static string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\Desktop\SecurityBox.accdb";

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Index index = new Index();
            index.Show();
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

        private void Inquiry_Load(object sender, EventArgs e)
        {
            amount_lbp.Text = String.Format("{0:n0}", retreiveLastLebaneseBalance());
            amount_usd.Text = String.Format("{0:n0}", retreiveLastUSDBalance());
            date_usd.Text = retreiveLastUSDModifiedDate().ToLongDateString();
            date_lbp.Text = retreiveLastModifiedDate().ToLongDateString();
        }

        private DateTime retreiveLastUSDModifiedDate()
        {
            DateTime lastDate = new DateTime();//Last_Modified_Date
            try
            {
                OleDbConnection connection = new OleDbConnection();
                connection.ConnectionString = connectionString;
                connection.Open();
                OleDbCommand command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                string query = "select [USD_Last_Modified_Date] from Balance";
                command.CommandText = query;
                lastDate = (DateTime)command.ExecuteScalar();
            }
            catch (Exception exc)
            {
                Console.Write("Exception in retreiving last balance: \n" + exc.Message);
            }

            return lastDate;
        }

        private DateTime retreiveLastModifiedDate()
        {
            DateTime lastDate = new DateTime();
            try
            {
                OleDbConnection connection = new OleDbConnection();
                connection.ConnectionString = connectionString;
                connection.Open();
                OleDbCommand command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                string query = "select [Last_Modified_Date] from Balance";
                command.CommandText = query;
                lastDate = (DateTime)command.ExecuteScalar();
            }
            catch (Exception exc)
            {
                Console.Write("Exception in retreiving last balance: \n" + exc.Message);
            }

            return lastDate;
        }
    }
}
