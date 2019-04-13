namespace BankSystem
{
    partial class ClientManagerView
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
            this.btn_UpdateClientInfo = new System.Windows.Forms.Button();
            this.btn_NewTransaction = new System.Windows.Forms.Button();
            this.btn_CloseAccount = new System.Windows.Forms.Button();
            this.btn_AllTransactions = new System.Windows.Forms.Button();
            this.btn_Withdraw = new System.Windows.Forms.Button();
            this.btn_Deposit = new System.Windows.Forms.Button();
            this.btn_AddCard = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_BlockCard = new System.Windows.Forms.Button();
            this.btn_UnblockCard = new System.Windows.Forms.Button();
            this.dgv_ClientInfo = new System.Windows.Forms.DataGridView();
            this.Column_FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_PersonalID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_DateOfBirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_IBAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Debit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_CardsInfo = new System.Windows.Forms.DataGridView();
            this.btn_ResetPin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ClientInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CardsInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_UpdateClientInfo
            // 
            this.btn_UpdateClientInfo.Location = new System.Drawing.Point(12, 119);
            this.btn_UpdateClientInfo.Name = "btn_UpdateClientInfo";
            this.btn_UpdateClientInfo.Size = new System.Drawing.Size(112, 23);
            this.btn_UpdateClientInfo.TabIndex = 4;
            this.btn_UpdateClientInfo.Text = "Update Client Info";
            this.btn_UpdateClientInfo.UseVisualStyleBackColor = true;
            this.btn_UpdateClientInfo.Click += new System.EventHandler(this.btn_UpdateClientInfo_Click);
            // 
            // btn_NewTransaction
            // 
            this.btn_NewTransaction.Location = new System.Drawing.Point(12, 306);
            this.btn_NewTransaction.Name = "btn_NewTransaction";
            this.btn_NewTransaction.Size = new System.Drawing.Size(112, 23);
            this.btn_NewTransaction.TabIndex = 5;
            this.btn_NewTransaction.Text = "New transaction";
            this.btn_NewTransaction.UseVisualStyleBackColor = true;
            // 
            // btn_CloseAccount
            // 
            this.btn_CloseAccount.Location = new System.Drawing.Point(12, 148);
            this.btn_CloseAccount.Name = "btn_CloseAccount";
            this.btn_CloseAccount.Size = new System.Drawing.Size(112, 23);
            this.btn_CloseAccount.TabIndex = 6;
            this.btn_CloseAccount.Text = "Close account";
            this.btn_CloseAccount.UseVisualStyleBackColor = true;
            // 
            // btn_AllTransactions
            // 
            this.btn_AllTransactions.Location = new System.Drawing.Point(12, 458);
            this.btn_AllTransactions.Name = "btn_AllTransactions";
            this.btn_AllTransactions.Size = new System.Drawing.Size(112, 23);
            this.btn_AllTransactions.TabIndex = 8;
            this.btn_AllTransactions.Text = "All transactions";
            this.btn_AllTransactions.UseVisualStyleBackColor = true;
            // 
            // btn_Withdraw
            // 
            this.btn_Withdraw.Location = new System.Drawing.Point(12, 364);
            this.btn_Withdraw.Name = "btn_Withdraw";
            this.btn_Withdraw.Size = new System.Drawing.Size(112, 23);
            this.btn_Withdraw.TabIndex = 9;
            this.btn_Withdraw.Text = "Withdraw";
            this.btn_Withdraw.UseVisualStyleBackColor = true;
            // 
            // btn_Deposit
            // 
            this.btn_Deposit.Location = new System.Drawing.Point(12, 335);
            this.btn_Deposit.Name = "btn_Deposit";
            this.btn_Deposit.Size = new System.Drawing.Size(112, 23);
            this.btn_Deposit.TabIndex = 10;
            this.btn_Deposit.Text = "Deposit";
            this.btn_Deposit.UseVisualStyleBackColor = true;
            // 
            // btn_AddCard
            // 
            this.btn_AddCard.Location = new System.Drawing.Point(746, 393);
            this.btn_AddCard.Name = "btn_AddCard";
            this.btn_AddCard.Size = new System.Drawing.Size(141, 25);
            this.btn_AddCard.TabIndex = 12;
            this.btn_AddCard.Text = "Add New Card";
            this.btn_AddCard.UseVisualStyleBackColor = true;
            this.btn_AddCard.Click += new System.EventHandler(this.btn_AddCard_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(162, 119);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(564, 362);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btn_BlockCard
            // 
            this.btn_BlockCard.Location = new System.Drawing.Point(746, 424);
            this.btn_BlockCard.Name = "btn_BlockCard";
            this.btn_BlockCard.Size = new System.Drawing.Size(141, 25);
            this.btn_BlockCard.TabIndex = 14;
            this.btn_BlockCard.Text = "Block Card";
            this.btn_BlockCard.UseVisualStyleBackColor = true;
            this.btn_BlockCard.Click += new System.EventHandler(this.btn_BlockCard_Click);
            // 
            // btn_UnblockCard
            // 
            this.btn_UnblockCard.Location = new System.Drawing.Point(893, 424);
            this.btn_UnblockCard.Name = "btn_UnblockCard";
            this.btn_UnblockCard.Size = new System.Drawing.Size(137, 25);
            this.btn_UnblockCard.TabIndex = 15;
            this.btn_UnblockCard.Text = "Unblock Card";
            this.btn_UnblockCard.UseVisualStyleBackColor = true;
            this.btn_UnblockCard.Click += new System.EventHandler(this.btn_UnblockCard_Click);
            // 
            // dgv_ClientInfo
            // 
            this.dgv_ClientInfo.AllowUserToAddRows = false;
            this.dgv_ClientInfo.AllowUserToDeleteRows = false;
            this.dgv_ClientInfo.AllowUserToResizeColumns = false;
            this.dgv_ClientInfo.AllowUserToResizeRows = false;
            this.dgv_ClientInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ClientInfo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dgv_ClientInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ClientInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_FirstName,
            this.Column_LastName,
            this.Column_PersonalID,
            this.Column_DateOfBirth,
            this.Column_IBAN,
            this.Column_Balance,
            this.Column_Debit});
            this.dgv_ClientInfo.Location = new System.Drawing.Point(12, 9);
            this.dgv_ClientInfo.Name = "dgv_ClientInfo";
            this.dgv_ClientInfo.ReadOnly = true;
            this.dgv_ClientInfo.RowHeadersVisible = false;
            this.dgv_ClientInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ClientInfo.Size = new System.Drawing.Size(714, 73);
            this.dgv_ClientInfo.TabIndex = 16;
            // 
            // Column_FirstName
            // 
            this.Column_FirstName.FillWeight = 80F;
            this.Column_FirstName.HeaderText = "First Name";
            this.Column_FirstName.Name = "Column_FirstName";
            this.Column_FirstName.ReadOnly = true;
            // 
            // Column_LastName
            // 
            this.Column_LastName.FillWeight = 80F;
            this.Column_LastName.HeaderText = "Last Name";
            this.Column_LastName.Name = "Column_LastName";
            this.Column_LastName.ReadOnly = true;
            // 
            // Column_PersonalID
            // 
            this.Column_PersonalID.FillWeight = 70F;
            this.Column_PersonalID.HeaderText = "ID Card";
            this.Column_PersonalID.Name = "Column_PersonalID";
            this.Column_PersonalID.ReadOnly = true;
            // 
            // Column_DateOfBirth
            // 
            this.Column_DateOfBirth.FillWeight = 90F;
            this.Column_DateOfBirth.HeaderText = "Date of Birth";
            this.Column_DateOfBirth.Name = "Column_DateOfBirth";
            this.Column_DateOfBirth.ReadOnly = true;
            // 
            // Column_IBAN
            // 
            this.Column_IBAN.FillWeight = 160F;
            this.Column_IBAN.HeaderText = "IBAN";
            this.Column_IBAN.Name = "Column_IBAN";
            this.Column_IBAN.ReadOnly = true;
            // 
            // Column_Balance
            // 
            this.Column_Balance.FillWeight = 90F;
            this.Column_Balance.HeaderText = "Balance";
            this.Column_Balance.Name = "Column_Balance";
            this.Column_Balance.ReadOnly = true;
            // 
            // Column_Debit
            // 
            this.Column_Debit.FillWeight = 90F;
            this.Column_Debit.HeaderText = "Debit Limit";
            this.Column_Debit.Name = "Column_Debit";
            this.Column_Debit.ReadOnly = true;
            // 
            // dgv_CardsInfo
            // 
            this.dgv_CardsInfo.AllowUserToAddRows = false;
            this.dgv_CardsInfo.AllowUserToDeleteRows = false;
            this.dgv_CardsInfo.AllowUserToResizeColumns = false;
            this.dgv_CardsInfo.AllowUserToResizeRows = false;
            this.dgv_CardsInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_CardsInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CardsInfo.Location = new System.Drawing.Point(746, 9);
            this.dgv_CardsInfo.Name = "dgv_CardsInfo";
            this.dgv_CardsInfo.ReadOnly = true;
            this.dgv_CardsInfo.RowHeadersVisible = false;
            this.dgv_CardsInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_CardsInfo.Size = new System.Drawing.Size(284, 378);
            this.dgv_CardsInfo.TabIndex = 17;
            // 
            // btn_ResetPin
            // 
            this.btn_ResetPin.Location = new System.Drawing.Point(893, 395);
            this.btn_ResetPin.Name = "btn_ResetPin";
            this.btn_ResetPin.Size = new System.Drawing.Size(137, 23);
            this.btn_ResetPin.TabIndex = 18;
            this.btn_ResetPin.Text = "Reset Pin";
            this.btn_ResetPin.UseVisualStyleBackColor = true;
            this.btn_ResetPin.Click += new System.EventHandler(this.btn_ResetPin_Click);
            // 
            // ClientManagerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 493);
            this.Controls.Add(this.btn_ResetPin);
            this.Controls.Add(this.dgv_CardsInfo);
            this.Controls.Add(this.dgv_ClientInfo);
            this.Controls.Add(this.btn_UnblockCard);
            this.Controls.Add(this.btn_BlockCard);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_AddCard);
            this.Controls.Add(this.btn_Deposit);
            this.Controls.Add(this.btn_Withdraw);
            this.Controls.Add(this.btn_AllTransactions);
            this.Controls.Add(this.btn_CloseAccount);
            this.Controls.Add(this.btn_NewTransaction);
            this.Controls.Add(this.btn_UpdateClientInfo);
            this.Name = "ClientManagerView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Client Manager";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ClientInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CardsInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_UpdateClientInfo;
        private System.Windows.Forms.Button btn_NewTransaction;
        private System.Windows.Forms.Button btn_CloseAccount;
        private System.Windows.Forms.Button btn_AllTransactions;
        private System.Windows.Forms.Button btn_Withdraw;
        private System.Windows.Forms.Button btn_Deposit;
        private System.Windows.Forms.Button btn_AddCard;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_BlockCard;
        private System.Windows.Forms.Button btn_UnblockCard;
        private System.Windows.Forms.DataGridView dgv_ClientInfo;
        private System.Windows.Forms.DataGridView dgv_CardsInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_PersonalID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_DateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_IBAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Balance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Debit;
        private System.Windows.Forms.Button btn_ResetPin;
    }
}