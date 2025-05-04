using BakingProductProject.viewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakingProductProject.model
{
     public  class Customers : BaseEntity
    {
        public int customerCode { get; set; }
        public string firstName { get; set; }
        public string secondName { get; set; }
        public string address { get; set; }
        public string tel { get; set; }
        public string password { get; set; }
        public string userName { get; set; }

        public override string GetTableName()
        {
            return "Customers";
        }

        public override string[]GetKeyFields()
        {
            return new string[] { "customerCode" };
        }
        public bool AddCustomer(Customers c)
        {
            return MyDB.customersDB.Add(c);
        }
        public bool UpdateCustomer(Customers c)
        {
            return MyDB.customersDB.Update(c);
        }
    }
}
