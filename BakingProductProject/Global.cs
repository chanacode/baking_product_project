using BakingProductProject.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BakingProductProject
{
    internal class Global
    {
        //למחוק את כל זה
        //אחרי המחיקה יהיו טעויות בכל מקום שהשתמשת בזה אך צריך להקרוא למיי די בי במקום זה
        public static List<Product> products = new List<Product>();
        public static List<Recipe> recipe = new List<Recipe>();
        public static List<Customers> customersList = new List<Customers>();
        public static List<Comments> commentsList = new List<Comments>();
        public static List<KindsOfIndividuals> KindsOfIndividualsList = new List<KindsOfIndividuals>();
        public static List<Payment> paymentList = new List<Payment>();
        public static List<ProductForRecipe> productForRecipeList = new List<ProductForRecipe>();
        public static List<ProductQuantity> productQuantitieList = new List<ProductQuantity>();
        public static List<Shopping> shoppingList = new List<Shopping>();
      //עד כאן
        
        
        public static List<ShoppingDetails> shoppingDetailsList = new List<ShoppingDetails>();//פרטי קניה בהרצה נוכחית 
        public static Customers customersUser;
        public static bool IsManager=false;
       /* public static Worker WorkerUser;*///לבדק מה לעשות האם להוסיף טבלה לעובד או שלא צריך
        /*public static principal principalUser;*///לבדק מה לעשות האם להוסיף טבלה למנהל או שלא צריך


    }
}
