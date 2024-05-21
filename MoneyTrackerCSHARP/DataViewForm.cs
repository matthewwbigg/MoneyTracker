using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyTrackerCSHARP
{
    public partial class DataViewForm : Form
    {
        public DataViewForm()
        {
            InitializeComponent();
        }

        private void transactionsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.transactionsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.transactionsDataSet);

        }

        private void DataViewForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'transactionsDataSet.Transactions' table. You can move, or remove it, as needed.
            this.transactionsTableAdapter.Fill(this.transactionsDataSet.Transactions);

        }

        private void btnDataClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
