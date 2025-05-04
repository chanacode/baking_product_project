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
    /// Interaction logic for ShowListComments.xaml
    /// </summary>
    public partial class ShowListComments : Page
    {
        public ShowListComments()
        {
            InitializeComponent();
            lvComments.ItemsSource = MyDB.commentsDB.GetCommentsDB();//טעינת הנתונים בליסט ויו
        }
        
        private void lvProduct_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (lvComments.SelectedItem is Comments)
            {

                Comments c = lvComments.SelectedItem as Comments;
                NavigationService myFram = NavigationService.GetNavigationService(this);//המשתנה מיפריים מחזיק כרגע את הפריים שבו הדף הזה נמצא
                myFram.Navigate(new AddUpdateRecipe()); //דפדוף לדף ושליחת פרמטרים  
            }
        }
    }
}
