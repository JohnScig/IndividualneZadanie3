namespace BankSystem
{
    partial class AllTransactionsView
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
            this.dgv_AllTransactions = new System.Windows.Forms.DataGridView();
            this.gb_TransactionType = new System.Windows.Forms.GroupBox();
            this.rb_Debit = new System.Windows.Forms.RadioButton();
            this.rb_Credit = new System.Windows.Forms.RadioButton();
            this.rb_All = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_LatestDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_EarliestDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_AccountNumber = new System.Windows.Forms.Label();
            this.tb_Iban = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_AmountLowPoint = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_AmountHighPoint = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Filter = new System.Windows.Forms.Button();
            this.btn_RemoveFilter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AllTransactions)).BeginInit();
            this.gb_TransactionType.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_AllTransactions
            // 
            this.dgv_AllTransactions.AllowUserToAddRows = false;
            this.dgv_AllTransactions.AllowUserToDeleteRows = false;
            this.dgv_AllTransactions.AllowUserToResizeColumns = false;
            this.dgv_AllTransactions.AllowUserToResizeRows = false;
            this.dgv_AllTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_AllTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AllTransactions.Location = new System.Drawing.Point(12, 12);
            this.dgv_AllTransactions.MultiSelect = false;
            this.dgv_AllTransactions.Name = "dgv_AllTransactions";
            this.dgv_AllTransactions.ReadOnly = true;
            this.dgv_AllTransactions.RowHeadersVisible = false;
            this.dgv_AllTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_AllTransactions.Size = new System.Drawing.Size(1021, 337);
            this.dgv_AllTransactions.TabIndex = 0;
            // 
            // gb_TransactionType
            // 
            this.gb_TransactionType.Controls.Add(this.rb_Debit);
            this.gb_TransactionType.Controls.Add(this.rb_Credit);
            this.gb_TransactionType.Controls.Add(this.rb_All);
            this.gb_TransactionType.Location = new System.Drawing.Point(12, 430);
            this.gb_TransactionType.Name = "gb_TransactionType";
            this.gb_TransactionType.Size = new System.Drawing.Size(246, 93);
            this.gb_TransactionType.TabIndex = 33;
            this.gb_TransactionType.TabStop = false;
            this.gb_TransactionType.Text = "Account Status";
            // 
            // rb_Debit
            // 
            this.rb_Debit.AutoSize = true;
            this.rb_Debit.Location = new System.Drawing.Point(27, 65);
            this.rb_Debit.Name = "rb_Debit";
            this.rb_Debit.Size = new System.Drawing.Size(183, 17);
            this.rb_Debit.TabIndex = 2;
            this.rb_Debit.Text = "Search For Debit Operations Only";
            this.rb_Debit.UseVisualStyleBackColor = true;
            // 
            // rb_Credit
            // 
            this.rb_Credit.AutoSize = true;
            this.rb_Credit.Location = new System.Drawing.Point(27, 42);
            this.rb_Credit.Name = "rb_Credit";
            this.rb_Credit.Size = new System.Drawing.Size(195, 17);
            this.rb_Credit.TabIndex = 1;
            this.rb_Credit.Text = "Search For Credit Transactions Only";
            this.rb_Credit.UseVisualStyleBackColor = true;
            // 
            // rb_All
            // 
            this.rb_All.AutoSize = true;
            this.rb_All.Checked = true;
            this.rb_All.Location = new System.Drawing.Point(27, 19);
            this.rb_All.Name = "rb_All";
            this.rb_All.Size = new System.Drawing.Size(155, 17);
            this.rb_All.TabIndex = 0;
            this.rb_All.TabStop = true;
            this.rb_All.Text = "Search For All Transactions";
            this.rb_All.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(644, 460);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Earlier Than";
            // 
            // tb_LatestDate
            // 
            this.tb_LatestDate.Location = new System.Drawing.Point(644, 479);
            this.tb_LatestDate.Name = "tb_LatestDate";
            this.tb_LatestDate.Size = new System.Drawing.Size(225, 20);
            this.tb_LatestDate.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(644, 406);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Later Than";
            // 
            // tb_EarliestDate
            // 
            this.tb_EarliestDate.Location = new System.Drawing.Point(644, 425);
            this.tb_EarliestDate.Name = "tb_EarliestDate";
            this.tb_EarliestDate.Size = new System.Drawing.Size(225, 20);
            this.tb_EarliestDate.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(620, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Filter by Transaction Timestamp";
            // 
            // lbl_AccountNumber
            // 
            this.lbl_AccountNumber.AutoSize = true;
            this.lbl_AccountNumber.Location = new System.Drawing.Point(9, 376);
            this.lbl_AccountNumber.Name = "lbl_AccountNumber";
            this.lbl_AccountNumber.Size = new System.Drawing.Size(95, 13);
            this.lbl_AccountNumber.TabIndex = 27;
            this.lbl_AccountNumber.Text = "Account ID (IBAN)";
            // 
            // tb_Iban
            // 
            this.tb_Iban.Location = new System.Drawing.Point(12, 392);
            this.tb_Iban.Name = "tb_Iban";
            this.tb_Iban.Size = new System.Drawing.Size(246, 20);
            this.tb_Iban.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Filter by Amount";
            // 
            // tb_AmountLowPoint
            // 
            this.tb_AmountLowPoint.Location = new System.Drawing.Point(334, 425);
            this.tb_AmountLowPoint.Name = "tb_AmountLowPoint";
            this.tb_AmountLowPoint.Size = new System.Drawing.Size(225, 20);
            this.tb_AmountLowPoint.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Amount Higher Than";
            // 
            // tb_AmountHighPoint
            // 
            this.tb_AmountHighPoint.Location = new System.Drawing.Point(334, 479);
            this.tb_AmountHighPoint.Name = "tb_AmountHighPoint";
            this.tb_AmountHighPoint.Size = new System.Drawing.Size(225, 20);
            this.tb_AmountHighPoint.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(334, 460);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Amount Lower Than";
            // 
            // btn_Filter
            // 
            this.btn_Filter.Location = new System.Drawing.Point(898, 448);
            this.btn_Filter.Name = "btn_Filter";
            this.btn_Filter.Size = new System.Drawing.Size(137, 23);
            this.btn_Filter.TabIndex = 34;
            this.btn_Filter.Text = "Filter";
            this.btn_Filter.UseVisualStyleBackColor = true;
            this.btn_Filter.Click += new System.EventHandler(this.btn_Filter_Click);
            // 
            // btn_RemoveFilter
            // 
            this.btn_RemoveFilter.Location = new System.Drawing.Point(896, 477);
            this.btn_RemoveFilter.Name = "btn_RemoveFilter";
            this.btn_RemoveFilter.Size = new System.Drawing.Size(137, 23);
            this.btn_RemoveFilter.TabIndex = 34;
            this.btn_RemoveFilter.Text = "Remove Filters";
            this.btn_RemoveFilter.UseVisualStyleBackColor = true;
            this.btn_RemoveFilter.Click += new System.EventHandler(this.btn_RemoveFilter_Click);
            // 
            // AllTransactionsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 546);
            this.Controls.Add(this.btn_RemoveFilter);
            this.Controls.Add(this.btn_Filter);
            this.Controls.Add(this.gb_TransactionType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_AmountHighPoint);
            this.Controls.Add(this.tb_LatestDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_AmountLowPoint);
            this.Controls.Add(this.tb_EarliestDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_AccountNumber);
            this.Controls.Add(this.tb_Iban);
            this.Controls.Add(this.dgv_AllTransactions);
            this.Name = "AllTransactionsView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTransactions";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AllTransactions)).EndInit();
            this.gb_TransactionType.ResumeLayout(false);
            this.gb_TransactionType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_AllTransactions;
        private System.Windows.Forms.GroupBox gb_TransactionType;
        private System.Windows.Forms.RadioButton rb_Debit;
        private System.Windows.Forms.RadioButton rb_Credit;
        private System.Windows.Forms.RadioButton rb_All;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_LatestDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_EarliestDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_AccountNumber;
        private System.Windows.Forms.TextBox tb_Iban;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_AmountLowPoint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_AmountHighPoint;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Filter;
        private System.Windows.Forms.Button btn_RemoveFilter;
    }
}