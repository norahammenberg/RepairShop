using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepairShop
{
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //clsoing th form
            Close();
        }

        private void AppointmentsNewMenuItem_Click(object sender, EventArgs e)
        {
            //new instance of the new app form
            var formNewApp = new frmNewAppointment();
            //new instance of the app form
            var formApp = new frmAppointments();

            if (formNewApp.ShowDialog() == DialogResult.OK)
            {
                formApp.ShowDialog();
            }
        }

        private void AppointmentsViewMenuItem_Click(object sender, EventArgs e)
        {
            //new instance of the app form
            var formApp = new frmAppointments();
            formApp.ShowDialog();
        }

        private void mnuModifyCustomer_Click(object sender, EventArgs e)
        {
            var formNewCustomer = new frmNewCustomer();
            var formCustomer = new frmCustomers();
            if (formNewCustomer.ShowDialog() == DialogResult.OK)
            {
                formCustomer.ShowDialog();

            }
        }

        private void CustomersViewMenuItem_Click(object sender, EventArgs e)
        {
            var formCustomer = new frmCustomers();
            formCustomer.ShowDialog();
        }
    }
}
