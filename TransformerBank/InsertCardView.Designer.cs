namespace TransformerBank
{
    partial class InsertCardView
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
            this.btn_OK = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.ntb_CardNumber = new Controls.NumericTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please Type In Your Card Number";
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(12, 141);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 2;
            this.btn_OK.Text = "Confirm";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(12, 170);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 3;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // ntb_CardNumber
            // 
            this.ntb_CardNumber.Location = new System.Drawing.Point(45, 67);
            this.ntb_CardNumber.Name = "ntb_CardNumber";
            this.ntb_CardNumber.Size = new System.Drawing.Size(208, 20);
            this.ntb_CardNumber.TabIndex = 4;
            // 
            // InsertCardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 205);
            this.Controls.Add(this.ntb_CardNumber);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.label1);
            this.Name = "InsertCardView";
            this.Text = "Insert Your Card";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button Cancel;
        private Controls.NumericTextBox ntb_CardNumber;
    }
}