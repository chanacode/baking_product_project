using BakingProductProject.viewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakingProductProject.model
{
     public  class KindsOfIndividuals : BaseEntity
    {
        public int unitTypeCode { get; set; }
        public string unitTypeName { get; set; }

        public override string GetTableName()
        {
            return "KindsOfIndividuals";
        }

        public override string[] GetKeyFields()
        {
            return new string[] { "unitTypeCode" };
        }
     
    }
}
