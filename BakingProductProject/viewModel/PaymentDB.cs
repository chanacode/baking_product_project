using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BakingProductProject.model;
namespace BakingProductProject.viewModel
{
    public class PaymentDB : BaseDB
    {

        public override BaseEntity creatModel()
        {
            Payment item = new Payment();
            item.paymentCode = Convert.ToInt32(reader["paymentCode"]);
            DateTime d;
            DateTime.TryParse(reader["paymentDate"].ToString(), out d);
            item.paymentDate = d;
            item.sum = Convert.ToInt32(reader["sum"]);
            item.cardNumber = reader["cardNumber"].ToString();
            
            DateTime dt;
            DateTime.TryParse(reader["validNumber"].ToString(), out dt);
            item.validNumber = dt;
                
            item.cvv = Convert.ToInt32(reader["cvv"]);
            int codeShopping = Convert.ToInt32(reader["codeShopping"]);
            item.codeShopping =MyDB.shoppingDB.GetShoppings().FirstOrDefault(x =>   x.codeShopping == codeShopping);
            
            return item;
        }



        public override string GetTableName()
        {
            return "Payment";
        }
        public List<Payment> GetPayments()
        {
            return list.Cast<Payment>().ToList();
        }
        //מושלם
        public override bool Add(BaseEntity entity)
        {
            if (entity is Payment)
            {
                if (list.Count == 0)
                    (entity as Payment).paymentCode = 1;
                else
                    (entity as Payment).paymentCode = GetPayments().Max(X => X.paymentCode) + 1;
                return base.Add(entity);
            }
            return false;
        }
    }
    }

