namespace PaymentApp
{
    partial class frmCustomer
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
            this.lbl_CustomerName = new System.Windows.Forms.Label();
            this.cbo_Names = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Payment = new System.Windows.Forms.Label();
            this.btn_Payment = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_CustomerName
            // 
            this.lbl_CustomerName.AutoSize = true;
            this.lbl_CustomerName.Location = new System.Drawing.Point(25, 22);
            this.lbl_CustomerName.Name = "lbl_CustomerName";
            this.lbl_CustomerName.Size = new System.Drawing.Size(111, 17);
            this.lbl_CustomerName.TabIndex = 0;
            this.lbl_CustomerName.Text = "Customer name:";
            // 
            // cbo_Names
            // 
            this.cbo_Names.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Names.FormattingEnabled = true;
            this.cbo_Names.Location = new System.Drawing.Point(256, 19);
            this.cbo_Names.Name = "cbo_Names";
            this.cbo_Names.Size = new System.Drawing.Size(349, 24);
            this.cbo_Names.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Payment method:";
            // 
            // lbl_Payment
            // 
            this.lbl_Payment.AutoSize = true;
            this.lbl_Payment.Location = new System.Drawing.Point(25, 140);
            this.lbl_Payment.Name = "lbl_Payment";
            this.lbl_Payment.Size = new System.Drawing.Size(0, 17);
            this.lbl_Payment.TabIndex = 3;
            // 
            // btn_Payment
            // 
            this.btn_Payment.Location = new System.Drawing.Point(403, 134);
            this.btn_Payment.Name = "btn_Payment";
            this.btn_Payment.Size = new System.Drawing.Size(202, 23);
            this.btn_Payment.TabIndex = 4;
            this.btn_Payment.Text = "Select Payment";
            this.btn_Payment.UseVisualStyleBackColor = true;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(268, 406);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 5;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            // 
            // btn_Exit
            // 
            this.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Exit.Location = new System.Drawing.Point(461, 406);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 6;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Exit;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Payment);
            this.Controls.Add(this.lbl_Payment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbo_Names);
            this.Controls.Add(this.lbl_CustomerName);
            this.Name = "frmCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_CustomerName;
        private System.Windows.Forms.ComboBox cbo_Names;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Payment;
        private System.Windows.Forms.Button btn_Payment;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Exit;
    }
}

