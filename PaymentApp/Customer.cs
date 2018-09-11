using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaymentApp
{
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }

        bool isDataSaved = true;
        private void frmCustomer_Load(object sender, EventArgs e)
        {
            cbo_Names.Items.Add("Andrew Komolafe");
            cbo_Names.Items.Add("John Smith");
        }

        private void btn_Payment_Click(object sender, EventArgs e)
        {
            Form paymentForm = new frmPayment();
            DialogResult selectedButton = paymentForm.ShowDialog();

            if(selectedButton == DialogResult.OK)
            {
                lbl_Payment.Text = paymentForm.Tag.ToString();
            }
        }
    }
}
