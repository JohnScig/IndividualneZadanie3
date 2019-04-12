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
    public partial class MainMenuView : Form
    {
        //public MainMenuView()
        //{
        //    InitializeComponent();
        //}

        string currentCardNumber;
        

        public MainMenuView(string cardNumber)
        {
            InitializeComponent();
            currentCardNumber = cardNumber;
            ntb_CurrentCardNumber.Text = currentCardNumber;
            
        }

        private void btn_CheckBalance_Click(object sender, EventArgs e)
        {
            MessageBox.Show(new MainMenuModel().CheckBalance(currentCardNumber).ToString());
        }

        private void btn_Withdraw_Click(object sender, EventArgs e)
        {
            new WithdrawView(currentCardNumber).ShowDialog();
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }




    }
}
