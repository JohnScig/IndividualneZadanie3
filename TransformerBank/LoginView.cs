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
        //private LoginViewModel mainViewModel = new LoginViewModel();

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            
            if (new LoginViewModel().CheckLoginInfo(ntb_CardNumber.Text, ntb_Pin.Text))
            {
                MessageBox.Show("success");
                new MainMenuView(ntb_CardNumber.Text).ShowDialog();
                ntb_CardNumber.Text = String.Empty;
                ntb_Pin.Text = String.Empty;
            }
            else
            {
                MessageBox.Show("failure. Possible issues - card blocked, invalid card or wrong pin");
            }
        }
    }
}
