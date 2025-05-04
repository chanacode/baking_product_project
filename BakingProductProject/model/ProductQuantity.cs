using BakingProductProject.viewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakingProductProject.model
{
    public class ProductQuantity:BaseEntity
    {
        public Product productCode { get; set; }
        public int serialCode { get; set; }
        public int quantityInStock { get; set; }//כמות במלאי
        public double priceForUnit { get; set; }
        public KindsOfIndividuals unitTypeCode { get; set; }
        public int amount { get; set; }//כמות בחבילה בודדת

        public override string GetTableName()
        {
            return "ProductQuantity";
        }

        public override string[] GetKeyFields()
        {
            return new string[] { "productCode", "serialCode" };
        }

        public bool AddProductQuantity(ProductQuantity pq)
        {
            return MyDB.productQuantityDB.Add(pq);
        }
    }
}
