﻿using System;
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
    public partial class DepositView : Form
    {

        string currentAccountID;

        public DepositView(string accountID)
        {
            InitializeComponent();
            currentAccountID = accountID;
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            if (new DepositModel().Deposit(Convert.ToDecimal(ntb_Amount.Text), currentAccountID))
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
    }
}
