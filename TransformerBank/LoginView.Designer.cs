namespace TransformerBank
{
    partial class LoginView
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
            this.ntb_CardNumber = new Controls.NumericTextBox();
            this.lbl_CardNumber = new System.Windows.Forms.Label();
            this.ntb_Pin = new Controls.NumericTextBox();
            this.lbl_Pin = new System.Windows.Forms.Label();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.btn_InserCard = new System.Windows.Forms.Button();
            this.btn_Withdraw = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ntb_CardNumber
            // 
            this.ntb_CardNumber.Enabled = false;
            this.ntb_CardNumber.Location = new System.Drawing.Point(12, 27);
            this.ntb_CardNumber.Name = "ntb_CardNumber";
            this.ntb_CardNumber.Size = new System.Drawing.Size(299, 20);
            this.ntb_CardNumber.TabIndex = 0;
            this.ntb_CardNumber.TabStop = false;
            // 
            // lbl_CardNumber
            // 
            this.lbl_CardNumber.AutoSize = true;
            this.lbl_CardNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_CardNumber.Location = new System.Drawing.Point(12, 9);
            this.lbl_CardNumber.Name = "lbl_CardNumber";
            this.lbl_CardNumber.Size = new System.Drawing.Size(71, 15);
            this.lbl_CardNumber.TabIndex = 1;
            this.lbl_CardNumber.Text = "Card Number";
            // 
            // ntb_Pin
            // 
            this.ntb_Pin.Location = new System.Drawing.Point(12, 86);
            this.ntb_Pin.Name = "ntb_Pin";
            this.ntb_Pin.Size = new System.Drawing.Size(100, 20);
            this.ntb_Pin.TabIndex = 2;
            // 
            // lbl_Pin
            // 
            this.lbl_Pin.AutoSize = true;
            this.lbl_Pin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Pin.Location = new System.Drawing.Point(12, 67);
            this.lbl_Pin.Name = "lbl_Pin";
            this.lbl_Pin.Size = new System.Drawing.Size(163, 15);
            this.lbl_Pin.TabIndex = 3;
            this.lbl_Pin.Text = "Please Type In Your Pin Number";
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Location = new System.Drawing.Point(12, 297);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(152, 23);
            this.btn_Confirm.TabIndex = 3;
            this.btn_Confirm.Text = "Confirm";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // btn_InserCard
            // 
            this.btn_InserCard.Location = new System.Drawing.Point(297, 326);
            this.btn_InserCard.Name = "btn_InserCard";
            this.btn_InserCard.Size = new System.Drawing.Size(75, 23);
            this.btn_InserCard.TabIndex = 1;
            this.btn_InserCard.Text = "Insert Card";
            this.btn_InserCard.UseVisualStyleBackColor = true;
            this.btn_InserCard.Click += new System.EventHandler(this.btn_InserCard_Click);
            // 
            // btn_Withdraw
            // 
            this.btn_Withdraw.Location = new System.Drawing.Point(12, 326);
            this.btn_Withdraw.Name = "btn_Withdraw";
            this.btn_Withdraw.Size = new System.Drawing.Size(152, 23);
            this.btn_Withdraw.TabIndex = 4;
            this.btn_Withdraw.Text = "Cancel and Withdraw Card";
            this.btn_Withdraw.UseVisualStyleBackColor = true;
            this.btn_Withdraw.Click += new System.EventHandler(this.btn_Withdraw_Click);
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TransformerBank.Properties.Resources.bank_islam;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.btn_Withdraw);
            this.Controls.Add(this.btn_InserCard);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.lbl_Pin);
            this.Controls.Add(this.ntb_Pin);
            this.Controls.Add(this.lbl_CardNumber);
            this.Controls.Add(this.ntb_CardNumber);
            this.DoubleBuffered = true;
            this.Location = new System.Drawing.Point(100, 200);
            this.Name = "LoginView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ATM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.NumericTextBox ntb_CardNumber;
        private System.Windows.Forms.Label lbl_CardNumber;
        private Controls.NumericTextBox ntb_Pin;
        private System.Windows.Forms.Label lbl_Pin;
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.Button btn_InserCard;
        private System.Windows.Forms.Button btn_Withdraw;
    }
}

