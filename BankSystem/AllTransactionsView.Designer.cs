﻿namespace BankSystem
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
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Filter = new System.Windows.Forms.Button();
            this.btn_RemoveFilter = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.ntb_AmountLowPoint = new Controls.NumericTextBox();
            this.ntb_AmountHighPoint = new Controls.NumericTextBox();
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
            this.gb_TransactionType.Location = new System.Drawing.Point(176, 417);
            this.gb_TransactionType.Name = "gb_TransactionType";
            this.gb_TransactionType.Size = new System.Drawing.Size(246, 93);
            this.gb_TransactionType.TabIndex = 2;
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
            this.rb_Debit.CheckedChanged += new System.EventHandler(this.rb_Debit_CheckedChanged);
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
            this.rb_Credit.CheckedChanged += new System.EventHandler(this.rb_Credit_CheckedChanged);
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
            this.rb_All.CheckedChanged += new System.EventHandler(this.rb_All_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(808, 447);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Earlier Than";
            // 
            // tb_LatestDate
            // 
            this.tb_LatestDate.Location = new System.Drawing.Point(808, 466);
            this.tb_LatestDate.Name = "tb_LatestDate";
            this.tb_LatestDate.Size = new System.Drawing.Size(225, 20);
            this.tb_LatestDate.TabIndex = 6;
            this.tb_LatestDate.Leave += new System.EventHandler(this.tb_LatestDate_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(808, 393);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Later Than";
            // 
            // tb_EarliestDate
            // 
            this.tb_EarliestDate.Location = new System.Drawing.Point(808, 412);
            this.tb_EarliestDate.Name = "tb_EarliestDate";
            this.tb_EarliestDate.Size = new System.Drawing.Size(225, 20);
            this.tb_EarliestDate.TabIndex = 5;
            this.tb_EarliestDate.Leave += new System.EventHandler(this.tb_EarliestDate_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(784, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Filter by Transaction Timestamp";
            // 
            // lbl_AccountNumber
            // 
            this.lbl_AccountNumber.AutoSize = true;
            this.lbl_AccountNumber.Location = new System.Drawing.Point(173, 363);
            this.lbl_AccountNumber.Name = "lbl_AccountNumber";
            this.lbl_AccountNumber.Size = new System.Drawing.Size(95, 13);
            this.lbl_AccountNumber.TabIndex = 27;
            this.lbl_AccountNumber.Text = "Account ID (IBAN)";
            // 
            // tb_Iban
            // 
            this.tb_Iban.Location = new System.Drawing.Point(176, 379);
            this.tb_Iban.Name = "tb_Iban";
            this.tb_Iban.Size = new System.Drawing.Size(246, 20);
            this.tb_Iban.TabIndex = 1;
            this.tb_Iban.Leave += new System.EventHandler(this.tb_Iban_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(474, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Filter by Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(498, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Amount Higher Than";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(498, 447);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Amount Lower Than";
            // 
            // btn_Filter
            // 
            this.btn_Filter.Location = new System.Drawing.Point(749, 511);
            this.btn_Filter.Name = "btn_Filter";
            this.btn_Filter.Size = new System.Drawing.Size(139, 23);
            this.btn_Filter.TabIndex = 7;
            this.btn_Filter.Text = "Filter";
            this.btn_Filter.UseVisualStyleBackColor = true;
            this.btn_Filter.Click += new System.EventHandler(this.btn_Filter_Click);
            // 
            // btn_RemoveFilter
            // 
            this.btn_RemoveFilter.Location = new System.Drawing.Point(894, 511);
            this.btn_RemoveFilter.Name = "btn_RemoveFilter";
            this.btn_RemoveFilter.Size = new System.Drawing.Size(139, 23);
            this.btn_RemoveFilter.TabIndex = 8;
            this.btn_RemoveFilter.Text = "Remove Filters";
            this.btn_RemoveFilter.UseVisualStyleBackColor = true;
            this.btn_RemoveFilter.Click += new System.EventHandler(this.btn_RemoveFilter_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(12, 511);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 23);
            this.btn_Close.TabIndex = 9;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // ntb_AmountLowPoint
            // 
            this.ntb_AmountLowPoint.Location = new System.Drawing.Point(498, 410);
            this.ntb_AmountLowPoint.Name = "ntb_AmountLowPoint";
            this.ntb_AmountLowPoint.Size = new System.Drawing.Size(225, 20);
            this.ntb_AmountLowPoint.TabIndex = 33;
            this.ntb_AmountLowPoint.Leave += new System.EventHandler(this.ntb_AmountLowPoint_Leave);
            // 
            // ntb_AmountHighPoint
            // 
            this.ntb_AmountHighPoint.Location = new System.Drawing.Point(498, 464);
            this.ntb_AmountHighPoint.Name = "ntb_AmountHighPoint";
            this.ntb_AmountHighPoint.Size = new System.Drawing.Size(225, 20);
            this.ntb_AmountHighPoint.TabIndex = 34;
            this.ntb_AmountHighPoint.Leave += new System.EventHandler(this.ntb_AmountHighPoint_Leave);
            // 
            // AllTransactionsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 546);
            this.Controls.Add(this.ntb_AmountHighPoint);
            this.Controls.Add(this.ntb_AmountLowPoint);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_RemoveFilter);
            this.Controls.Add(this.btn_Filter);
            this.Controls.Add(this.gb_TransactionType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_LatestDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_EarliestDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_AccountNumber);
            this.Controls.Add(this.tb_Iban);
            this.Controls.Add(this.dgv_AllTransactions);
            this.Name = "AllTransactionsView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transactions Overview";
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Filter;
        private System.Windows.Forms.Button btn_RemoveFilter;
        private System.Windows.Forms.Button btn_Close;
        private Controls.NumericTextBox ntb_AmountLowPoint;
        private Controls.NumericTextBox ntb_AmountHighPoint;
    }
}