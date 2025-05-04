using BakingProductProject.model;
using BakingProductProject.viewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BakingProductProject.UI
{
    /// <summary>
    /// Interaction logic for ShowListProductQuantity.xaml
    /// </summary>
    public partial class ShowListProductQuantity : Page
    {
        public ShowListProductQuantity()
        {
            InitializeComponent();
            lvProductQuantity.ItemsSource = MyDB.productQuantityDB.GetProductsQuantity();
        }



        private void lvProductQuantity_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            //if (lvProductQuantity.SelectedItem is ProductQuantity)
            //           {
            //               ProductQuantity pq = lvProductQuantity.SelectedItem as ProductQuantity;//המרת הפריט שנבחר לאוביקט מסוג מוצר
            //               NavigationService myFram = NavigationService.GetNavigationService(this);//המשתנה מיפריים מחזיק כרגע את הפריים שבו הדף הזה נמצא
            //               myFram.Navigate(new AddApdateProduct(pq)); //דפדוף לדף ושליחת פרמטרים  
            //           }
            //       }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (lvProductQuantity.SelectedItem != null && lvProductQuantity.SelectedItem is ProductQuantity)
            {
                ProductQuantity pq = lvProductQuantity.SelectedItem as ProductQuantity;//המרת הפריט שנבחר לאוביקט מסוג מוצר
                if (pq.quantityInStock > 0)
                {
                    //אם המוצר שנבחר כבר קיים ברשימת פרטי קניה אז רק להוסיף לו בכמות
                    //ואם לא:
                    //לייצר כאן עצם של פריט קניה למלא בכל הפרטים ולהוסיף לרשימה
                    //Global.shoppingDetailsList.Add();
                }

            }

            //private void Button_Click(object sender, RoutedEventArgs e)
            //{
            //    NavigationService nav = NavigationService.GetNavigationService(this);
            //    nav.Navigate(new ShowListShoppingDetails());
            //}לבדק למה זה עושה לי שגיאה
        }
    }
}
