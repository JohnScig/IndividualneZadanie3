namespace BankSystem
{
    partial class DepositView
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
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.ntb_Amount = new Controls.NumericTextBox();
            this.lbl_Command = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(122, 209);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(133, 23);
            this.btn_Cancel.TabIndex = 11;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Location = new System.Drawing.Point(122, 179);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(133, 23);
            this.btn_Confirm.TabIndex = 10;
            this.btn_Confirm.Text = "Confirm";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // ntb_Amount
            // 
            this.ntb_Amount.Location = new System.Drawing.Point(122, 107);
            this.ntb_Amount.Name = "ntb_Amount";
            this.ntb_Amount.Size = new System.Drawing.Size(216, 20);
            this.ntb_Amount.TabIndex = 9;
            // 
            // lbl_Command
            // 
            this.lbl_Command.AutoSize = true;
            this.lbl_Command.Location = new System.Drawing.Point(119, 91);
            this.lbl_Command.Name = "lbl_Command";
            this.lbl_Command.Size = new System.Drawing.Size(226, 13);
            this.lbl_Command.TabIndex = 8;
            this.lbl_Command.Text = "Please choose the amount you wish to deposit";
            // 
            // DepositView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 372);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.ntb_Amount);
            this.Controls.Add(this.lbl_Command);
            this.Name = "DepositView";
            this.Text = "DepositView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Confirm;
        private Controls.NumericTextBox ntb_Amount;
        private System.Windows.Forms.Label lbl_Command;
    }
}