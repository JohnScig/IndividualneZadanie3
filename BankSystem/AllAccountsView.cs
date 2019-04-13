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
    public partial class AllAccountsView : Form
    {
        public AllAccountsView()
        {
            InitializeComponent();
            LoadAllAccounts();
        }

        public void LoadAllAccounts()
        {
            dgv_AllAccounts.DataSource = new AllAccountsModel().GetAllAccounts();
            dgv_AllAccounts.DataMember = "AllAccounts";
            dgv_AllAccounts.Columns[2].FillWeight = 200;
        }

        private void cmdManageAccount_Click(object sender, EventArgs e)
        {
            //using (ClientManagerView newForm = new ClientManagerView())
            //{
            //    newForm.ShowDialog();
            //}
        }
    }
}
