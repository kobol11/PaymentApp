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
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbo_Names);
            this.Controls.Add(this.lbl_CustomerName);
            this.Name = "frmCustomer";
            this.Text = "Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_CustomerName;
        private System.Windows.Forms.ComboBox cbo_Names;
    }
}

