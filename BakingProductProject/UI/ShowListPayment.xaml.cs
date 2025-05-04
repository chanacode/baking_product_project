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
    /// Interaction logic for ShowListPayment.xaml
    /// </summary>
    public partial class ShowListPayment : Page
    {
        public ShowListPayment()
        {
            InitializeComponent();
            lvPayment.ItemsSource = MyDB.kindsOfIndividualsDB.GetKindsOfIndividuals();
        }


        private void lvPayment_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lvPayment.SelectedItem is Payment)
            {
               Payment p = lvPayment.SelectedItem as Payment;//המרת הפריט שנבחר לאוביקט מסוג מוצר
                NavigationService myFram = NavigationService.GetNavigationService(this);//המשתנה מיפריים מחזיק כרגע את הפריים שבו הדף הזה נמצא
               myFram.Navigate(new AddUpdatePayment(p)); //דפדוף לדף ושליחת פרמטרים  
            } 

        }
    }
}
