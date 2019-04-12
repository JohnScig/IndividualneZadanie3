using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransformerBank
{
    public partial class WithdrawView : Form
    {
        //public WithdrawView()
        //{
        //    InitializeComponent();
        //}

        string currentCardNumber;
        public WithdrawView(string cardNumber)
        {
            InitializeComponent();
            currentCardNumber = cardNumber;
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            if (new WithdrawModel().Withdraw(Convert.ToDecimal(ntb_Amount.Text), currentCardNumber))
            {
                MessageBox.Show("success");
            }
            else
            {
                MessageBox.Show("fail");
            }
            this.Close();

            //MessageBox.Show(new MainMenuModel().Withdraw(amount).ToString() + " successfully withdrawn");
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}



//private void btn_Withdraw_Click(object sender, EventArgs e)
//{

//}