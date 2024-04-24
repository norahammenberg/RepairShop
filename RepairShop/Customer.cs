using RepairShop.RepairServicesDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static RepairShop.RepairServicesDataSet;
namespace RepairShop
{
    public class Customer
    {
        //read data from costumer table adapter
        //data from custumer table,
        //variable, private and readonly as we never gonna change. 
        private readonly CustomersTableAdapter customerAdapter;

        //error, property, getter and setter, error provider, it will display error messages.
        //it is static becasue, we do not need to inisiate the object before accessing it
        public static string LastError { get; set; }


        //variable for update and delete. 
        CustomersRow originalCustomerRow;


        //constractor
        public Customer ()
        {
            //creating a new object of the customerAdapter.
            customerAdapter = new CustomersTableAdapter ();
        }

        //properties
        //this data will popylate the datagrid view.
        //datatable is the type (like int) 
        public DataTable Items 
        { 
            get
            {
                //returns all the data tablewith the sql menthod in the getdata();
                DataTable table = customerAdapter.GetData();
                table.DefaultView.Sort = "Name";
                return table;
            }
        }

        //property, getter setter, gettign the next custumer id if we adding a new custimer i think?
        public short NextCustomerId 
        {
             //we just need get as we obly getting data
             get
            {
                //we getting the last customer id and saving it to  variable. 
                var lastCustId = customerAdapter.GetLastCustomerId();

                //when giving a new value in the databas, the customer ID is alwasy incremented by 10 thats what this variable will be used for. 
                const short INCREMENT_VALUE = 10;
                if (lastCustId == 0) //the database is empty and we start the cust id on 1000
                {
                    return 1000;
                }
                else
                {
                   //if there is custumers in the database, then return that number plus 10, 
                   return Convert.ToInt16(lastCustId + INCREMENT_VALUE);
                }
            }
        }


        //we gonna check if phone number are a dublicate, we do a public bool method as we then retunr it is true or not true 
        //so true if ohonnumber is dublicate, false if it is not a dublicate.
        //used for updating new customer and creating new, there for we also need to see id ID is the ame
        public bool PhoneNumberDuplicate( string phoneNumber, short custId)
        {
            //variable type datarow.  we bringing the customers row by phonember
            //returns one row IF the phonenumber excist, with the SQL statment in the FindPhoneNumber fuction in the databas adapter.
            DataRow existingCustomer = customerAdapter.FindPhoneNumber(phoneNumber).FirstOrDefault();

            //if it is null, (no number excist)
            if (existingCustomer == null) 
            {
                return false;
            }
            //if Id is not equla to th costumers we are editing, ExcisitingCustumer (wechecking with the phonumber we picked s id)
            //return the id, that do not exsist. 
            // this is not true, so the cust id is not equal to the current cosutmer but the phone number is equal to true we know there is a costumer with a different id but have this number.
            //number is then taken. 
            return custId != Convert.ToInt16(existingCustomer[0]);
        // both this need to be false for us to be able to edit a custumers
        }
        /// <summary>
        /// method that have the datatype CustomerRow and will return a single customer by its ID. 
        /// </summary>
        /// <param name="custId"></param>
        /// <returns></returns>
        public CustomersRow FindById(short custId)
        {
            //finding customer by id, with sql statment in adapter
            var table = customerAdapter.FindByID(custId);

            //returning the row that is affiliated with said customer id.
            return (CustomersRow) table.Rows[0];
        }

        public bool InsertNewCustomer(short custId, string name, string phoneNumber)
        {
            //we using a try catch becasue we directely with the database, we wrapp it in a try catch block.
            try
            {
                //insert is a build in method in the adapter
                //if this works ad we can insert the new customer this is returning true as we working with a bool method
                customerAdapter.Insert(custId, name, phoneNumber);
                //return true
                return true;
            }
            //if try is not working we cathing execptions. 
            catch (Exception ex)// you need to name the exeption
            {
                LastError = $"Failed to insert new customer. Reson: {ex.Message}";
                return false; 
            }
        }

        public bool Update(short custId, string name, string phoneNumber)
        {
            try
            {
                //find custumer by id with swl statment in dabter
                //first we get the data with all customers then by the id
                //findByCustId i think is also a bulilt in function
                originalCustomerRow = customerAdapter.GetData().FindByCustId(custId);

                //update is a built in function
                customerAdapter.Update(custId, name, phoneNumber, originalCustomerRow.CustId, originalCustomerRow.Name, originalCustomerRow.Phone);

                //returning true if all is ok
                return true;
            }
            catch (Exception ex)
            {
                LastError = $"Failed to update new customer. Reson: {ex.Message}";
                return false;

            }
         }


        public bool Delete(short custId)
        {
            var rowsAffected = 0;
            if (MessageBox.Show("Delete the Customer?", "Delete Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                originalCustomerRow = customerAdapter.GetData().FindByCustId(custId);

                if ( customerAdapter.CustomerHasAppointments(originalCustomerRow.CustId) != null)
                {
                    MessageBox.Show("Connot delete customer becasue the customer has appontments.");
                    return false;
                }
                //I dont understand how this gives us a number...
                rowsAffected = customerAdapter.Delete(originalCustomerRow.CustId, originalCustomerRow.Name, originalCustomerRow.Phone);
            }
           
            //if this statment is true, we retirn true, if rowsaffected is 0 this is false and we return false
            return rowsAffected > 0;
        }

    }
}
