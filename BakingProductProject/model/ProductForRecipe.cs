using BakingProductProject.viewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakingProductProject.model
{
    public class ProductForRecipe:BaseEntity
    {
        public Recipe recipeCode { get; set; }
        public Product productCode { get; set; }
        public int amount { get; set; }//כמות במתכון
        public KindsOfIndividuals unitTypeCode { get; set; }

        public override string GetTableName()
        {
            return "ProductForRecipe";
        }

        public override string[] GetKeyFields()
        {
            return new string[] { "recipeCode", "productCode" };
        }
        public bool AddProductForRecipe(ProductForRecipe pfr)
        {
            return MyDB.ProductForRecipeDB.Add(pfr);
        }
    }
}
