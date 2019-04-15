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
    public partial class LoginView : Form
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {


            if (new LoginViewModel().CheckLoginInfo(ntb_CardNumber.Text, ntb_Pin.Text))
            {
                MessageBox.Show("success");
                new MainMenuView(ntb_CardNumber.Text).ShowDialog();
                ntb_CardNumber.Text = String.Empty;
                ntb_Pin.Text = String.Empty;
                btn_InserCard.Enabled = true;
            }
            else
            {
                MessageBox.Show("You have entered the wrong pin.");
                int tries = new LoginViewModel().CheckTries(ntb_CardNumber.Text);
                if (tries > 4)
                {
                    MessageBox.Show("You have entered the wrong pin too many times. Your card is now blocked. Please contact your bank");
                }
                else if (tries > 0)
                {
                    MessageBox.Show($"You can enter your pin {5 - tries} more time(s).");
                }
                else
                {
                    MessageBox.Show("Something went wrong. Please contact the bank");
                }
            }
        }

        private void btn_InserCard_Click(object sender, EventArgs e)
        {
            new InsertCardView(ntb_CardNumber).ShowDialog();
            btn_InserCard.Enabled = false;

            if (new LoginViewModel().CheckBlockedCard(ntb_CardNumber.Text))
            {
                MessageBox.Show("Your card is currently blocked. Please contact your bank.");
                btn_Withdraw_Click(this, null);
            }

            new LoginViewModel().RemoveOldPinMistakes(ntb_CardNumber.Text);
        }

        private void btn_Withdraw_Click(object sender, EventArgs e)
        {
            ntb_CardNumber.Text = String.Empty;
            ntb_Pin.Text = String.Empty;
            btn_InserCard.Enabled = true;
        }
    }
}
