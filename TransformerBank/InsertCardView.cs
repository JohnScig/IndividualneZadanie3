using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransformerBank
{
    public partial class InsertCardView : Form
    {
        TextBox textBox;


        public InsertCardView(TextBox textBox)
        {
            InitializeComponent();
            this.textBox = textBox;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            textBox.Text = ntb_CardNumber.Text;
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
