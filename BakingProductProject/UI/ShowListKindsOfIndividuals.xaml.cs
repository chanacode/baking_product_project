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
    /// Interaction logic for ShowListKindsOfIndividuals.xaml
    /// </summary>
    public partial class ShowListKindsOfIndividuals : Page
    {
        public ShowListKindsOfIndividuals()
        {
            InitializeComponent();
            lvKindsOfIndividuals.ItemsSource = MyDB.kindsOfIndividualsDB.GetKindsOfIndividuals();
        }

        private void lvKindsOfIndividuals_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lvKindsOfIndividuals.SelectedItem is KindsOfIndividuals)
            {
                KindsOfIndividuals k = lvKindsOfIndividuals.SelectedItem as KindsOfIndividuals;//המרת הפריט שנבחר לאוביקט מסוג מוצר
                NavigationService myFram = NavigationService.GetNavigationService(this);//המשתנה מיפריים מחזיק כרגע את הפריים שבו הדף הזה נמצא
                myFram.Navigate(new AddUpdateKindOfIndividuals(k)); //דפדוף לדף ושליחת פרמטרים  
            }
        }
    }
}
