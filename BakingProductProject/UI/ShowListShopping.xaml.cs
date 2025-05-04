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
    /// Interaction logic for ShowListShopping.xaml
    /// </summary>
    public partial class ShowListShopping : Page
    {
        public ShowListShopping()
        {
            InitializeComponent();
            lvShopping.ItemsSource = MyDB.shoppingDB.GetShoppings();
        }

       
        private void lvShopping_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
          if (lvShopping.SelectedItem is Shopping)
            {
               Shopping s = lvShopping.SelectedItem as Shopping;//המרת הפריט שנבחר לאוביקט מסוג מוצר
              NavigationService myFram = NavigationService.GetNavigationService(this);//המשתנה מיפריים מחזיק כרגע את הפריים שבו הדף הזה נמצא
                //myFram.Navigate(new AddUpdateShopping(s)); //דפדוף לדף ושליחת פרמטרים  
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new AddUpdatePayment());
        }
    }
}
