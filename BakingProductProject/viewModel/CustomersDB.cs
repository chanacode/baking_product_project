using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BakingProductProject.model;
namespace BakingProductProject.viewModel
{
    public class CustomersDB:BaseDB
    {
        public override BaseEntity creatModel()
        {
            Customers item = new Customers();
            item.customerCode = Convert.ToInt32(reader["customerCode"]);
            item.firstName = reader["firstName"].ToString();

            item.secondName = reader["secondName"].ToString();
            item.address = reader["address"].ToString();
            item.tel = reader["tel"].ToString();

            item.password = reader["password"].ToString();
            item.userName = reader["userName"].ToString();

            return item;
        }
        public override string GetTableName()
        {
            return "Customers";
        }
        public List<Customers>GetCustomers()
        {
            return list.Cast<Customers>().ToList();//מושלם
        }
        public override bool Add(BaseEntity entity)
        {
            if (entity is Customers)
            {
                if (list.Count == 0)
                    (entity as Customers).customerCode = 1;
                else
                    (entity as Customers).customerCode = GetCustomers().Max(X => X.customerCode) + 1;
                return base.Add(entity);
            }
            return false;
        }
    }
}
