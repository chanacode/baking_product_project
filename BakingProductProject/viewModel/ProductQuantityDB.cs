using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BakingProductProject.model;
namespace BakingProductProject.viewModel
{
    public class productQuantityDB : BaseDB
    {
        public override BaseEntity creatModel()
        {
            ProductQuantity item = new ProductQuantity();

            int productCode =Convert. ToInt32( reader["productCode"]);          
            item.productCode = MyDB.productDB.GetProductD().FirstOrDefault(x => x.productCode == productCode);
            item.serialCode = Convert.ToInt32(reader["serialCode"]);
            item.quantityInStock = Convert.ToInt32(reader["quantityInStock"]);
            item.priceForUnit = Convert.ToInt32(reader["priceForUnit"]);
            int unitTypeCode = Convert.ToInt32(reader["unitTypeCode"]);
            item.unitTypeCode = MyDB.kindsOfIndividualsDB.GetKindsOfIndividuals().FirstOrDefault(x => x.unitTypeCode == unitTypeCode);

            string amount = reader["amount"].ToString();
            
            



            return item;
        }

        public override string GetTableName()
        {
            return "ProductQuantity";
        }
        public List<ProductQuantity> GetProductsQuantity()
        {
            return list.Cast<ProductQuantity>().ToList();
        }
    }
}
