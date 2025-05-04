using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using BakingProductProject.model;
namespace BakingProductProject.viewModel
{
    public class ProductDB : BaseDB
    {


        public override BaseEntity creatModel()
        {
            Product item = new Product();
            item.productCode = Convert.ToInt32(reader["productCode"]);
            item.productName = reader["productName"].ToString();

            item.available = Convert.ToBoolean(reader["available"]);
           

            return item;
        }

      

        public override string GetTableName()
        {
            return "Product";
        }
        public List<Product>GetProductD()
        {
            return list.Cast<Product>().ToList();
        }
        public override bool Add(BaseEntity entity)
        {
            if (entity is Product)
            {
                if (list.Count == 0)
                    (entity as Product).productCode = 1;
                else
                    (entity as Product).productCode = GetProductD().Max(X => X.productCode) + 1;
                return base.Add(entity);
            }
            return false;
        }
    }
}