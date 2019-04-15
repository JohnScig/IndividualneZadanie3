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
            dgv_AllAccounts.Columns[3].FillWeight = 200;
        }

        public void LoadFilteredAccounts(List<string> filterCriteria)
        {
            dgv_AllAccounts.DataSource = new AllAccountsModel().GetFilteredAccounts(filterCriteria);
            dgv_AllAccounts.DataMember = "FilteredAccounts";
            dgv_AllAccounts.Columns[3].FillWeight = 200;
        }


        private void btn_ManageAccount_Click(object sender, EventArgs e)
        {
            using (ClientManagerView newForm = new ClientManagerView(dgv_AllAccounts.SelectedRows[0].Cells[2].Value.ToString()))
            {
                newForm.ShowDialog();
            }
            LoadAllAccounts();
        }

        private void btn_RemoveFilters_Click(object sender, EventArgs e)
        {
            tb_LastName.Text = String.Empty;
            tb_FirstName.Text = String.Empty;
            tb_PersonalID.Text = String.Empty;
            rb_All.Checked = true;
            tb_EarliestDate.Text = String.Empty;
            tb_LatestDate.Text = String.Empty;

            LoadAllAccounts();
        }

        private void btn_Filter_Click(object sender, EventArgs e)
        {

            string accountStatus = "all";
            if (rb_Open.Checked == true)
            {
                accountStatus = "open";
            }
            if (rb_Closed.Checked == true)
            {
                accountStatus = "closed";
            }
            List<string> filterCriteria = new List<string>() { tb_LastName.Text, tb_FirstName.Text, tb_PersonalID.Text, tb_Iban.Text, accountStatus, tb_EarliestDate.Text, tb_LatestDate.Text };
            //filterCriteria = [tb_LastName.Text,tb_FirstName.Text,tb_Iban.Text,chb_IncludeClosed.Checked.ToString(),tb_EarliestDate.Text,tb_LatestDate.Text];
            LoadFilteredAccounts(filterCriteria);
        }
    }
}
