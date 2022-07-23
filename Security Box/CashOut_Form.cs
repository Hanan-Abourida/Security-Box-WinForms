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
    public partial class CashOut_Form : Form
    {
        public CashOut_Form()
        {
            InitializeComponent();
        }

        //static string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DataDirectory|\SecurityBox.accdb";
        static string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\Desktop\SecurityBox.accdb";

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

        private void updateTotalLebaneseBalance(double newBalance)
        {
            OleDbConnection connection = new OleDbConnection();
            try
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                OleDbCommand command = connection.CreateCommand();
                command.CommandType = CommandType.Text;

                string query = "UPDATE Balance SET [Balance] = @newBalance, [Last_Modified_Date] = @newDate WHERE ID = 1";
                command.CommandText = query;
                command.Parameters.Add("@newBalance", OleDbType.Double).Value = newBalance;
                command.Parameters.Add("@newDate", OleDbType.DBDate).Value = DateTime.Now;
                int i = command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update to balance Failed.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }

            }
        }

        private void updateTotalUSDBalance(double newBalance)
        {
            OleDbConnection connection = new OleDbConnection();
            try
            {
                connection.ConnectionString = connectionString;
                connection.Open();
                OleDbCommand command = connection.CreateCommand();
                command.CommandType = CommandType.Text;

                string query = "UPDATE Balance SET [USDBalance] = @newBalance, [USD_Last_Modified Date] = @newDate WHERE ID = 1";
                command.CommandText = query;
                command.Parameters.Add("@newBalance", OleDbType.Double).Value = newBalance;
                command.Parameters.Add("@newDate", OleDbType.DBDate).Value = DateTime.Now;
                int i = command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update to balance Failed.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }

            }

        }

        private void clearFormForAnotherEntry()
        {
            quantity_txt.Text = "";
            currency_Combo.SelectedIndex = 0;
            notes_txt.Text = "";
        }

        private void refreshGridOfToday()
        {
            //fill the cash in table with result from query where type=IN and date=today;
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = connectionString;
            connection.Open();
            DataTable dataTable = new DataTable();
            try
            {
                string query = "select [ID],[Transaction_Date], [Transaction_Time], [Quantity],[Cash_Currency],[Notes] from Cash_Transaction where [Transaction_Type] = 'OUT'"
                    + " and [Transaction_Date]=Date() order by ID DESC";
                OleDbCommand command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = query;
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(command);
                dataAdapter.Fill(dataTable);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error in refreshing the grid.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            dataGridView1.DataSource = dataTable;
            styleDataGridView();
            connection.Close();
        }

        private void CashOut_Form_Load(object sender, EventArgs e)
        {
            //fill the cash in table with result from query where type=IN and date=today;
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = connectionString;
            connection.Open();
            DataTable dataTable = new DataTable();
            try
            {
                //string query = "select * from Cash_Transaction where [Transaction Date]=Date()" + " and [Transaction Type] = 'IN'";
                string query = "select [ID],[Transaction_Date], [Transaction_Time], [Quantity],[Cash_Currency],[Notes] from Cash_Transaction where [Transaction_Type] = 'OUT'"
                    + " and [Transaction_Date]=Date() order by ID DESC";
                OleDbCommand command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = query;
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(command);
                dataAdapter.Fill(dataTable);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Can not load today transactions to grid.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            dataGridView1.DataSource = dataTable;

            styleDataGridView();
            
            connection.Close();

            currency_Combo.Items.Add("LBP");
            currency_Combo.Items.Add("USD");
            currency_Combo.SelectedIndex = 0;
        }

        private void save_cash_out_Click(object sender, EventArgs e)
        {
            double lastSavedBalance = 0;
            if (currency_Combo.SelectedItem.ToString().Equals("LBP"))
            {
                lastSavedBalance = retreiveLastLebaneseBalance();
            }
            else if (currency_Combo.SelectedItem.ToString().Equals("USD"))
            {
                lastSavedBalance = retreiveLastUSDBalance();
            }

            try
            {
                // Decimal quantity = Decimal.Parse(quantity_txt.Text);
                Double quantity = Double.Parse(quantity_txt.Text);

                if (quantity > lastSavedBalance)
                {
                    MessageBox.Show("The cash quantity is greater than available balance.", "Save Failed");
                    return;
                }

                string trans_currency = currency_Combo.SelectedItem.ToString();
                DateTime trans_date = date_time.Value.Date;
                TimeSpan trans_time = date_time.Value.TimeOfDay;
                string trans_type = "OUT";
                string notes = notes_txt.Text;

                OleDbConnection connection = new OleDbConnection();
                connection.ConnectionString = connectionString;
                connection.Open();
                OleDbCommand command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                string query = "insert into [Cash_Transaction]([Transaction_Date],[Transaction_Time], [Quantity], [Cash_Currency], [Transaction_Type], [Notes], [Balance]) "
                    + " values(@Transaction_Date,@Quantity,@Cash_Currency,@Transaction_Type,@Transaction_Time,@Notes,@Balance)";
                command.CommandText = query;
                command.Parameters.Add("@Transaction_Date", OleDbType.DBDate).Value = trans_date;
                command.Parameters.Add("@Transaction_Time", OleDbType.DBTime).Value = trans_time;
                command.Parameters.Add("@Quantity", OleDbType.Double).Value = quantity;
                command.Parameters.Add("@Cash_Currency", OleDbType.VarWChar).Value = trans_currency;
                command.Parameters.Add("@Transaction_Type", OleDbType.VarWChar).Value = trans_type;
                command.Parameters.Add("@Notes", OleDbType.VarWChar).Value = notes;
                double newBalance = lastSavedBalance - quantity;
                command.Parameters.Add("@Balance", OleDbType.Decimal).Value = newBalance;
                int i = command.ExecuteNonQuery();
                connection.Close();

                if (currency_Combo.SelectedItem.ToString().Equals("LBP"))
                {
                    updateTotalLebaneseBalance(newBalance);
                }
                else if (currency_Combo.SelectedItem.ToString().Equals("USD"))
                {
                    updateTotalUSDBalance(newBalance);
                }

                clearFormForAnotherEntry();
                refreshGridOfToday();
                MessageBox.Show("Cash-Out transaction added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Save Failed.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(quantity_txt.Text))
            {
                var result = MessageBox.Show("You have unsaved data. Click Yes to discard or No to save.", "Prompt Message",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    this.Hide();
                    Index index = new Index();
                    index.Show();
                }
            }
            else
            {
                this.Hide();
                Index index = new Index();
                index.Show();
            }
        }

        private void styleDataGridView()
        {
            if (dataGridView1.Columns.Count > 1)
            {
                dataGridView1.Columns[2].DefaultCellStyle.Format = "hh:mm:ss tt";
            }
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                dataGridView1.Columns[i].HeaderText = dataGridView1.Columns[i].HeaderText.Replace("_", " ");
                if (dataGridView1.Columns[i].HeaderText.Equals("Quantity"))
                {
                    dataGridView1.Columns[i].HeaderText = "Amount";
                }
            }
        }
    }
}

