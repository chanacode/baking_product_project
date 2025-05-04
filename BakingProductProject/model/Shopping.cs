using BakingProductProject.viewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakingProductProject.model
{
    public class Shopping:BaseEntity
    {
        public int codeShopping { get; set; }
        public DateTime dateShopping { get; set; }
        public double amountForPaying { get; set; }
        //לבדק אם חסר נתון אחד


        public override string GetTableName()
        {
            return "Shopping";
        }

        public override string[] GetKeyFields()
        {
            return new string[] { "codeShopping" };
        }

        public bool AddShopping(Shopping sh)
        {
            return MyDB.shoppingDB.Add(sh);
        }


    }
}
