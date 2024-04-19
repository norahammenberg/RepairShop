namespace RepairShop
{
    partial class frmModifyCustomer
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label Label1;
            System.Windows.Forms.Label NameLabel;
            System.Windows.Forms.Label PhoneLabel;
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblCustomerId = new System.Windows.Forms.Label();
            Label1 = new System.Windows.Forms.Label();
            NameLabel = new System.Windows.Forms.Label();
            PhoneLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new System.Drawing.Point(25, 26);
            Label1.Name = "Label1";
            Label1.Size = new System.Drawing.Size(68, 13);
            Label1.TabIndex = 33;
            Label1.Text = "Customer ID:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(184, 151);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(61, 151);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new System.Drawing.Point(52, 62);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new System.Drawing.Size(38, 13);
            NameLabel.TabIndex = 27;
            NameLabel.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(102, 59);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(157, 20);
            this.txtName.TabIndex = 28;
            // 
            // PhoneLabel
            // 
            PhoneLabel.AutoSize = true;
            PhoneLabel.Location = new System.Drawing.Point(52, 104);
            PhoneLabel.Name = "PhoneLabel";
            PhoneLabel.Size = new System.Drawing.Size(41, 13);
            PhoneLabel.TabIndex = 29;
            PhoneLabel.Text = "Phone:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(102, 101);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 30;
            // 
            // errProvider
            // 
            this.errProvider.ContainerControl = this;
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.AutoSize = true;
            this.lblCustomerId.Location = new System.Drawing.Point(106, 27);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(0, 13);
            this.lblCustomerId.TabIndex = 34;
            // 
            // frmModifyCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 231);
            this.Controls.Add(Label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(NameLabel);
            this.Controls.Add(this.txtName);
            this.Controls.Add(PhoneLabel);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblCustomerId);
            this.Name = "frmModifyCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modify Customer";
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.TextBox txtName;
        internal System.Windows.Forms.TextBox txtPhone;
        internal System.Windows.Forms.ErrorProvider errProvider;
        internal System.Windows.Forms.Label lblCustomerId;
    }
}