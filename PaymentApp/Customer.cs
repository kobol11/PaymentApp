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

        private void SaveData()
        {
            cbo_Names.SelectedIndex = -1;
            lbl_Payment.Text = "";
            isDataSaved = true;
            cbo_Names.Focus();
        }

        private bool IsValidData()
        {
            if(cbo_Names.SelectedIndex == -1)
            {
                MessageBox.Show("You must select a customer", "Entry Error");
                cbo_Names.Focus();
                return false;
            }

            if(lbl_Payment.Text == "")
            {
                MessageBox.Show("You must enter a payment", "Entry Error");
                return false;
            }

            return true;
        }

        private void DataChanged(object sender, EventArgs e)
        {
            this.isDataSaved = false;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(isDataSaved == false)
            {
                string message = "This form contains unsaved data. \n\n" +
                    "Do you want to save it?";
                DialogResult button =
                    MessageBox.Show(message, "Customer", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1);

                if(button == DialogResult.Yes)
                {
                    if (IsValidData())
                    {
                        SaveData();
                    }
                    else
                    {
                        e.Cancel = true;
                    }
                }

                if (button == DialogResult.Cancel)
                    e.Cancel = true;
            }
        }
    }
}
