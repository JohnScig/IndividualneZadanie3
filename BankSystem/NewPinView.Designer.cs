namespace BankSystem
{
    partial class NewPinView
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
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.lbl_NewPin = new System.Windows.Forms.Label();
            this.ntb_NewPin = new Controls.NumericTextBox();
            this.SuspendLayout();
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Location = new System.Drawing.Point(235, 180);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(75, 23);
            this.btn_Confirm.TabIndex = 0;
            this.btn_Confirm.Text = "Confirm";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(235, 212);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 1;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // lbl_NewPin
            // 
            this.lbl_NewPin.AutoSize = true;
            this.lbl_NewPin.Location = new System.Drawing.Point(84, 66);
            this.lbl_NewPin.Name = "lbl_NewPin";
            this.lbl_NewPin.Size = new System.Drawing.Size(146, 13);
            this.lbl_NewPin.TabIndex = 2;
            this.lbl_NewPin.Text = "Please Type In Your New Pin";
            // 
            // ntb_NewPin
            // 
            this.ntb_NewPin.Location = new System.Drawing.Point(108, 109);
            this.ntb_NewPin.MaxLength = 4;
            this.ntb_NewPin.Name = "ntb_NewPin";
            this.ntb_NewPin.Size = new System.Drawing.Size(100, 20);
            this.ntb_NewPin.TabIndex = 3;
            // 
            // NewPinView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 247);
            this.Controls.Add(this.ntb_NewPin);
            this.Controls.Add(this.lbl_NewPin);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Confirm);
            this.Name = "NewPinView";
            this.Text = "New Pin Code";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label lbl_NewPin;
        private Controls.NumericTextBox ntb_NewPin;
    }
}