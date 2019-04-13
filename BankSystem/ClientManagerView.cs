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
            //Setup_dgvCardsInfo();
        }

        public void LoadClientInfoGridViews()
        {
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





















        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            using (NewAccountView newForm = new NewAccountView(42))
            {
                newForm.ShowDialog();
            }
        }

        private void cmdDeposit_Click(object sender, EventArgs e)
        {
            using (frmTransaction newForm = new frmTransaction())
            {
                newForm.ShowDialog();
            }
        }

        private void cmdWithdrawal_Click(object sender, EventArgs e)
        {
            using (frmTransaction newForm = new frmTransaction())
            {
                newForm.ShowDialog();
            }
        }

        private void cmdAllTransactions_Click(object sender, EventArgs e)
        {
            using (frmTransactions newForm = new frmTransactions(42))
            {
                newForm.ShowDialog();
            }
        }

        private void cmdNewTransaction_Click(object sender, EventArgs e)
        {
            using (frmTransaction newForm = new frmTransaction())
            {
                newForm.ShowDialog();
            }
        }

        private void cmdCloseAccount_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hodor?", "Hodor!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DialogResult = DialogResult.OK;
            }
        }


    }
}
