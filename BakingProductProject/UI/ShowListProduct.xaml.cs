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
using BakingProductProject.model;
using BakingProductProject.viewModel;

namespace BakingProductProject.UI

{
    /// <summary>
    /// Interaction logic for ShowListProduct.xaml
    /// </summary>
    public partial class ShowListProduct : Page
    {
        ProductDB pbd = new ProductDB();


        public ShowListProduct()
        {
            InitializeComponent();
            lvProduct.ItemsSource = MyDB.productDB.GetProductD();
        }

        private void lvProduct_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lvProduct.SelectedItem is Product)
            {
                Product p = lvProduct.SelectedItem as Product;//המרת הפריט שנבחר לאוביקט מסוג מוצר
                NavigationService myFram = NavigationService.GetNavigationService(this);//המשתנה מיפריים מחזיק כרגע את הפריים שבו הדף הזה נמצא
                myFram.Navigate(new AddUpdateProduct(p)); //דפדוף לדף ושליחת פרמטרים  
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new ShowListProductQuantity());
        }
    }
    }