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
using BakingProductProject.UI;

namespace BakingProductProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Page
    {
        public MainWindow()
        {
            InitializeComponent();
           
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            myFram.Navigate(new AddUpdateRecipe());
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            myFram.Navigate(new AddUpdateProduct());//דפדוף לתוך פריים קיים בדף שלנו
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            myFram.Navigate(new ShowListProduct());
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            myFram.Navigate(new ShowListCustomers());
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            myFram.Navigate(new ShowListRecipe());
        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            myFram.Navigate(new ShowListShopping());
        }

        private void MenuItem_Click_6(object sender, RoutedEventArgs e)
        {
            myFram.Navigate(new AddUpdateShopping());
        }

        private void MenuItem_Click_7(object sender, RoutedEventArgs e)
        {
            myFram.Navigate(new AddUpdateCustomers());
        }
    }
    }

