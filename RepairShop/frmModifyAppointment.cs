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
   
    public partial class frmModifyAppointment : Form
    {
        //property getter setter for app id
        public short AppointmentId { get; set; }
        private Appointment app;
        private RepairTypes repairType;
        private Customer customer;
        public frmModifyAppointment()
        {
            InitializeComponent();
            app = new Appointment();
            repairType = new RepairTypes();
            customer = new Customer();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmModifyAppointment_Load(object sender, EventArgs e)
        {
            //this is populating the combo boxes 

            cboRepairType.DataSource = repairType.Items;//gives us the datat sores from the DB via the repartpe class
            cboRepairType.DisplayMember = "Description"; //from this data source we can display valuse and member sthey habe
            cboRepairType.ValueMember = "TypeId";

            cboCustomer.DataSource = customer.Items;
            cboCustomer.DisplayMember = "Name";
            cboCustomer.ValueMember = "CustId";

            //finding the app by the id that is being passed to this form. 
            var row = app.FindAppById(AppointmentId);

            // we making inserting the selected appontments valuse to be showed. this is picked from the row varaible that have all this values inside its objetc
            dtpDate.Value = row.Scheduled.Date;
            txtTime.Text = row.Scheduled.TimeOfDay.ToString();
            chkLicensed.Checked = row.Licensed;
            txtDescription.Text = row.Description;
            cboRepairType.SelectedValue = row.TypeId;
            cboCustomer.SelectedValue = row.CustId;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DateTime scheduledAt;
            try
            {
                scheduledAt = Appointment.CombineDateTime(dtpDate.Value.Date, Convert.ToDateTime(txtTime.Text));
            }
            catch (Exception)
            {
                errProvider.SetError(txtTime, "Please provide an appointment time");
                return;
            }


            //all the calues we need for a new app, it is saved in a caraibel and taken from the form.
            var typeId = Convert.ToInt16(cboRepairType.SelectedValue);
            var custId = Convert.ToInt16(cboCustomer.SelectedValue);
            var licensed = chkLicensed.Checked;

            //if insert is true, ren the method and then close the form
            if (app.Update(AppointmentId, typeId, licensed, txtDescription.Text, custId, scheduledAt))
            {
                Close();
            }
            else
            {
                lblStatus.Text = $"Cannot update appontment {Appointment.LastError}";
            }
        }
    }
}
