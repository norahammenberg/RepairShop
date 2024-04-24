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
    public partial class frmNewCustomer : Form
    {
        public frmNewCustomer()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //new instance of the costumer object
            var customer = new Customer();  
            //this will give us the id we weill be creating for this new coustomer 
            var custId = customer.NextCustomerId;

            //varifare that tehre is now duplicate phonenumber
            if (customer.PhoneNumberDuplicate(txtPhone.Text, custId)) //this is a method in custumer class that returns boolso if it is true, the this if state is runned
            {
                errProvider.SetError(txtPhone, "This phone number belongs to another customer. Please enter abother phone number.");
            }
            else
            {
                errProvider.SetError(txtPhone, "");
                if (customer.InsertNewCustomer(custId, txtName.Text, txtPhone.Text)) ///this is a method in custumer class that returns bool, so if it is true, the this if state is runned
                { 
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }
    }
}
