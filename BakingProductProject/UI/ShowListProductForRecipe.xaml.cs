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
    /// Interaction logic for ShowListProductForRecipe.xaml
    /// </summary>
    public partial class ShowListProductForRecipe : Page
    {

        public ShowListProductForRecipe()
        {
            InitializeComponent();
            lvProductForRecipe.ItemsSource = MyDB.ProductForRecipeDB.GetProductsForRecipe();
            chooseProduct.ItemsSource = Global.products;
        }
        public ShowListProductForRecipe(Product productForUpdate)
        {
            InitializeComponent();
            chooseProduct.ItemsSource = Global.products;
        }


        private void lvProductForRecipe_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //if (lvProductForRecipe.SelectedItem is ProductForRecipe)
            //            {
            //                ProductForRecipe pro = lvProductForRecipe.SelectedItem as ProductForRecipe;//המרת הפריט שנבחר לאוביקט מסוג מוצר
            //                NavigationService myFram = NavigationService.GetNavigationService(this);//המשתנה מיפריים מחזיק כרגע את הפריים שבו הדף הזה נמצא
            //                myFram.Navigate(new AddApdateProduct(pro)); //דפדוף לדף ושליחת פרמטרים  
            //            }
            //        }
        }

    }
    }

