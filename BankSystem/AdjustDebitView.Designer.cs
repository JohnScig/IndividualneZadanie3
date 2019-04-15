namespace BankSystem
{
    partial class AdjustDebitView
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
            this.label1 = new System.Windows.Forms.Label();
            this.ntb_CurrentDebitLimit = new Controls.NumericTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ntb_NewDebitLimit = new Controls.NumericTextBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current Debit Limit";
            // 
            // ntb_CurrentDebitLimit
            // 
            this.ntb_CurrentDebitLimit.Enabled = false;
            this.ntb_CurrentDebitLimit.Location = new System.Drawing.Point(15, 25);
            this.ntb_CurrentDebitLimit.Name = "ntb_CurrentDebitLimit";
            this.ntb_CurrentDebitLimit.Size = new System.Drawing.Size(130, 20);
            this.ntb_CurrentDebitLimit.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "New Debit Limit";
            // 
            // ntb_NewDebitLimit
            // 
            this.ntb_NewDebitLimit.Location = new System.Drawing.Point(15, 85);
            this.ntb_NewDebitLimit.MaxLength = 15;
            this.ntb_NewDebitLimit.Name = "ntb_NewDebitLimit";
            this.ntb_NewDebitLimit.Size = new System.Drawing.Size(130, 20);
            this.ntb_NewDebitLimit.TabIndex = 2;
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(12, 196);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 3;
            this.btn_OK.Text = "Confirm";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(12, 225);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 4;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // AdjustDebitView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 260);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.ntb_NewDebitLimit);
            this.Controls.Add(this.ntb_CurrentDebitLimit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AdjustDebitView";
            this.Text = "Adjust Debit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Controls.NumericTextBox ntb_CurrentDebitLimit;
        private System.Windows.Forms.Label label2;
        private Controls.NumericTextBox ntb_NewDebitLimit;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
    }
}