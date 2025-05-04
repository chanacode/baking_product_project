using BakingProductProject.viewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakingProductProject.model
{
     
    public class Comments : BaseEntity
    {
        public Recipe recipeCode { get; set; }
        public int serialCode { get; set; }
        public string comment { get; set; }

        public override string GetTableName()
        {
            return "Comments";
        }


        public override string[]GetKeyFields()
        {
            return new string[] { "recipeCode", "serialCode" };
        }
     

    }
}
