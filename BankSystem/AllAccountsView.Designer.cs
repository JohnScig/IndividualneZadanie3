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
            this.label3 = new System.Windows.Forms.Label();
            this.cmdManageAccount = new System.Windows.Forms.Button();
            this.dgv_AllAccounts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AllAccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(895, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 271);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tu bude filter na vyhľadávanie klienta/účtu";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmdManageAccount
            // 
            this.cmdManageAccount.Location = new System.Drawing.Point(12, 289);
            this.cmdManageAccount.Name = "cmdManageAccount";
            this.cmdManageAccount.Size = new System.Drawing.Size(75, 37);
            this.cmdManageAccount.TabIndex = 10;
            this.cmdManageAccount.Text = "Manage account";
            this.cmdManageAccount.UseVisualStyleBackColor = true;
            this.cmdManageAccount.Click += new System.EventHandler(this.cmdManageAccount_Click);
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
            this.dgv_AllAccounts.Size = new System.Drawing.Size(877, 271);
            this.dgv_AllAccounts.TabIndex = 12;
            // 
            // AllAccountsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 427);
            this.Controls.Add(this.dgv_AllAccounts);
            this.Controls.Add(this.cmdManageAccount);
            this.Controls.Add(this.label3);
            this.Name = "AllAccountsView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmClients";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AllAccounts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdManageAccount;
        private System.Windows.Forms.DataGridView dgv_AllAccounts;
    }
}