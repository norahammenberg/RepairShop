using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepairShop
{
    public partial class frmCustomers : Form
    {
        //bringing in the customer class and all its methods
        private Customer customer;
        public frmCustomers()
        {
            InitializeComponent();
            //creating a new instance of the customer class a new object
            customer = new Customer();
        }

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            this.customersTableAdapter.Fill(this.repairServicesDataSet.Customers);


            // TODO: This line of code loads data into the 'repairServicesDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.repairServicesDataSet.Customers);
            // TODO: This line of code loads data into the 'repairServicesDataSet.Appointments' table. You can move, or remove it, as needed.
           // this.appointmentsTableAdapter.Fill(this.repairServicesDataSet.Appointments);

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //if user have selected a row in the gridview
            if (dgvCustomers.SelectedRows.Count == 0)
            {
                lblStatus.Text = "Please select a row before edit";
                return;
            }

            var form = new frmModifyCustomer
            {
                //customerID is a property getter setter in th modyfycustomer form. we save the customer id to it
                //by accessing the selected row by user and the value of cell 0 whish is the custid
                CustumerId = Convert.ToInt16(dgvCustomers.SelectedRows[0].Cells[0].Value)
            };

            if ( form.ShowDialog() == DialogResult.OK )
            {
             //if the customer is updated correct we fill the datagride again.
                customersTableAdapter.Fill(repairServicesDataSet.Customers);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            //if user have selected a row in the gridview
            if (dgvCustomers.SelectedRows.Count > 0)
            {
                var custId = Convert.ToInt16(dgvCustomers.SelectedRows[0].Cells[0].Value);

                if(customer.Delete(custId))
                {
                    //desplaying all data by calling the Items property in customer class. 
                    dgvCustomers.DataSource = customer.Items;
                    MessageBox.Show("Customer was deleted");
                }
                else
                    {
                    MessageBox.Show("Customer wasnot deleted");
                }
            }
        }
    }
}
