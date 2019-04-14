namespace BankSystem
{
    partial class AllAccountsView
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
            this.btn_ManageAccount = new System.Windows.Forms.Button();
            this.dgv_AllAccounts = new System.Windows.Forms.DataGridView();
            this.btn_Filter = new System.Windows.Forms.Button();
            this.lbl_AccountOwner = new System.Windows.Forms.Label();
            this.tb_FirstName = new System.Windows.Forms.TextBox();
            this.tb_LastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Iban = new System.Windows.Forms.TextBox();
            this.lbl_AccountNumber = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_EarliestDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_LatestDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_RemoveFilters = new System.Windows.Forms.Button();
            this.tb_PersonalID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_All = new System.Windows.Forms.RadioButton();
            this.rb_Open = new System.Windows.Forms.RadioButton();
            this.rb_Closed = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AllAccounts)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ManageAccount
            // 
            this.btn_ManageAccount.Location = new System.Drawing.Point(12, 555);
            this.btn_ManageAccount.Name = "btn_ManageAccount";
            this.btn_ManageAccount.Size = new System.Drawing.Size(113, 37);
            this.btn_ManageAccount.TabIndex = 10;
            this.btn_ManageAccount.Text = "Manage Selected Account";
            this.btn_ManageAccount.UseVisualStyleBackColor = true;
            this.btn_ManageAccount.Click += new System.EventHandler(this.btn_ManageAccount_Click);
            // 
            // dgv_AllAccounts
            // 
            this.dgv_AllAccounts.AllowUserToAddRows = false;
            this.dgv_AllAccounts.AllowUserToDeleteRows = false;
            this.dgv_AllAccounts.AllowUserToResizeColumns = false;
            this.dgv_AllAccounts.AllowUserToResizeRows = false;
            this.dgv_AllAccounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_AllAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AllAccounts.Location = new System.Drawing.Point(12, 12);
            this.dgv_AllAccounts.MultiSelect = false;
            this.dgv_AllAccounts.Name = "dgv_AllAccounts";
            this.dgv_AllAccounts.ReadOnly = true;
            this.dgv_AllAccounts.RowHeadersVisible = false;
            this.dgv_AllAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_AllAccounts.Size = new System.Drawing.Size(877, 507);
            this.dgv_AllAccounts.TabIndex = 12;
            // 
            // btn_Filter
            // 
            this.btn_Filter.Location = new System.Drawing.Point(898, 555);
            this.btn_Filter.Name = "btn_Filter";
            this.btn_Filter.Size = new System.Drawing.Size(133, 37);
            this.btn_Filter.TabIndex = 13;
            this.btn_Filter.Text = "Filter By Given Criteria";
            this.btn_Filter.UseVisualStyleBackColor = true;
            this.btn_Filter.Click += new System.EventHandler(this.btn_Filter_Click);
            // 
            // lbl_AccountOwner
            // 
            this.lbl_AccountOwner.AutoSize = true;
            this.lbl_AccountOwner.Location = new System.Drawing.Point(898, 12);
            this.lbl_AccountOwner.Name = "lbl_AccountOwner";
            this.lbl_AccountOwner.Size = new System.Drawing.Size(81, 13);
            this.lbl_AccountOwner.TabIndex = 14;
            this.lbl_AccountOwner.Text = "Account Owner";
            // 
            // tb_FirstName
            // 
            this.tb_FirstName.Location = new System.Drawing.Point(925, 61);
            this.tb_FirstName.Name = "tb_FirstName";
            this.tb_FirstName.Size = new System.Drawing.Size(225, 20);
            this.tb_FirstName.TabIndex = 15;
            // 
            // tb_LastName
            // 
            this.tb_LastName.Location = new System.Drawing.Point(925, 118);
            this.tb_LastName.Name = "tb_LastName";
            this.tb_LastName.Size = new System.Drawing.Size(225, 20);
            this.tb_LastName.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(925, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(925, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Last Name";
            // 
            // tb_Iban
            // 
            this.tb_Iban.Location = new System.Drawing.Point(901, 243);
            this.tb_Iban.Name = "tb_Iban";
            this.tb_Iban.Size = new System.Drawing.Size(246, 20);
            this.tb_Iban.TabIndex = 18;
            // 
            // lbl_AccountNumber
            // 
            this.lbl_AccountNumber.AutoSize = true;
            this.lbl_AccountNumber.Location = new System.Drawing.Point(898, 227);
            this.lbl_AccountNumber.Name = "lbl_AccountNumber";
            this.lbl_AccountNumber.Size = new System.Drawing.Size(95, 13);
            this.lbl_AccountNumber.TabIndex = 19;
            this.lbl_AccountNumber.Text = "Account ID (IBAN)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(898, 396);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Search for Accounts Created Within:";
            // 
            // tb_EarliestDate
            // 
            this.tb_EarliestDate.Location = new System.Drawing.Point(922, 445);
            this.tb_EarliestDate.Name = "tb_EarliestDate";
            this.tb_EarliestDate.Size = new System.Drawing.Size(225, 20);
            this.tb_EarliestDate.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(922, 426);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Earliest Date";
            // 
            // tb_LatestDate
            // 
            this.tb_LatestDate.Location = new System.Drawing.Point(922, 499);
            this.tb_LatestDate.Name = "tb_LatestDate";
            this.tb_LatestDate.Size = new System.Drawing.Size(225, 20);
            this.tb_LatestDate.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(922, 480);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Latest Date";
            // 
            // btn_RemoveFilters
            // 
            this.btn_RemoveFilters.Location = new System.Drawing.Point(1037, 555);
            this.btn_RemoveFilters.Name = "btn_RemoveFilters";
            this.btn_RemoveFilters.Size = new System.Drawing.Size(110, 37);
            this.btn_RemoveFilters.TabIndex = 24;
            this.btn_RemoveFilters.Text = "Remove Filters";
            this.btn_RemoveFilters.UseVisualStyleBackColor = true;
            this.btn_RemoveFilters.Click += new System.EventHandler(this.btn_RemoveFilters_Click);
            // 
            // tb_PersonalID
            // 
            this.tb_PersonalID.Location = new System.Drawing.Point(924, 175);
            this.tb_PersonalID.Name = "tb_PersonalID";
            this.tb_PersonalID.Size = new System.Drawing.Size(225, 20);
            this.tb_PersonalID.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(924, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "ID Card Number";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_Closed);
            this.groupBox1.Controls.Add(this.rb_Open);
            this.groupBox1.Controls.Add(this.rb_All);
            this.groupBox1.Location = new System.Drawing.Point(901, 281);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 93);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account Status";
            // 
            // rb_All
            // 
            this.rb_All.AutoSize = true;
            this.rb_All.Checked = true;
            this.rb_All.Location = new System.Drawing.Point(27, 19);
            this.rb_All.Name = "rb_All";
            this.rb_All.Size = new System.Drawing.Size(139, 17);
            this.rb_All.TabIndex = 0;
            this.rb_All.TabStop = true;
            this.rb_All.Text = "Search For All Accounts";
            this.rb_All.UseVisualStyleBackColor = true;
            // 
            // rb_Open
            // 
            this.rb_Open.AutoSize = true;
            this.rb_Open.Location = new System.Drawing.Point(27, 42);
            this.rb_Open.Name = "rb_Open";
            this.rb_Open.Size = new System.Drawing.Size(178, 17);
            this.rb_Open.TabIndex = 1;
            this.rb_Open.Text = "Search For Open Accounts Only";
            this.rb_Open.UseVisualStyleBackColor = true;
            // 
            // rb_Closed
            // 
            this.rb_Closed.AutoSize = true;
            this.rb_Closed.Location = new System.Drawing.Point(27, 65);
            this.rb_Closed.Name = "rb_Closed";
            this.rb_Closed.Size = new System.Drawing.Size(184, 17);
            this.rb_Closed.TabIndex = 2;
            this.rb_Closed.Text = "Search For Closed Accounts Only";
            this.rb_Closed.UseVisualStyleBackColor = true;
            // 
            // AllAccountsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 608);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_RemoveFilters);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_LatestDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_EarliestDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_AccountNumber);
            this.Controls.Add(this.tb_Iban);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_PersonalID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_LastName);
            this.Controls.Add(this.tb_FirstName);
            this.Controls.Add(this.lbl_AccountOwner);
            this.Controls.Add(this.btn_Filter);
            this.Controls.Add(this.dgv_AllAccounts);
            this.Controls.Add(this.btn_ManageAccount);
            this.Name = "AllAccountsView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmClients";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AllAccounts)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_ManageAccount;
        private System.Windows.Forms.DataGridView dgv_AllAccounts;
        private System.Windows.Forms.Button btn_Filter;
        private System.Windows.Forms.Label lbl_AccountOwner;
        private System.Windows.Forms.TextBox tb_FirstName;
        private System.Windows.Forms.TextBox tb_LastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Iban;
        private System.Windows.Forms.Label lbl_AccountNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_EarliestDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_LatestDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_RemoveFilters;
        private System.Windows.Forms.TextBox tb_PersonalID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_Closed;
        private System.Windows.Forms.RadioButton rb_Open;
        private System.Windows.Forms.RadioButton rb_All;
    }
}