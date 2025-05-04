using BakingProductProject.viewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakingProductProject.model
{
    public class ShoppingDetails:BaseEntity
    {
        public Shopping shoppingCode { get; set; }
        public Product productCode { get; set; }
        public ProductQuantity serialCode { get; set; }//לבדק אם אכן צריך פה הכלה
        public int amount { get; set; }//כמות בקניה
        public int alltogetherForPaying { get; set; }


        public override string GetTableName()
        {
            return "ShoppingDetails";
        }

        public override string[] GetKeyFields()
        {
            return new string[] { "shoppingCode", "productCode", "serialCode" };
        }

        public bool AddShoppingDetails(ShoppingDetails shd)
        {
            return MyDB.shoppingDetailsDB.Add(shd);
        }
    }
}
