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

        /// <summary>
        /// Used when viewing all transactions.
        /// </summary>
        public AllTransactionsView()
        {
            InitializeComponent();
            LoadTransactionsGrid();
        }

        /// <summary>
        /// Used when viewing selected client's transactions.
        /// </summary>
        /// <param name="clientId"></param>
        public AllTransactionsView(string accountID)
        {
            InitializeComponent();
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



    }
}
