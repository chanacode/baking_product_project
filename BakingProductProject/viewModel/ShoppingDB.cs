using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BakingProductProject.model;
namespace BakingProductProject.viewModel
{
    public class ShoppingDB:BaseDB
    {
        public override BaseEntity creatModel()
        {
            Shopping item = new Shopping();
            item.codeShopping = Convert.ToInt32(reader["codeShopping"]);
            DateTime da;
            DateTime.TryParse(reader["dateShopping"].ToString(), out da);
            item.dateShopping = da;
           
            item.amountForPaying = Convert.ToInt32(reader["amountForPaying"]);

            return item;
        }



        public override string GetTableName()
        {
            return "Shopping";
        }
        public List<Shopping> GetShoppings()
        {
            return list.Cast<Shopping>().ToList();
        }
        public override bool Add(BaseEntity entity)
        {
            if (entity is Shopping)
            {
                if (list.Count == 0)
                    (entity as Shopping).codeShopping = 1;
                else
                    (entity as Shopping).codeShopping = GetShoppings().Max(X => X.codeShopping) + 1;
                return base.Add(entity);
            }
            return false;
        }

    }
}
