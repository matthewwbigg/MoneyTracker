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

namespace MoneyTrackerCSHARP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //connection and command for OleDbDataAdapter

            OleDbConnection connect = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\biggm\\Desktop\\My Programs\\MoneyTrackerCSHARP\\MoneyTrackerCSHARP\\MoneyTracker.accdb");
            OleDbCommand command = new OleDbCommand("SELECT * FROM Transactions", connect);



















        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
