using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem
{
    public partial class AllTransactionsView : Form
    {

        private bool singleClient = false;

        /// <summary>
        /// Used when viewing all transactions.
        /// </summary>
        public AllTransactionsView()
        {
            InitializeComponent();
            //gb_TransactionType.Visible = false;
            LoadTransactionsGrid();
        }

        /// <summary>
        /// Used when viewing selected client's transactions.
        /// </summary>
        /// <param name="accountID"></param>
        public AllTransactionsView(string accountID)
        {
            InitializeComponent();
            singleClient = true;
            tb_Iban.Text = accountID;
            tb_Iban.Enabled = false;
            LoadTransactionsGrid(accountID);
        }


        public void LoadTransactionsGrid(string accountID)
        {
            dgv_AllTransactions.DataSource = new AllTransactionsModel().GetAllTransactions(accountID);
            dgv_AllTransactions.DataMember = "Transactions";
            dgv_AllTransactions.Columns[0].Visible = false;
            dgv_AllTransactions.Columns[3].FillWeight = 50;
            dgv_AllTransactions.Columns[4].FillWeight = 50;
            dgv_AllTransactions.Columns[5].FillWeight = 50;
            dgv_AllTransactions.Columns[6].FillWeight = 50;
            dgv_AllTransactions.Columns[8].FillWeight = 50;
        }

        public void LoadTransactionsGrid()
        {
            dgv_AllTransactions.DataSource = new AllTransactionsModel().GetAllTransactions();
            dgv_AllTransactions.DataMember = "AllTransactions";
            dgv_AllTransactions.Columns[0].Visible = false;
            dgv_AllTransactions.Columns[3].FillWeight = 50;
            dgv_AllTransactions.Columns[4].FillWeight = 50;
            dgv_AllTransactions.Columns[5].FillWeight = 50;
            dgv_AllTransactions.Columns[6].FillWeight = 50;
            dgv_AllTransactions.Columns[8].FillWeight = 50;
        }

        private void btn_RemoveFilter_Click(object sender, EventArgs e)
        {
            rb_All.Checked = true;
            tb_EarliestDate.Text = String.Empty;
            tb_LatestDate.Text = String.Empty;
            tb_AmountHighPoint.Text = String.Empty;
            tb_AmountLowPoint.Text = String.Empty;

            if (singleClient)
            {
                LoadTransactionsGrid(tb_Iban.Text);
            }
            else
            {
                tb_Iban.Text = String.Empty;
                LoadTransactionsGrid();
            }

        }

        private void btn_Filter_Click(object sender, EventArgs e)
        {


            string transactionType;

            if (rb_Credit.Checked)
            {
                transactionType = "credit";
            }
            else if (rb_Debit.Checked)
            {
                transactionType = "debit";
            }
            else
            {
                transactionType = "all";
            }
           


            List<string> filterCriteria = new List<string>() {tb_Iban.Text, transactionType, tb_AmountLowPoint.Text,tb_AmountHighPoint.Text,tb_EarliestDate.Text,tb_LatestDate.Text };

            dgv_AllTransactions.DataSource = new AllTransactionsModel().GetFilteredTransactions(filterCriteria);
            dgv_AllTransactions.DataMember = "FilteredTransactions";
            dgv_AllTransactions.Columns[0].Visible = false;
            dgv_AllTransactions.Columns[3].FillWeight = 50;
            dgv_AllTransactions.Columns[4].FillWeight = 50;
            dgv_AllTransactions.Columns[5].FillWeight = 50;
            dgv_AllTransactions.Columns[6].FillWeight = 50;
            dgv_AllTransactions.Columns[8].FillWeight = 50;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
