namespace PaymentApp
{
    partial class frmPayment
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoBillCustomer = new System.Windows.Forms.RadioButton();
            this.rdoCreditCard = new System.Windows.Forms.RadioButton();
            this.lblCreditCardType = new System.Windows.Forms.Label();
            this.lstCreditCardType = new System.Windows.Forms.ListBox();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.lblExpirationDate = new System.Windows.Forms.Label();
            this.cboExpirationMonth = new System.Windows.Forms.ComboBox();
            this.cboExpirationYear = new System.Windows.Forms.ComboBox();
            this.chkDefault = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoBillCustomer);
            this.groupBox1.Controls.Add(this.rdoCreditCard);
            this.groupBox1.Location = new System.Drawing.Point(18, 19);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(383, 81);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Billing";
            // 
            // rdoBillCustomer
            // 
            this.rdoBillCustomer.AutoSize = true;
            this.rdoBillCustomer.Location = new System.Drawing.Point(202, 24);
            this.rdoBillCustomer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoBillCustomer.Name = "rdoBillCustomer";
            this.rdoBillCustomer.Size = new System.Drawing.Size(85, 17);
            this.rdoBillCustomer.TabIndex = 1;
            this.rdoBillCustomer.TabStop = true;
            this.rdoBillCustomer.Text = "Bill Customer";
            this.rdoBillCustomer.UseVisualStyleBackColor = true;
            this.rdoBillCustomer.CheckedChanged += new System.EventHandler(this.Billing_CheckedChanged);
            // 
            // rdoCreditCard
            // 
            this.rdoCreditCard.AutoSize = true;
            this.rdoCreditCard.Checked = true;
            this.rdoCreditCard.Location = new System.Drawing.Point(21, 24);
            this.rdoCreditCard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoCreditCard.Name = "rdoCreditCard";
            this.rdoCreditCard.Size = new System.Drawing.Size(76, 17);
            this.rdoCreditCard.TabIndex = 0;
            this.rdoCreditCard.TabStop = true;
            this.rdoCreditCard.Text = "Credit card";
            this.rdoCreditCard.UseVisualStyleBackColor = true;
            this.rdoCreditCard.CheckedChanged += new System.EventHandler(this.Billing_CheckedChanged);
            // 
            // lblCreditCardType
            // 
            this.lblCreditCardType.AutoSize = true;
            this.lblCreditCardType.Location = new System.Drawing.Point(16, 122);
            this.lblCreditCardType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCreditCardType.Name = "lblCreditCardType";
            this.lblCreditCardType.Size = new System.Drawing.Size(84, 13);
            this.lblCreditCardType.TabIndex = 1;
            this.lblCreditCardType.Text = "Credit card type:";
            // 
            // lstCreditCardType
            // 
            this.lstCreditCardType.FormattingEnabled = true;
            this.lstCreditCardType.Location = new System.Drawing.Point(197, 122);
            this.lstCreditCardType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstCreditCardType.Name = "lstCreditCardType";
            this.lstCreditCardType.Size = new System.Drawing.Size(205, 69);
            this.lstCreditCardType.TabIndex = 2;
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Location = new System.Drawing.Point(16, 217);
            this.lblCardNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(70, 13);
            this.lblCardNumber.TabIndex = 3;
            this.lblCardNumber.Text = "Card number:";
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(197, 217);
            this.txtCardNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(205, 20);
            this.txtCardNumber.TabIndex = 4;
            // 
            // lblExpirationDate
            // 
            this.lblExpirationDate.AutoSize = true;
            this.lblExpirationDate.Location = new System.Drawing.Point(16, 266);
            this.lblExpirationDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Size = new System.Drawing.Size(80, 13);
            this.lblExpirationDate.TabIndex = 5;
            this.lblExpirationDate.Text = "Expiration date:";
            // 
            // cboExpirationMonth
            // 
            this.cboExpirationMonth.FormattingEnabled = true;
            this.cboExpirationMonth.Location = new System.Drawing.Point(197, 266);
            this.cboExpirationMonth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboExpirationMonth.Name = "cboExpirationMonth";
            this.cboExpirationMonth.Size = new System.Drawing.Size(92, 21);
            this.cboExpirationMonth.TabIndex = 6;
            // 
            // cboExpirationYear
            // 
            this.cboExpirationYear.FormattingEnabled = true;
            this.cboExpirationYear.Location = new System.Drawing.Point(310, 266);
            this.cboExpirationYear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboExpirationYear.Name = "cboExpirationYear";
            this.cboExpirationYear.Size = new System.Drawing.Size(92, 21);
            this.cboExpirationYear.TabIndex = 7;
            // 
            // chkDefault
            // 
            this.chkDefault.AutoSize = true;
            this.chkDefault.Checked = true;
            this.chkDefault.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDefault.Location = new System.Drawing.Point(13, 315);
            this.chkDefault.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkDefault.Name = "chkDefault";
            this.chkDefault.Size = new System.Drawing.Size(158, 17);
            this.chkDefault.TabIndex = 8;
            this.chkDefault.Text = "Set as default billing method";
            this.chkDefault.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(197, 337);
            this.btnOK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(56, 19);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(328, 337);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(56, 19);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmPayment
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.chkDefault);
            this.Controls.Add(this.cboExpirationYear);
            this.Controls.Add(this.cboExpirationMonth);
            this.Controls.Add(this.lblExpirationDate);
            this.Controls.Add(this.txtCardNumber);
            this.Controls.Add(this.lblCardNumber);
            this.Controls.Add(this.lstCreditCardType);
            this.Controls.Add(this.lblCreditCardType);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "frmPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.frmPayment_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoBillCustomer;
        private System.Windows.Forms.RadioButton rdoCreditCard;
        private System.Windows.Forms.Label lblCreditCardType;
        private System.Windows.Forms.ListBox lstCreditCardType;
        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.Label lblExpirationDate;
        private System.Windows.Forms.ComboBox cboExpirationMonth;
        private System.Windows.Forms.ComboBox cboExpirationYear;
        private System.Windows.Forms.CheckBox chkDefault;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}