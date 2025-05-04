using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BakingProductProject.model;
namespace BakingProductProject.viewModel
{
    public class ProductForRecipeDB:BaseDB
    {

        public override BaseEntity creatModel()
        {
            ProductForRecipe item = new ProductForRecipe();
            int recipeCode =Convert.ToInt32 (reader["recipeCode"].ToString());
            item. recipeCode = MyDB.recipeDB.GetRecipes().FirstOrDefault(x => x.recipeCode == recipeCode);
             int productCode =Convert.ToInt32( reader["productCode"].ToString());
            item. productCode = MyDB.productDB.GetProductD().FirstOrDefault(x => x.productCode == productCode);
        item.amount = Convert.ToInt32(reader["amount"]);

            int codeUnitType = Convert.ToInt32(reader["unitTypeCode"]);
            item.unitTypeCode = MyDB.kindsOfIndividualsDB.GetKindsOfIndividuals().FirstOrDefault(x => x.unitTypeCode == codeUnitType);


            return item;
        }



        public override string GetTableName()
        {
            return "ProductForRecipe";
        }
        public List<ProductForRecipe>GetProductsForRecipe()
        {
            return list.Cast<ProductForRecipe>().ToList();
        }
        //מושלם
    }
}
