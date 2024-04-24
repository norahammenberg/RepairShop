using RepairShop.RepairServicesDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static RepairShop.RepairServicesDataSet;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace RepairShop
{
    public class Appointment
    {
        //variable that si private to bring in the dataset from this table
        private readonly AppointmentsTableAdapter appAdapter;

        public static string LastError { get; set; }

        private AppointmentsRow origApp;

        //Property: this return a table af appontiment into itmes. 
        public DataTable Items => appAdapter.GetData();

        //constructor
        public Appointment()
        {
            //new object
            appAdapter = new AppointmentsTableAdapter();
        }

        //method, this method will return the appontments to this selected customer. 
        public DataTable GetCustumerById(short custId)
        {
            //get all data from the appintment table,, tehn filter by custID
            var table = appAdapter.GetData();
            table.DefaultView.RowFilter = "CustId = " + custId;
            return table;
        }

        //method to find appointment ID (so not cust id the appontment init self)
        // this will return just the row of this selected appontment.
        public AppointmentsRow FindAppById(short appId)
        {
            var table = appAdapter.GetData().FindByApptId(appId);
            return table;
        }

        //method that give us time for the appontment: static dont need all info frm the objetc appadapter
        //datetime is adatatype
        public static DateTime CombineDateTime(DateTime aDate, DateTime aTime)
        {
            //variable that creates the time in the format we like
            var timeStan = new TimeSpan(aTime.Hour, aTime.Minute, 0);
            //returning date (that is allready in correct format) adding on the time in our new format
            return aDate.Add(timeStan);
        }
        public bool InsertNewApp(short typeid, bool license, string discreption, short custId, DateTime time)
        {
            try
            {
                //insertis a built in method to the databas
                appAdapter.Insert(typeid, discreption, license, custId, time);
                return true;
            }
            catch (Exception ex)
            {
                LastError = $"Failed to insert new appointment. Reson: {ex.Message}";
                return false;
            }
        }
        public bool Update(short appId, short typeid, bool license, string discreption, short custId, DateTime time)
        {
            //new valuse comes from user through thie para in the method, the old valuse comes from the adapter and saves tp originalApp varaiable.
            try
            {
                //this gives us the original appointment by id we we getting from the user.
                origApp = appAdapter.GetData().FindByApptId(appId);
                appAdapter.Update(typeid, discreption, license, custId, time, origApp.ApptId, origApp.TypeId, origApp.Description, origApp.Licensed, origApp.CustId, origApp.Scheduled, appId);
                //was it success full
                return true;
            }
            catch (Exception ex)
            { 
                LastError = $"Failed to update new appointment. Reson: {ex.Message}";
                return false;
            }
        }
        
           
        

        public bool Delete(short appId)
        {
            var rowsAffected = 0;
            if (MessageBox.Show("Delete the Appointment?", "Delete Appontment", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                origApp = appAdapter.GetData().FindByApptId(appId);
                //I dont understand how this gives us a number...
                rowsAffected = appAdapter.Delete(origApp.ApptId, origApp.TypeId, origApp.Description, origApp.Licensed, origApp.CustId, origApp.Scheduled);
            }
            //if this statment is true, we retirn true, if rowsaffected is 0 this is false and we return false
            return rowsAffected > 0;
        }


    }

    
}
