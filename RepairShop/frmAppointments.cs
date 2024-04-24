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
    public partial class frmAppointments : Form
    {
        //to varaibles of the classes appintmane and customer:
        private Appointment app;
        private Customer customer;
        // a variable that indicate if the form is loading
        private Boolean formLoading;
        //constractor.
        public frmAppointments()
        {
            InitializeComponent();
            app = new Appointment();
            customer = new Customer();
            formLoading = true;
        }

        private void frmAppointments_Load(object sender, EventArgs e)
        {
            //this is only for load the form, no custommer will be selected this is what the user will first. then it will select a cust
            cboCustomer.ComboBox.DataSource = customer.Items;//calling method in customer class

            //this two binds the name with the vaule so even if we can not see the ID the ID is selected whe acustomer is seleceted.
            cboCustomer.ComboBox.DisplayMember = "Name";
            cboCustomer.ComboBox.ValueMember = "CustId";

            cboCustomer.ComboBox.SelectedIndex = -1;//no customer is allready selected.
            formLoading = false;
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            //display all appontment.
            dgvAppointments.DataSource = app.Items;
            formLoading = true; // as this is tyr te nethod on 55 is skipped
            cboCustomer.ComboBox.SelectedIndex = -1;
            formLoading = false; //we have to sett it tp false again as every time we the selected index chaneg the method belove is triggerd. 
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // close the form. 
            Close();
        }

        private void cboCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!formLoading)
            {
                var custId = Convert.ToInt16(cboCustomer.ComboBox.SelectedValue);//getting tge customer id and convert to short.

                dgvAppointments.DataSource = app.GetCustumerById(custId);//call the method in app class and populate the result in the datatgrid
            }
            else {
                cboCustomer.ComboBox.SelectedIndex = -1;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvAppointments.SelectedRows.Count > 0) // if the selected rows counting to more the 0, the user have selected a row. 
            {
                var appID = dgvAppointments.SelectedRows[0].Cells[0].Value;//thatn save the app id to this varaible by accessing it in the grid view. 
                var form = new frmModifyAppointment();   //open themodify app wondow.
                form.AppointmentId = Convert.ToInt16(appID); //assignong THIS app id to the modufy app forms app id.
                //if the user have updated form show dialog
                form.ShowDialog();
                //show all items beloning to  selected customer with the modified app. 
                dgvAppointments.DataSource = app.Items;
                // (arrow up) is where the bug happens as we return all appontments we dont see the selected cosumer, so we add the following to lines to show only selected coustomers app 
                var custId = Convert.ToInt16(cboCustomer.ComboBox.SelectedValue);//getting tge customer id and convert to short.

                dgvAppointments.DataSource = app.GetCustumerById(custId);//call the method in app class and populate the result in the datatgrid

            }
            else
            {
                MessageBox.Show("Please select appontment for edit.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvAppointments.SelectedRows.Count > 0) // if the selected rows counting to more the 0, the user have selected a row. 
            {
                var appID = Convert.ToInt16(dgvAppointments.SelectedRows[0].Cells[0].Value);//thatn save the app id to this varaible by accessing it in the grid view. 
                if (app.Delete(appID))//if it is true shoe the appontments with out the deleted app. 
                {
                    dgvAppointments.DataSource = app.Items;
                    // (arrow up) is where the bug happens as we return all appontments we dont see the selected cosumer, so we add the following to lines to show only selected coustomers app 
                    var custId = Convert.ToInt16(cboCustomer.ComboBox.SelectedValue);//getting tge customer id and convert to short.

                    dgvAppointments.DataSource = app.GetCustumerById(custId);
                }
            }
            else
                MessageBox.Show("Please select an appontment to delete");
        }
    }
}
