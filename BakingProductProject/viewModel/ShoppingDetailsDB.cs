using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BakingProductProject.model;
namespace BakingProductProject.viewModel
{
    public class ShoppingDetailsDB:BaseDB
    {
        public override BaseEntity creatModel()
        {
            ShoppingDetails item = new ShoppingDetails();

            int shoppingCode = Convert.ToInt32(reader["shoppingCode"]);
            item.shoppingCode = MyDB.shoppingDB.GetShoppings().FirstOrDefault(x => x.codeShopping == shoppingCode);
            int codeProduct= Convert.ToInt32(reader["productCode"]);
            item.productCode =MyDB.productDB.GetProductD().FirstOrDefault(x=>x.productCode == codeProduct);

            int serialCode = Convert.ToInt32(reader["serialCode"]);

            item.serialCode = MyDB.productQuantityDB.GetProductsQuantity().FirstOrDefault(x => x.serialCode == serialCode);//לבדק אם יש פעולה של GETשל כמות מוצר
            item.amount = Convert.ToInt32(reader["amount"]);
            item.alltogetherForPaying = Convert.ToInt32(reader["alltogetherForPaying"]);

            return item;
        }



        public override string GetTableName()
        {
            return "ShoppingDetails";
        }
        public List<ShoppingDetails> GetShoppingDetails()
        {
            return list.Cast<ShoppingDetails>().ToList();
        }

    }
}
