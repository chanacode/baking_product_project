using BakingProductProject.viewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakingProductProject.model
{
    public class Payment : BaseEntity
    {
        public int paymentCode { get; set; }
        public DateTime paymentDate { get; set; }
        public double sum { get; set; }
        public string cardNumber { get; set; }
        public DateTime validNumber { get; set; }
        public int cvv { get; set; }
        public Shopping codeShopping { get; set; }

        public override string GetTableName()
        {
            return "Payment";
        }

        public override string[] GetKeyFields()
        {
            return new string[] { "paymentCode" };
        }
        public bool AddPayment(Payment pay)
        {
            return MyDB.paymentDB.Add(pay);
        }

    }
}
