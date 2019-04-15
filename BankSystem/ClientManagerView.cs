using Data.Models;
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
        private string _iban;
        private List<Button> _blockableButtons = new List<Button>();


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
            _blockableButtons.Add(btn_AddCard);
            _blockableButtons.Add(btn_ResetPin);
            _blockableButtons.Add(btn_BlockCard);
            _blockableButtons.Add(btn_UnblockCard);
            _blockableButtons.Add(btn_CloseAccount);
            _blockableButtons.Add(btn_NewTransaction);
            _blockableButtons.Add(btn_Deposit);
            _blockableButtons.Add(btn_Withdraw);

            this.personalID = personalID;

            LoadClientInfo();
            LoadAccountsInfoGridView();


        }


        public void LoadAccountsInfoGridView()
        {
            dgv_AccountsInfo.Rows.Clear();
            List<AccountModel> accounts = new ClientManagerModel().GetAccounts(personalID);
            foreach (AccountModel account in accounts)
            {
                string isOpen = "open";
                if (account.CloseDate != DateTime.MinValue)
                {
                    isOpen = "Closed: " + account.CloseDate.ToString();
                }
                dgv_AccountsInfo.Rows.Add(account.IBAN, account.Balance.ToString(), account.DebtLimit.ToString(),isOpen);
            }
        }

        public void LoadClientInfo()
        {
            ClientManagerModel clientManagerModel = new ClientManagerModel();
            List<string> basicClientInfo = clientManagerModel.GetClientInfo(personalID);
            lbl_FirstName.Text = basicClientInfo[1];
            lbl_LastName.Text = basicClientInfo[2];
            lbl_PersonalID.Text = basicClientInfo[4];
            lbl_DateOfBirth.Text = basicClientInfo[3];

        }

        public void LoadCardInfoGridView(string _iban)
        {
            dgv_CardsInfo.DataSource = new ClientManagerModel().GetCardInfo(_iban);
            dgv_CardsInfo.DataMember = "Cards";
            dgv_CardsInfo.Columns[1].FillWeight = 60;
            dgv_CardsInfo.Columns[2].FillWeight = 50;
        }

        private void dgv_AccountsInfo_SelectionChanged(object sender, EventArgs e)
        {
            LoadCardInfoGridView(dgv_AccountsInfo.CurrentRow.Cells[0].Value.ToString());

            if (dgv_AccountsInfo.CurrentRow.Cells[3].Value.ToString().Equals("open"))
            {
                foreach (Button item in _blockableButtons)
                {
                    item.Enabled = true;
                }
            }
            else
            {
                foreach (Button item in _blockableButtons)
                {
                    item.Enabled = false;
                }
            }

            _iban = dgv_AccountsInfo.CurrentRow.Cells[0].Value.ToString();
        }

        private void btn_AddCard_Click(object sender, EventArgs e)
        {
            new NewPinView(_iban).ShowDialog();
            LoadCardInfoGridView(_iban);
        }

        private void btn_ResetPin_Click(object sender, EventArgs e)
        {
            new NewPinView(_iban,dgv_CardsInfo.SelectedRows[0].Cells[0].Value.ToString()).ShowDialog();
            LoadCardInfoGridView(_iban);
        }

        private void btn_BlockCard_Click(object sender, EventArgs e)
        {
            if (new ClientManagerModel().BlockCard(dgv_CardsInfo.SelectedRows[0].Cells[0].Value.ToString()))
            {
                MessageBox.Show("Card successfully blocked");
                LoadCardInfoGridView(_iban);
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
                LoadCardInfoGridView(_iban);
            }
            else
            {
                MessageBox.Show("Something went wrong, card remains blocked");
            }
        }

        private void btn_UpdateClientInfo_Click(object sender, EventArgs e)
        {
            using (NewClientView newForm = new NewClientView(personalID))
            {
                newForm.ShowDialog();
                LoadClientInfo();
            }
        }

        private void btn_AllTransactions_Click(object sender, EventArgs e)
        {
            using (AllTransactionsView newForm = new AllTransactionsView(_iban))
            {
                newForm.ShowDialog();
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            LoadAccountsInfoGridView();
            LoadClientInfo();
        }

        private void btn_Withdraw_Click(object sender, EventArgs e)
        {
            using (WithdrawView newForm = new WithdrawView(_iban))
            {
                //MessageBox.Show(dgv_AccountsInfo.CurrentRow.Cells[0].Value.ToString());
                newForm.ShowDialog();
                LoadAccountsInfoGridView();
            }
        }

        private void btn_Deposit_Click(object sender, EventArgs e)
        {
            using (DepositView newForm = new DepositView(_iban))
            {
                //MessageBox.Show(dgv_AccountsInfo.CurrentRow.Cells[0].Value.ToString());
                newForm.ShowDialog();
                LoadAccountsInfoGridView();
            }

        }

        private void btn_NewTransaction_Click(object sender, EventArgs e)
        {
            List<string> senderData = new List<string>();
            senderData.Add(lbl_FirstName.Text);
            senderData.Add(lbl_LastName.Text);
            senderData.Add(_iban);
            senderData.Add(dgv_AccountsInfo.CurrentRow.Cells[1].Value.ToString());

            using (NewTransactionView newForm = new NewTransactionView(senderData))
            {
                newForm.ShowDialog();
            }
            LoadAccountsInfoGridView();
        }

        private void btn_OpenNewAccount_Click(object sender, EventArgs e)
        {
            if (new ClientManagerModel().OpenNewAccount(personalID))
            {
                MessageBox.Show("New Account Open Successfully");
            }
            else
            {
                MessageBox.Show("A problem has occurred, no account created");
            }
            LoadAccountsInfoGridView();
        }

        private void btn_CloseAccount_Click(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(dgv_AccountsInfo.CurrentRow.Cells[1].Value) < 0)
            {
                MessageBox.Show("Account is in debt. It cannot be closed before the debt is paid.");
            }
            else if (Convert.ToDecimal(dgv_AccountsInfo.CurrentRow.Cells[1].Value) > 0)
            {
                MessageBox.Show("Account has money in it. It cannot be closed before the money is withdrawn or transfered to another account.");
            }
            else
            {
                if (new ClientManagerModel().CloseAccount(_iban))
                {
                    MessageBox.Show("Account has been closed successfully.");
                }
                else
                {
                    MessageBox.Show("A problem has occurred. Account remains open");
                }

            }

            LoadAccountsInfoGridView();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
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
