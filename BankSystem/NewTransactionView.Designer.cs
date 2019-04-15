namespace BankSystem
{
    partial class NewTransactionView
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
            this.lbl_FirstName = new System.Windows.Forms.Label();
            this.lbl_LastName = new System.Windows.Forms.Label();
            this.lbl_IBAN = new System.Windows.Forms.Label();
            this.lbl_Balance = new System.Windows.Forms.Label();
            this.tb_IBAN = new System.Windows.Forms.TextBox();
            this.lbl_RecIBAN = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ntb_Amount = new Controls.NumericTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_Message = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.ntb_Variable = new Controls.NumericTextBox();
            this.ntb_Specific = new Controls.NumericTextBox();
            this.ntb_Constant = new Controls.NumericTextBox();
            this.SuspendLayout();
            // 
            // lbl_FirstName
            // 
            this.lbl_FirstName.AutoSize = true;
            this.lbl_FirstName.Location = new System.Drawing.Point(23, 33);
            this.lbl_FirstName.Name = "lbl_FirstName";
            this.lbl_FirstName.Size = new System.Drawing.Size(57, 13);
            this.lbl_FirstName.TabIndex = 8;
            this.lbl_FirstName.Text = "First Name";
            // 
            // lbl_LastName
            // 
            this.lbl_LastName.AutoSize = true;
            this.lbl_LastName.Location = new System.Drawing.Point(23, 64);
            this.lbl_LastName.Name = "lbl_LastName";
            this.lbl_LastName.Size = new System.Drawing.Size(58, 13);
            this.lbl_LastName.TabIndex = 9;
            this.lbl_LastName.Text = "Last Name";
            // 
            // lbl_IBAN
            // 
            this.lbl_IBAN.AutoSize = true;
            this.lbl_IBAN.Location = new System.Drawing.Point(23, 96);
            this.lbl_IBAN.Name = "lbl_IBAN";
            this.lbl_IBAN.Size = new System.Drawing.Size(32, 13);
            this.lbl_IBAN.TabIndex = 10;
            this.lbl_IBAN.Text = "IBAN";
            // 
            // lbl_Balance
            // 
            this.lbl_Balance.AutoSize = true;
            this.lbl_Balance.Location = new System.Drawing.Point(23, 128);
            this.lbl_Balance.Name = "lbl_Balance";
            this.lbl_Balance.Size = new System.Drawing.Size(46, 13);
            this.lbl_Balance.TabIndex = 11;
            this.lbl_Balance.Text = "Balance";
            // 
            // tb_IBAN
            // 
            this.tb_IBAN.Location = new System.Drawing.Point(371, 57);
            this.tb_IBAN.MaxLength = 34;
            this.tb_IBAN.Name = "tb_IBAN";
            this.tb_IBAN.Size = new System.Drawing.Size(308, 20);
            this.tb_IBAN.TabIndex = 1;
            // 
            // lbl_RecIBAN
            // 
            this.lbl_RecIBAN.AutoSize = true;
            this.lbl_RecIBAN.Location = new System.Drawing.Point(371, 32);
            this.lbl_RecIBAN.Name = "lbl_RecIBAN";
            this.lbl_RecIBAN.Size = new System.Drawing.Size(221, 13);
            this.lbl_RecIBAN.TabIndex = 13;
            this.lbl_RecIBAN.Text = "Please type in the Recipient\'s IBAN (required)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(368, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Please type in the amount to be transfered (required)";
            // 
            // ntb_Amount
            // 
            this.ntb_Amount.Location = new System.Drawing.Point(371, 121);
            this.ntb_Amount.MaxLength = 18;
            this.ntb_Amount.Name = "ntb_Amount";
            this.ntb_Amount.Size = new System.Drawing.Size(308, 20);
            this.ntb_Amount.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(368, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Variable Symbol";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(368, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Specific Symbol";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(368, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Constant Symbol";
            // 
            // tb_Message
            // 
            this.tb_Message.Location = new System.Drawing.Point(561, 191);
            this.tb_Message.MaxLength = 50;
            this.tb_Message.Multiline = true;
            this.tb_Message.Name = "tb_Message";
            this.tb_Message.Size = new System.Drawing.Size(161, 145);
            this.tb_Message.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(558, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Message (50 characters max)";
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Location = new System.Drawing.Point(12, 308);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(104, 23);
            this.btn_Confirm.TabIndex = 7;
            this.btn_Confirm.Text = "Confirm";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(12, 337);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(104, 23);
            this.btn_Cancel.TabIndex = 8;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // ntb_Variable
            // 
            this.ntb_Variable.Location = new System.Drawing.Point(368, 182);
            this.ntb_Variable.MaxLength = 3;
            this.ntb_Variable.Name = "ntb_Variable";
            this.ntb_Variable.Size = new System.Drawing.Size(100, 20);
            this.ntb_Variable.TabIndex = 14;
            this.ntb_Variable.Text = "0000000000";
            // 
            // ntb_Specific
            // 
            this.ntb_Specific.Location = new System.Drawing.Point(368, 238);
            this.ntb_Specific.MaxLength = 10;
            this.ntb_Specific.Name = "ntb_Specific";
            this.ntb_Specific.Size = new System.Drawing.Size(100, 20);
            this.ntb_Specific.TabIndex = 15;
            this.ntb_Specific.Text = "0000000000";
            // 
            // ntb_Constant
            // 
            this.ntb_Constant.Location = new System.Drawing.Point(368, 297);
            this.ntb_Constant.MaxLength = 4;
            this.ntb_Constant.Name = "ntb_Constant";
            this.ntb_Constant.Size = new System.Drawing.Size(72, 20);
            this.ntb_Constant.TabIndex = 16;
            this.ntb_Constant.Text = "0000";
            // 
            // NewTransactionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 372);
            this.Controls.Add(this.ntb_Constant);
            this.Controls.Add(this.ntb_Specific);
            this.Controls.Add(this.ntb_Variable);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.tb_Message);
            this.Controls.Add(this.ntb_Amount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_RecIBAN);
            this.Controls.Add(this.tb_IBAN);
            this.Controls.Add(this.lbl_Balance);
            this.Controls.Add(this.lbl_IBAN);
            this.Controls.Add(this.lbl_LastName);
            this.Controls.Add(this.lbl_FirstName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NewTransactionView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Transaction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_FirstName;
        private System.Windows.Forms.Label lbl_LastName;
        private System.Windows.Forms.Label lbl_IBAN;
        private System.Windows.Forms.Label lbl_Balance;
        private System.Windows.Forms.TextBox tb_IBAN;
        private System.Windows.Forms.Label lbl_RecIBAN;
        private System.Windows.Forms.Label label1;
        private Controls.NumericTextBox ntb_Amount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_Message;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.Button btn_Cancel;
        private Controls.NumericTextBox ntb_Variable;
        private Controls.NumericTextBox ntb_Specific;
        private Controls.NumericTextBox ntb_Constant;
    }
}