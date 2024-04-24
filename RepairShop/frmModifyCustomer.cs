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
    public partial class frmModifyCustomer : Form
    {
        public short CustumerId { get; set; }

        // variable of  object of customer class
        private Customer customer;
        //constractor
        public frmModifyCustomer()
        {
            InitializeComponent();
            //new customer object
            customer = new Customer();

        }
        //load event
        private void frmModifyCustomer_Load(object sender, EventArgs e)
        {
            var row = customer.FindById(CustumerId); // sql find customer with this id
            lblCustomerId.Text = row.CustId.ToString();
            txtName.Text = row.Name;
            txtPhone.Text = row.Phone;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(customer.PhoneNumberDuplicate(txtPhone.Text, CustumerId))
            {
                errProvider.SetError(txtPhone, "This phone number belongs to somone else, please eneter a different phone number");
            }
            else
            {
                errProvider.SetError(txtPhone, "");
                if (customer.Update(CustumerId, txtName.Text, txtPhone.Text)) 
                {
                    DialogResult= DialogResult.OK;
                    Close();
                }
            }

            
        

        }
    }
}
