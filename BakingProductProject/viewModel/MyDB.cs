using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakingProductProject.viewModel
{
    internal class MyDB
    {
        public static RecipeDB recipeDB = new RecipeDB();
        public static CommentsDB commentsDB = new CommentsDB();
        public static ProductDB productDB = new ProductDB();        
        public static KindsOfIndividualsDB kindsOfIndividualsDB = new KindsOfIndividualsDB();
        public static ProductForRecipeDB ProductForRecipeDB = new ProductForRecipeDB();
        public static productQuantityDB productQuantityDB = new productQuantityDB();
        public static CustomersDB customersDB = new CustomersDB();
        public static ShoppingDB shoppingDB = new ShoppingDB();
        public static ShoppingDetailsDB shoppingDetailsDB = new ShoppingDetailsDB();
        public static PaymentDB paymentDB = new PaymentDB();
    }      
}
