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
    public partial class AdjustDebitView : Form
    {
        string iban;
        public AdjustDebitView(string iban, decimal currentDebitLimit)
        {
            InitializeComponent();
            ntb_CurrentDebitLimit.Text = currentDebitLimit.ToString();
            this.iban = iban;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (ntb_NewDebitLimit.Text == String.Empty  || ntb_NewDebitLimit.Text == ntb_CurrentDebitLimit.Text )
            {
                this.Close();
            }
            else
            {
                if (new AdjustDebitModel().AdjustDebit(iban, Convert.ToDecimal(ntb_NewDebitLimit.Text)))
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("An error has occured. The Debit Limit has not been changed!");
                }
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
