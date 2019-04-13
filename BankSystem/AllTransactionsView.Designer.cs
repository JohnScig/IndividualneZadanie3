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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AllTransactions)).BeginInit();
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
            this.dgv_AllTransactions.Size = new System.Drawing.Size(1161, 337);
            this.dgv_AllTransactions.TabIndex = 0;
            // 
            // AllTransactionsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 361);
            this.Controls.Add(this.dgv_AllTransactions);
            this.Name = "AllTransactionsView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTransactions";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AllTransactions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_AllTransactions;
    }
}