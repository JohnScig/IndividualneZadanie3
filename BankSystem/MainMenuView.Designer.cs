namespace BankSystem
{
    partial class MainMenuView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_FindClient = new System.Windows.Forms.Button();
            this.cmdNewAccount = new System.Windows.Forms.Button();
            this.cmdAllAccounts = new System.Windows.Forms.Button();
            this.cmdAllTransactions = new System.Windows.Forms.Button();
            this.tb_PersonalID = new System.Windows.Forms.TextBox();
            this.btn_TopClients = new System.Windows.Forms.Button();
            this.btn_BankAssets = new System.Windows.Forms.Button();
            this.btn_NumberOfAccounts = new System.Windows.Forms.Button();
            this.btn_AverageAccountsPerPerson = new System.Windows.Forms.Button();
            this.btn_Demography = new System.Windows.Forms.Button();
            this.dgv_managerView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_managerView)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_FindClient
            // 
            this.btn_FindClient.Location = new System.Drawing.Point(786, 9);
            this.btn_FindClient.Name = "btn_FindClient";
            this.btn_FindClient.Size = new System.Drawing.Size(112, 20);
            this.btn_FindClient.TabIndex = 2;
            this.btn_FindClient.Text = "Find client";
            this.btn_FindClient.UseVisualStyleBackColor = true;
            this.btn_FindClient.Click += new System.EventHandler(this.btn_FindClient_Click);
            // 
            // cmdNewAccount
            // 
            this.cmdNewAccount.Location = new System.Drawing.Point(786, 49);
            this.cmdNewAccount.Name = "cmdNewAccount";
            this.cmdNewAccount.Size = new System.Drawing.Size(112, 23);
            this.cmdNewAccount.TabIndex = 3;
            this.cmdNewAccount.Text = "New account";
            this.cmdNewAccount.UseVisualStyleBackColor = true;
            this.cmdNewAccount.Click += new System.EventHandler(this.cmdNewAccount_Click);
            // 
            // cmdAllAccounts
            // 
            this.cmdAllAccounts.Location = new System.Drawing.Point(786, 93);
            this.cmdAllAccounts.Name = "cmdAllAccounts";
            this.cmdAllAccounts.Size = new System.Drawing.Size(112, 23);
            this.cmdAllAccounts.TabIndex = 4;
            this.cmdAllAccounts.Text = "All accounts";
            this.cmdAllAccounts.UseVisualStyleBackColor = true;
            this.cmdAllAccounts.Click += new System.EventHandler(this.cmdAllAccounts_Click);
            // 
            // cmdAllTransactions
            // 
            this.cmdAllTransactions.Location = new System.Drawing.Point(786, 138);
            this.cmdAllTransactions.Name = "cmdAllTransactions";
            this.cmdAllTransactions.Size = new System.Drawing.Size(112, 23);
            this.cmdAllTransactions.TabIndex = 5;
            this.cmdAllTransactions.Text = "All transactions";
            this.cmdAllTransactions.UseVisualStyleBackColor = true;
            this.cmdAllTransactions.Click += new System.EventHandler(this.cmdAllTransactions_Click);
            // 
            // tb_PersonalID
            // 
            this.tb_PersonalID.Location = new System.Drawing.Point(625, 11);
            this.tb_PersonalID.Margin = new System.Windows.Forms.Padding(2);
            this.tb_PersonalID.Name = "tb_PersonalID";
            this.tb_PersonalID.Size = new System.Drawing.Size(156, 20);
            this.tb_PersonalID.TabIndex = 10;
            this.tb_PersonalID.Text = "FM891023";
            this.tb_PersonalID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_TopClients
            // 
            this.btn_TopClients.Location = new System.Drawing.Point(502, 213);
            this.btn_TopClients.Name = "btn_TopClients";
            this.btn_TopClients.Size = new System.Drawing.Size(137, 23);
            this.btn_TopClients.TabIndex = 11;
            this.btn_TopClients.Text = "Top Clients";
            this.btn_TopClients.UseVisualStyleBackColor = true;
            this.btn_TopClients.Click += new System.EventHandler(this.btn_TopClients_Click);
            // 
            // btn_BankAssets
            // 
            this.btn_BankAssets.Location = new System.Drawing.Point(502, 242);
            this.btn_BankAssets.Name = "btn_BankAssets";
            this.btn_BankAssets.Size = new System.Drawing.Size(137, 23);
            this.btn_BankAssets.TabIndex = 11;
            this.btn_BankAssets.Text = "Bank Assets";
            this.btn_BankAssets.UseVisualStyleBackColor = true;
            this.btn_BankAssets.Click += new System.EventHandler(this.btn_BankAssets_Click);
            // 
            // btn_NumberOfAccounts
            // 
            this.btn_NumberOfAccounts.Location = new System.Drawing.Point(502, 271);
            this.btn_NumberOfAccounts.Name = "btn_NumberOfAccounts";
            this.btn_NumberOfAccounts.Size = new System.Drawing.Size(137, 23);
            this.btn_NumberOfAccounts.TabIndex = 11;
            this.btn_NumberOfAccounts.Text = "Number Of Accounts";
            this.btn_NumberOfAccounts.UseVisualStyleBackColor = true;
            this.btn_NumberOfAccounts.Click += new System.EventHandler(this.btn_NumberOfAccounts_Click);
            // 
            // btn_AverageAccountsPerPerson
            // 
            this.btn_AverageAccountsPerPerson.Location = new System.Drawing.Point(502, 300);
            this.btn_AverageAccountsPerPerson.Name = "btn_AverageAccountsPerPerson";
            this.btn_AverageAccountsPerPerson.Size = new System.Drawing.Size(137, 23);
            this.btn_AverageAccountsPerPerson.TabIndex = 11;
            this.btn_AverageAccountsPerPerson.Text = "Accounts / Person";
            this.btn_AverageAccountsPerPerson.UseVisualStyleBackColor = true;
            this.btn_AverageAccountsPerPerson.Click += new System.EventHandler(this.btn_AverageAccountsPerPerson_Click);
            // 
            // btn_Demography
            // 
            this.btn_Demography.Location = new System.Drawing.Point(502, 329);
            this.btn_Demography.Name = "btn_Demography";
            this.btn_Demography.Size = new System.Drawing.Size(137, 23);
            this.btn_Demography.TabIndex = 11;
            this.btn_Demography.Text = "Demography";
            this.btn_Demography.UseVisualStyleBackColor = true;
            this.btn_Demography.Click += new System.EventHandler(this.btn_Demography_Click);
            // 
            // dgv_managerView
            // 
            this.dgv_managerView.AllowUserToAddRows = false;
            this.dgv_managerView.AllowUserToDeleteRows = false;
            this.dgv_managerView.AllowUserToResizeColumns = false;
            this.dgv_managerView.AllowUserToResizeRows = false;
            this.dgv_managerView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_managerView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_managerView.Location = new System.Drawing.Point(12, 11);
            this.dgv_managerView.MultiSelect = false;
            this.dgv_managerView.Name = "dgv_managerView";
            this.dgv_managerView.ReadOnly = true;
            this.dgv_managerView.RowHeadersVisible = false;
            this.dgv_managerView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_managerView.Size = new System.Drawing.Size(484, 341);
            this.dgv_managerView.TabIndex = 12;
            // 
            // MainMenuView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 361);
            this.Controls.Add(this.dgv_managerView);
            this.Controls.Add(this.btn_Demography);
            this.Controls.Add(this.btn_AverageAccountsPerPerson);
            this.Controls.Add(this.btn_NumberOfAccounts);
            this.Controls.Add(this.btn_BankAssets);
            this.Controls.Add(this.btn_TopClients);
            this.Controls.Add(this.tb_PersonalID);
            this.Controls.Add(this.cmdAllTransactions);
            this.Controls.Add(this.cmdAllAccounts);
            this.Controls.Add(this.cmdNewAccount);
            this.Controls.Add(this.btn_FindClient);
            this.Location = new System.Drawing.Point(600, 200);
            this.Name = "MainMenuView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Transformer Bank System";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_managerView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_FindClient;
        private System.Windows.Forms.Button cmdNewAccount;
        private System.Windows.Forms.Button cmdAllAccounts;
        private System.Windows.Forms.Button cmdAllTransactions;
        private System.Windows.Forms.TextBox tb_PersonalID;
        private System.Windows.Forms.Button btn_TopClients;
        private System.Windows.Forms.Button btn_BankAssets;
        private System.Windows.Forms.Button btn_NumberOfAccounts;
        private System.Windows.Forms.Button btn_AverageAccountsPerPerson;
        private System.Windows.Forms.Button btn_Demography;
        private System.Windows.Forms.DataGridView dgv_managerView;
    }
}

