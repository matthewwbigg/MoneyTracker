using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MoneyTrackerCSHARP.TransactionsDataSetTableAdapters;

namespace MoneyTrackerCSHARP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Create Data table for transactions
        DataTable datTransactions = new DataTable();

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'transactionsDataSet.Transactions' table. You can move, or remove it, as needed.
            this.transactionsTableAdapter.Fill(this.transactionsDataSet.Transactions);
            //connection and command for OleDbDataAdapter

            OleDbConnection connect = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\biggm\\Desktop\\My Programs\\MoneyTrackerCSHARP\\MoneyTrackerCSHARP\\MoneyTracker.accdb");
            OleDbCommand command = new OleDbCommand("SELECT * FROM Transactions", connect);

            //Need to open the connection
            connect.Open();

            //Create OleDbAdapter object with connection and command

            OleDbDataAdapter odaTransactions = new OleDbDataAdapter(command);

            //Fill data table with adapter
            odaTransactions.Fill(datTransactions);

            //Don't forget to close connection to database since data has already been imported by the adapter to the DataTable instance.
           connect.Close();

            //Now call datTransactions.Rows[][].ToString() to pull data from the table.

            //Use .compute to parse table to get max value in ID column
            int currentID;

            currentID = Convert.ToInt32(datTransactions.Compute("max([Transaction ID])", ""));
            currentID++;
            txtTransID.Text = currentID.ToString();




        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnViewData_Click(object sender, EventArgs e)
        {
            //Instantiate DataViewForm object and call showDialog method to show form.
            DataViewForm openData = new DataViewForm();
            openData.ShowDialog();
        }

        private void btnAddTrans_Click(object sender, EventArgs e)
        {
            //Button will create a new row, add the values from the text boxes on teh form to the rox and add the row to the database.

            //Use convert.toInt32 to cast string to int

            //Make row, add items to row, THEN add row to table [This took me longer than it should have.]
            //DataRow newRow = transactionsDataSet.Transactions.NewTransactionsRow();

            //newRow["Transaction ID"] = Convert.ToInt32(txtTransID.Text);
            //newRow["Amount"] = Convert.ToDecimal(txtAmount.Text);
            //newRow["Deposit?"] = chkDeposit.Checked;
            //newRow["Dates"] = DateTime.Now;
            //newRow["Category"] = txtCategory.Text;

            //transactionsDataSet.Transactions.AddTransactionsRow(newRow);

            //Update database with table that has new row
            //this.Validate();
            //this.transactionsBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll (this.transactionsDataSet);


            //did data make it into data row? [It didn't.]
            // String dataItem = datTransactions.R

            //Got nowhere with the code above. [Ignore it. Don't look at it. Don't even remotely consider it. I've been at C# for 3 days.]


            //connection and SQP strings
            string connect = "Data Source=C:\\Users\\biggm\\Documents\\MoneyTracker.accdb";
            string sql = "UPDATE Transactions SET [Transaction ID] = @transID, Amount = @amount, [Deposit?] = @deposit, Dates = @dates, Category = @category ";

            //try-catch to try to update the database. Will Return error message is there's an issue
            try
            {
                //connection variable
                using (var connection = new SqlConnection(connect))
                {
                    //command variable
                    using (var command = new SqlCommand(sql, connection))
                    {
                        //each line adds each piece of data before executing the sql command and updating the database
                        //Parameters.Add(STRING, DATA ITEM);
                        command.Parameters.AddWithValue("@transID", Convert.ToInt32(txtTransID.Text));

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }

            } catch (Exception ex)
            {
                MessageBox.Show($"Failed to update. Error message: {ex.Message}");
            }




        }
    }
}
