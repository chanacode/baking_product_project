using BakingProductProject.viewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakingProductProject.model
{
 public   class Product:BaseEntity
    {
        public int productCode { get; set; }
        public string productName { get; set; }
        public bool available { get; set; }

        public override string GetTableName()
        {
            return "Product";
        }

        public override string[] GetKeyFields()
        {
            return new string[] { "productCode" };
        }

        public bool AddProduct(Product p)
        {
            return MyDB.productDB.Add(p);
        }
    }
}
