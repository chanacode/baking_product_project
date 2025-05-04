using BakingProductProject.viewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
namespace BakingProductProject.model
{
   public class Recipe:BaseEntity

    {
        public int recipeCode { get; set; }
        public string recipeName { get; set; }
        public string difficulityLevel { get; set; }
        public int preparationTime { get; set; }
        public int numbersOfServings { get; set; }
        public string parveOrDairy { get; set; }
        public bool AllProductAvailabe { get; set; }
        public int like { get; set; }
        public string pictureOfRecipe { get; set; }
        public BitmapImage Image1
        {
            get
            {
                return UsingCakes.GetImage(pictureOfRecipe);
            }
        }


        public override string GetTableName()
        {
            return "Recipe";
        }

        public override string[] GetKeyFields()
        {
            return new string[] { "recipeCode" };
        }

        public bool AddRecipe(Recipe r)
        {
            return MyDB.recipeDB.Add(r);
        }


    }
}
