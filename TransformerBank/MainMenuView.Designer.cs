namespace TransformerBank
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
            this.ntb_CurrentCardNumber = new Controls.NumericTextBox();
            this.lbl_CurrentCardNumber = new System.Windows.Forms.Label();
            this.btn_CheckBalance = new System.Windows.Forms.Button();
            this.btn_Withdraw = new System.Windows.Forms.Button();
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ntb_CurrentCardNumber
            // 
            this.ntb_CurrentCardNumber.Enabled = false;
            this.ntb_CurrentCardNumber.Location = new System.Drawing.Point(46, 106);
            this.ntb_CurrentCardNumber.Name = "ntb_CurrentCardNumber";
            this.ntb_CurrentCardNumber.ReadOnly = true;
            this.ntb_CurrentCardNumber.Size = new System.Drawing.Size(246, 20);
            this.ntb_CurrentCardNumber.TabIndex = 0;
            // 
            // lbl_CurrentCardNumber
            // 
            this.lbl_CurrentCardNumber.AutoSize = true;
            this.lbl_CurrentCardNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_CurrentCardNumber.Location = new System.Drawing.Point(46, 87);
            this.lbl_CurrentCardNumber.Name = "lbl_CurrentCardNumber";
            this.lbl_CurrentCardNumber.Size = new System.Drawing.Size(108, 15);
            this.lbl_CurrentCardNumber.TabIndex = 1;
            this.lbl_CurrentCardNumber.Text = "Current Card Number";
            // 
            // btn_CheckBalance
            // 
            this.btn_CheckBalance.Location = new System.Drawing.Point(46, 160);
            this.btn_CheckBalance.Name = "btn_CheckBalance";
            this.btn_CheckBalance.Size = new System.Drawing.Size(152, 23);
            this.btn_CheckBalance.TabIndex = 1;
            this.btn_CheckBalance.Text = "Check Account Balance";
            this.btn_CheckBalance.UseVisualStyleBackColor = true;
            this.btn_CheckBalance.Click += new System.EventHandler(this.btn_CheckBalance_Click);
            // 
            // btn_Withdraw
            // 
            this.btn_Withdraw.Location = new System.Drawing.Point(46, 189);
            this.btn_Withdraw.Name = "btn_Withdraw";
            this.btn_Withdraw.Size = new System.Drawing.Size(152, 23);
            this.btn_Withdraw.TabIndex = 2;
            this.btn_Withdraw.Text = "Withdraw Money";
            this.btn_Withdraw.UseVisualStyleBackColor = true;
            this.btn_Withdraw.Click += new System.EventHandler(this.btn_Withdraw_Click);
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.Location = new System.Drawing.Point(46, 266);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(152, 23);
            this.btn_LogOut.TabIndex = 3;
            this.btn_LogOut.Text = "Log Out";
            this.btn_LogOut.UseVisualStyleBackColor = true;
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // MainMenuView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 340);
            this.Controls.Add(this.btn_LogOut);
            this.Controls.Add(this.btn_Withdraw);
            this.Controls.Add(this.btn_CheckBalance);
            this.Controls.Add(this.lbl_CurrentCardNumber);
            this.Controls.Add(this.ntb_CurrentCardNumber);
            this.Name = "MainMenuView";
            this.Text = "MainMenuView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.NumericTextBox ntb_CurrentCardNumber;
        private System.Windows.Forms.Label lbl_CurrentCardNumber;
        private System.Windows.Forms.Button btn_CheckBalance;
        private System.Windows.Forms.Button btn_Withdraw;
        private System.Windows.Forms.Button btn_LogOut;
    }
}