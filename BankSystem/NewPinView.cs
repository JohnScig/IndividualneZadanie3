using Data;
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
    public partial class NewPinView : Form
    {
        private string accountID;

        private string cardNumber = string.Empty;

        public NewPinView(string accountID)
        {
            InitializeComponent();
            this.accountID = accountID;
        }

        public NewPinView(string accountID, string cardNumber)
        {
            InitializeComponent();
            this.accountID = accountID;
            this.cardNumber = cardNumber;
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            if (InputChecker.PinChecker(ntb_NewPin.Text))
            {
                if (cardNumber == string.Empty)
                {
                    AddNewCard();
                    this.Close();
                }
                else
                {
                    ResetPin();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("You have entered a wrong PIN. It has to be a 4-digit number");

            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void AddNewCard()
        {
            if (new NewPinModel().AddCard(ntb_NewPin.Text, accountID))
            {
                MessageBox.Show("A new card was successfully added");
            }
            else
            {
                MessageBox.Show("Something went wrong, a new card was not added");
            }
        }

        public void ResetPin()
        {
            if (new NewPinModel().NewPin(ntb_NewPin.Text, cardNumber))
            {
                MessageBox.Show("Your new pin has been set to your card");
            }
            else
            {
                MessageBox.Show("Something went wrong, a new card was not added");
            }
        }
    }
}
