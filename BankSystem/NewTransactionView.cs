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
    public partial class NewTransactionView : Form
    {
        public NewTransactionView(List<string> senderData)
        {
            InitializeComponent();
            LoadLabels(senderData);
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            if (new NewTransactionModel().TransferMoney(lbl_IBAN.Text, tb_IBAN.Text, Convert.ToDecimal(ntb_Amount.Text), ntb_Variable.Text, ntb_Specific.Text, ntb_Constant.Text, tb_Message.Text))

            {
                MessageBox.Show("success");
                this.Close();
            }
            else
            {
                MessageBox.Show("fail");
            }
        }


        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LoadLabels(List<string> senderData)
        {
            lbl_FirstName.Text = senderData[0];
            lbl_LastName.Text = senderData[1];
            lbl_IBAN.Text = senderData[2];
            lbl_Balance.Text = senderData[3];

        }

    }
}
