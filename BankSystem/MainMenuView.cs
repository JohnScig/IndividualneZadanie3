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
                MessageBox.Show("client not found");
            }
        }

        private void cmdNewAccount_Click(object sender, EventArgs e)
        {
            using (NewClientView newForm = new NewClientView())
            {
                newForm.ShowDialog();
            }
        }

        private void cmdAllAccounts_Click(object sender, EventArgs e)
        {
            using (AllAccountsView newForm = new AllAccountsView())
            {
                newForm.ShowDialog();
            }
        }

        private void cmdAllTransactions_Click(object sender, EventArgs e)
        {
            using (AllTransactionsView newForm = new AllTransactionsView())
            {
                newForm.ShowDialog();
            }
        }

        private void btn_TopClients_Click(object sender, EventArgs e)
        {
            dgv_managerView.DataSource = new MainMenuModel().GetTopClients();
            dgv_managerView.DataMember = "TopClients";
        }

        private void btn_BankAssets_Click(object sender, EventArgs e)
        {
            dgv_managerView.DataSource = new MainMenuModel().GetBankAssets();
            dgv_managerView.DataMember = "BankAssets";
        }

        private void btn_NumberOfAccounts_Click(object sender, EventArgs e)
        {
            dgv_managerView.DataSource = new MainMenuModel().GetNumberOfAccounts();
            dgv_managerView.DataMember = "NumberOfAccounts";
        }

        private void btn_AverageAccountsPerPerson_Click(object sender, EventArgs e)
        {
            dgv_managerView.DataSource = new MainMenuModel().GetAverageAccountPerPerson();
            dgv_managerView.DataMember = "AverageAccountPerPerson";
        }

        private void btn_Demography_Click(object sender, EventArgs e)
        {
            dgv_managerView.DataSource = new MainMenuModel().GetDemography();
            dgv_managerView.DataMember = "Demography";
        }
    }
}
