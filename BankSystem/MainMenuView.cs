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
    public partial class MainMenuView : Form
    {
        public MainMenuView()
        {
            InitializeComponent();
        }

        private void btn_FindClient_Click(object sender, EventArgs e)
        {
            if (new MainMenuModel().CheckClientsExistence(tb_PersonalID.Text))
            {
                using (ClientManagerView newForm = new ClientManagerView(tb_PersonalID.Text))
                {
                    newForm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("client and account not found");
            }
        }

        private void cmdNewAccount_Click(object sender, EventArgs e)
        {
            using (NewAccountView newForm = new NewAccountView())
            {
                newForm.ShowDialog();
            }
        }

        private void cmdAllAccounts_Click(object sender, EventArgs e)
        {
            using (frmAccounts newForm = new frmAccounts())
            {
                newForm.ShowDialog();
            }
        }

        private void cmdAllTransactions_Click(object sender, EventArgs e)
        {
            using (frmTransactions newForm = new frmTransactions())
            {
                newForm.ShowDialog();
            }
        }


    }
}
