﻿using Data;
using Data.Models;
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
    public partial class NewAccountView : Form
    {

        private string personalID;
        private bool editing = false;
        ClientModel currentClient = new ClientModel();

        /// <summary>
        /// Used when adding new account.
        /// </summary>
        public NewAccountView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Used when viewing/updating existing account.
        /// </summary>
        /// <param name="clientId"></param>
        public NewAccountView(string personalID)
        {
            InitializeComponent();
            editing = true;
            this.personalID = personalID;
            PopulateTextBoxes(personalID);
        }



        private void btn_GenerateRandomPerson_Click(object sender, EventArgs e)
        {           
            currentClient = new NewAccountModel().GenerateRandomClient();

            tb_FirstName.Text = currentClient.FirstName;
            tb_LastName.Text = currentClient.LastName;
            tb_Year.Text = currentClient.DateOfBirth.Year.ToString();
            tb_Month.Text = currentClient.DateOfBirth.Month.ToString();
            tb_Day.Text = currentClient.DateOfBirth.Day.ToString();
            tb_PersonalID.Text = currentClient.PersonalID;
            tb_PhoneNumber.Text = currentClient.PhoneNumber;
            tb_Email.Text = currentClient.Email;
            tb_Street.Text = currentClient.Street;
            tb_City.Text = currentClient.City;
            tb_PostalCode.Text = currentClient.PostalCode;
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            currentClient.FirstName = tb_FirstName.Text;
            currentClient.LastName = tb_LastName.Text;
            currentClient.DateOfBirth = new DateTime(Convert.ToInt32(tb_Year.Text), Convert.ToInt32(tb_Month.Text), Convert.ToInt32(tb_Day.Text));
            currentClient.PersonalID = tb_PersonalID.Text;
            currentClient.PhoneNumber = tb_PhoneNumber.Text;
            currentClient.Email = tb_Email.Text;
            currentClient.Street = tb_Street.Text;
            currentClient.City = tb_City.Text;
            currentClient.PostalCode = tb_PostalCode.Text;


            if (editing)
            {
                if (new NewAccountModel().EditClient(personalID, currentClient))
                {
                    MessageBox.Show("Client was edited in the database!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Something went wrong. The programmer is probably an idiot");
                }
            }
            else
            {

                if (new NewAccountModel().CreateClientAndAccount(currentClient))
                {
                    MessageBox.Show("New client was created in the database!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Something went wrong. The programmer is probably an idiot");
                }
            }

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void PopulateTextBoxes(string personalID)
        {
            currentClient = new NewAccountModel().GetClient(personalID);

            tb_FirstName.Text = currentClient.FirstName;
            tb_LastName.Text = currentClient.LastName;
            tb_Year.Text = currentClient.DateOfBirth.Year.ToString();
            tb_Month.Text = currentClient.DateOfBirth.Month.ToString();
            tb_Day.Text = currentClient.DateOfBirth.Day.ToString();
            tb_PersonalID.Text = currentClient.PersonalID;
            tb_PhoneNumber.Text = currentClient.PhoneNumber;
            tb_Email.Text = currentClient.Email;
            tb_Street.Text = currentClient.Street;
            tb_City.Text = currentClient.City;
            tb_PostalCode.Text = currentClient.PostalCode;
        }
    }
}