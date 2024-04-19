using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepairShop.RepairServicesDataSetTableAdapters; 

namespace RepairShop
{
	public class RepairTypes
	{
		//variable for the table adapter (learn read about this) this is an object.
		private readonly RepairTypesTableAdapter adapter;
		

		//constructor, inisiating the object above called adapter:
		public RepairTypes()
		{
			adapter = new RepairTypesTableAdapter();
		}

		//property, this is a getter and setter, this is ready only so we only GETTING the data
		public DataTable Items 
		{ 
			//getter
			get
			{
				//this datatable called table calls the table adapters method called getData that is an sql statment and will be exucuted. 
				DataTable table = adapter.GetData(); //getting all repair types from the database table
				//this will sort our sql statment by the discription of the item
				table.DefaultView.Sort = "Description";// sort by description
				return table; //returning the table sorted. 
			}
		}
	}
}

