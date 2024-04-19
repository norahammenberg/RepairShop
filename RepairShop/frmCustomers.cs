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
    public partial class frmCustomers : Form
    {
        public frmCustomers()
        {
            InitializeComponent();
        }

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'repairServicesDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.repairServicesDataSet.Customers);
            // TODO: This line of code loads data into the 'repairServicesDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.repairServicesDataSet.Customers);
            // TODO: This line of code loads data into the 'repairServicesDataSet.Appointments' table. You can move, or remove it, as needed.
            this.appointmentsTableAdapter.Fill(this.repairServicesDataSet.Appointments);

        }
    }
}
