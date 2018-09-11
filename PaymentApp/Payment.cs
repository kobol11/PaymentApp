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
    public partial class frmPayment : Form
    {
        public frmPayment()
        {
            InitializeComponent();
        }

        private void frmPayment_Load(object sender, EventArgs e)
        {
            lstCreditCardType.Items.Add("Visa");
            lstCreditCardType.Items.Add("Master Card");
            lstCreditCardType.Items.Add("American Express");
            lstCreditCardType.SelectedIndex = 0;

            string[] months = {"Select a month...", "January", "Februaury", "March", "April", "May",
                                "June", "July", "August", "September", "October", "November", "December"};
            foreach (string month in months)
            {
                cboExpirationMonth.Items.Add(month);
            }
            cboExpirationMonth.SelectedIndex = -1;

            int year = DateTime.Now.Year;
            int endYear = year + 8;
            cboExpirationYear.Items.Add("Select a year...");
            while (year < endYear)
            {
                cboExpirationYear.Items.Add(year);
                year++;
            }
            {
                cboExpirationYear.SelectedIndex = 0;

            }

        }

        private void SaveData()
        {
            string msg = null;

            if (rdoCreditCard.Checked)
            {
                msg += "Charge to credit card.\n\n";
                msg += "Card type: " + lstCreditCardType.SelectedItem.ToString() + "\n";
                msg += "Card number: " + txtCardNumber.Text + "\n";
                msg += "Expiration date: " + cboExpirationMonth.Text + "\n" +
                        cboExpirationYear.SelectedItem.ToString() + "\n";
            }
            else
            {
                msg += "Send bill to customer." + "\n\n";
            }

            bool isDefaultBilling = chkDefault.Checked;
            msg += "Default billing: " + isDefaultBilling;

            this.Tag = msg;
            this.DialogResult = DialogResult.OK;
        }

        private bool IsValidData()
        {
            if (rdoCreditCard.Checked)
            {
                if(lstCreditCardType.SelectedIndex == -1)
                {
                    MessageBox.Show("You must select a credit card type.", "Entry Error");
                    lstCreditCardType.Focus();
                    return false;
                }
                if(txtCardNumber.Text == "")
                {
                    MessageBox.Show("You must enter a credit card number", "Entry Error");
                    txtCardNumber.Focus();
                    return false;
                }
                if(cboExpirationMonth.SelectedIndex == 0)
                {
                    MessageBox.Show("You must select a month", "Entry Error");
                    cboExpirationMonth.Focus();
                    return false;
                }
                if(cboExpirationYear.SelectedIndex == 0)
                {
                    MessageBox.Show("You must select a year", "Entry Error");
                    cboExpirationYear.Focus();
                    return false;
                }
            }

            return true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                this.SaveData();
            }
        }

        private void ToggleControls(bool action)
        {
            lstCreditCardType.Enabled = action;
            txtCardNumber.Enabled = action;
            cboExpirationMonth.Enabled = action;
            cboExpirationYear.Enabled = action;
        }

        private void Billing_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCreditCard.Checked)
                ToggleControls(true);
            else
                ToggleControls(false);
        }
    }
}
