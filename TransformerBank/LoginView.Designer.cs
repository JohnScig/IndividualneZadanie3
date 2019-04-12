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
            this.SuspendLayout();
            // 
            // ntb_CardNumber
            // 
            this.ntb_CardNumber.Location = new System.Drawing.Point(40, 42);
            this.ntb_CardNumber.Name = "ntb_CardNumber";
            this.ntb_CardNumber.Size = new System.Drawing.Size(299, 20);
            this.ntb_CardNumber.TabIndex = 0;
            // 
            // lbl_CardNumber
            // 
            this.lbl_CardNumber.AutoSize = true;
            this.lbl_CardNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_CardNumber.Location = new System.Drawing.Point(40, 24);
            this.lbl_CardNumber.Name = "lbl_CardNumber";
            this.lbl_CardNumber.Size = new System.Drawing.Size(198, 15);
            this.lbl_CardNumber.TabIndex = 1;
            this.lbl_CardNumber.Text = "Please Type In Your Bank Card Number";
            // 
            // ntb_Pin
            // 
            this.ntb_Pin.Location = new System.Drawing.Point(40, 111);
            this.ntb_Pin.Name = "ntb_Pin";
            this.ntb_Pin.Size = new System.Drawing.Size(100, 20);
            this.ntb_Pin.TabIndex = 2;
            // 
            // lbl_Pin
            // 
            this.lbl_Pin.AutoSize = true;
            this.lbl_Pin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Pin.Location = new System.Drawing.Point(40, 92);
            this.lbl_Pin.Name = "lbl_Pin";
            this.lbl_Pin.Size = new System.Drawing.Size(163, 15);
            this.lbl_Pin.TabIndex = 3;
            this.lbl_Pin.Text = "Please Type In Your Pin Number";
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Location = new System.Drawing.Point(264, 111);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(75, 23);
            this.btn_Confirm.TabIndex = 4;
            this.btn_Confirm.Text = "Confirm";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TransformerBank.Properties.Resources.bank_islam;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.lbl_Pin);
            this.Controls.Add(this.ntb_Pin);
            this.Controls.Add(this.lbl_CardNumber);
            this.Controls.Add(this.ntb_CardNumber);
            this.DoubleBuffered = true;
            this.Location = new System.Drawing.Point(100, 200);
            this.Name = "MainView";
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
    }
}

