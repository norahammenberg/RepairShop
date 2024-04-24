namespace RepairShop
{
    partial class frmMainForm
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
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AppointmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AppointmentsNewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AppointmentsViewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuModifyCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.CustomersViewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Label1 = new System.Windows.Forms.Label();
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.AppointmentsToolStripMenuItem,
            this.CustomersToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(438, 24);
            this.MenuStrip1.TabIndex = 3;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileToolStripMenuItem.Text = "&File";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // AppointmentsToolStripMenuItem
            // 
            this.AppointmentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AppointmentsNewMenuItem,
            this.AppointmentsViewMenuItem});
            this.AppointmentsToolStripMenuItem.Name = "AppointmentsToolStripMenuItem";
            this.AppointmentsToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.AppointmentsToolStripMenuItem.Text = "Appointments";
            // 
            // AppointmentsNewMenuItem
            // 
            this.AppointmentsNewMenuItem.Name = "AppointmentsNewMenuItem";
            this.AppointmentsNewMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AppointmentsNewMenuItem.Text = "New";
            this.AppointmentsNewMenuItem.Click += new System.EventHandler(this.AppointmentsNewMenuItem_Click);
            // 
            // AppointmentsViewMenuItem
            // 
            this.AppointmentsViewMenuItem.Name = "AppointmentsViewMenuItem";
            this.AppointmentsViewMenuItem.Size = new System.Drawing.Size(180, 22);
            this.AppointmentsViewMenuItem.Text = "View";
            this.AppointmentsViewMenuItem.Click += new System.EventHandler(this.AppointmentsViewMenuItem_Click);
            // 
            // CustomersToolStripMenuItem
            // 
            this.CustomersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuModifyCustomer,
            this.CustomersViewMenuItem});
            this.CustomersToolStripMenuItem.Name = "CustomersToolStripMenuItem";
            this.CustomersToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.CustomersToolStripMenuItem.Text = "Customers";
            // 
            // mnuModifyCustomer
            // 
            this.mnuModifyCustomer.Name = "mnuModifyCustomer";
            this.mnuModifyCustomer.Size = new System.Drawing.Size(180, 22);
            this.mnuModifyCustomer.Text = "New";
            this.mnuModifyCustomer.Click += new System.EventHandler(this.mnuModifyCustomer_Click);
            // 
            // CustomersViewMenuItem
            // 
            this.CustomersViewMenuItem.Name = "CustomersViewMenuItem";
            this.CustomersViewMenuItem.Size = new System.Drawing.Size(180, 22);
            this.CustomersViewMenuItem.Text = "View";
            this.CustomersViewMenuItem.Click += new System.EventHandler(this.CustomersViewMenuItem_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(39, 97);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(335, 31);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "Welcome to Repair Shop";
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 199);
            this.Controls.Add(this.MenuStrip1);
            this.Controls.Add(this.Label1);
            this.Name = "frmMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Repair Shop";
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem AppointmentsToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem AppointmentsNewMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem AppointmentsViewMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem CustomersToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem mnuModifyCustomer;
        internal System.Windows.Forms.ToolStripMenuItem CustomersViewMenuItem;
        internal System.Windows.Forms.Label Label1;
    }
}

