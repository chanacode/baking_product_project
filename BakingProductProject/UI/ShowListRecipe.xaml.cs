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
    /// Interaction logic for ShowListRecipe.xaml
    /// </summary>
    public partial class ShowListRecipe : Page
    {
        public ShowListRecipe()
        {
            InitializeComponent();
            lvRecipe.ItemsSource = MyDB.recipeDB.GetRecipes();
        }

        private void lvRecipe_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lvRecipe.SelectedItem is Recipe)
            {
                Recipe p = lvRecipe.SelectedItem as Recipe;//המרת הפריט שנבחר לאוביקט מסוג מוצר
                NavigationService myFram = NavigationService.GetNavigationService(this);//המשתנה מיפריים מחזיק כרגע את הפריים שבו הדף הזה נמצא
                myFram.Navigate(new AddUpdateRecipe(p)); //דפדוף לדף ושליחת פרמטרים  
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new ShowListProduct());
        }
    }
}
