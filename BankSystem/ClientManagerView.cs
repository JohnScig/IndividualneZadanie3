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
    public partial class ClientManagerView : Form
    {
        string personalID;
        string IBAN;
        /// <summary>
        /// Backup, do not really use :)
        /// </summary>
        //public ClientManagerView() : this(0) { }

        /// <summary>
        /// Used when viewing/updating existing client.
        /// </summary>
        /// <param name="clientId"></param>
        public ClientManagerView(string personalID)

        {
            InitializeComponent();
            this.personalID = personalID;
            LoadClientInfoGridViews();
        }

        public void LoadClientInfoGridViews()
        {
            dgv_ClientInfo.Rows.Clear();
            List<string> clientInfo = new ClientManagerModel().GetClientAndAccountInfo(personalID);
            IBAN = clientInfo[5];
            dgv_ClientInfo.Rows.Add(clientInfo[1],clientInfo[2],clientInfo[3],clientInfo[4],clientInfo[5], clientInfo[6], clientInfo[7]);
            LoadCardInfoGridView(IBAN);
        }

        public void LoadCardInfoGridView(string iban)
        {
            dgv_CardsInfo.DataSource = new ClientManagerModel().GetCardInfo(iban);
            dgv_CardsInfo.DataMember = "Cards";
            dgv_CardsInfo.Columns[1].FillWeight = 60;
            dgv_CardsInfo.Columns[2].FillWeight = 50;
        }

        private void btn_AddCard_Click(object sender, EventArgs e)
        {
            new NewPinView(IBAN).ShowDialog();
            LoadCardInfoGridView(IBAN);
        }

        private void btn_ResetPin_Click(object sender, EventArgs e)
        {
            new NewPinView(IBAN,dgv_CardsInfo.SelectedRows[0].Cells[0].Value.ToString()).ShowDialog();
            LoadCardInfoGridView(IBAN);
        }

        private void btn_BlockCard_Click(object sender, EventArgs e)
        {
            if (new ClientManagerModel().BlockCard(dgv_CardsInfo.SelectedRows[0].Cells[0].Value.ToString()))
            {
                MessageBox.Show("Card successfully blocked");
                LoadCardInfoGridView(IBAN);
            }
            else
            {
                MessageBox.Show("Something went wrong, card remains unblocked");
            }
        }

        private void btn_UnblockCard_Click(object sender, EventArgs e)
        {
            if (new ClientManagerModel().UnblockCard(dgv_CardsInfo.SelectedRows[0].Cells[0].Value.ToString()))
            {
                MessageBox.Show("Card successfully unblocked");
                LoadCardInfoGridView(IBAN);
            }
            else
            {
                MessageBox.Show("Something went wrong, card remains blocked");
            }
        }

        private void btn_UpdateClientInfo_Click(object sender, EventArgs e)
        {
            using (NewAccountView newForm = new NewAccountView(personalID))
            {
                newForm.ShowDialog();
                LoadClientInfoGridViews();
            }
        }

        private void btn_AllTransactions_Click(object sender, EventArgs e)
        {
            using (AllTransactionsView newForm = new AllTransactionsView(IBAN))
            {
                newForm.ShowDialog();
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            LoadClientInfoGridViews();
        }

        private void btn_Withdraw_Click(object sender, EventArgs e)
        {
            using (WithdrawView newForm = new WithdrawView(dgv_ClientInfo.SelectedRows[0].Cells[4].Value.ToString()))
            {
                MessageBox.Show(dgv_ClientInfo.SelectedRows[0].Cells[4].Value.ToString());
                newForm.ShowDialog();
                LoadClientInfoGridViews();
            }
        }

        private void btn_Deposit_Click(object sender, EventArgs e)
        {
            using (DepositView newForm = new DepositView(dgv_ClientInfo.SelectedRows[0].Cells[4].Value.ToString()))
            {
                MessageBox.Show(dgv_ClientInfo.SelectedRows[0].Cells[4].Value.ToString());
                newForm.ShowDialog();
                LoadClientInfoGridViews();
            }

        }

        private void btn_NewTransaction_Click(object sender, EventArgs e)
        {
            List<string> senderData = new List<string>();
            senderData.Add(dgv_ClientInfo.SelectedRows[0].Cells[0].Value.ToString());
            senderData.Add(dgv_ClientInfo.SelectedRows[0].Cells[1].Value.ToString());
            senderData.Add(dgv_ClientInfo.SelectedRows[0].Cells[4].Value.ToString());
            senderData.Add(dgv_ClientInfo.SelectedRows[0].Cells[5].Value.ToString());

            using (NewTransactionView newForm = new NewTransactionView(senderData))
            {
                newForm.ShowDialog();
            }
        }

















        //private void cmdUpdate_Click(object sender, EventArgs e)
        //{
        //    using (NewAccountView newForm = new NewAccountView(42))
        //    {
        //        newForm.ShowDialog();
        //    }
        //}

        //private void cmdDeposit_Click(object sender, EventArgs e)
        //{
        //    using (frmTransaction newForm = new frmTransaction())
        //    {
        //        newForm.ShowDialog();
        //    }
        //}

        //private void cmdWithdrawal_Click(object sender, EventArgs e)
        //{
        //    using (frmTransaction newForm = new frmTransaction())
        //    {
        //        newForm.ShowDialog();
        //    }
        //}

        //private void cmdAllTransactions_Click(object sender, EventArgs e)
        //{
        //    using (frmTransactions newForm = new frmTransactions(42))
        //    {
        //        newForm.ShowDialog();
        //    }
        //}

        //private void cmdNewTransaction_Click(object sender, EventArgs e)
        //{
        //    using (frmTransaction newForm = new frmTransaction())
        //    {
        //        newForm.ShowDialog();
        //    }
        //}

        //private void cmdCloseAccount_Click(object sender, EventArgs e)
        //{
        //    if (MessageBox.Show("Hodor?", "Hodor!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
        //    {
        //        DialogResult = DialogResult.OK;
        //    }
        //}


    }
}
