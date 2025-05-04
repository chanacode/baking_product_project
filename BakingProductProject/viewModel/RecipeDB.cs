using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BakingProductProject.model;
namespace BakingProductProject.viewModel
{
    internal class RecipeDB:BaseDB
    {

        public override BaseEntity creatModel()
        {
            Recipe item = new Recipe();
            item.recipeCode = Convert.ToInt32(reader["recipeCode"]);
            item.recipeName = reader["recipeName"].ToString();

            item.difficulityLevel = reader["difficulityLevel"].ToString();
            item.preparationTime = Convert.ToInt32(reader["preparationTime"]);
            item.numbersOfServings = Convert.ToInt32(reader["numbersOfServings"]);

            item.parveOrDairy = reader["parveOrDairy"].ToString(); 
            item.like = Convert.ToInt32(reader["like"]);
           // item.allProductAvailable = Convert.ToBoolean(reader["allProductAvailable"]);
            item.pictureOfRecipe = reader["pictureOfRecipe"].ToString();//לבדק מה לעשות לתמונה
            return item;
        }
        public override string GetTableName()
        {
            return "Recipe";
        }
        public List<Recipe>GetRecipes()
        {
            return list.Cast<Recipe>().ToList();
        }
        //מושלם
        public override bool Add(BaseEntity entity)
        {
            if (entity is Recipe)
            {
                if (list.Count == 0)
                    (entity as Recipe).recipeCode = 1;
                else
                    (entity as Recipe).recipeCode = GetRecipes().Max(X => X.recipeCode) + 1;
                return base.Add(entity);
            }
            return false;
        }
    }
}
