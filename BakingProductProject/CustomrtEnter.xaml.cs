using BakingProductProject.UI;
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


namespace BakingProductProject
{
    /// <summary>
    /// Interaction logic for CustomrtEnter.xaml
    /// </summary>
    public partial class CustomrtEnter : Page
    {
        public CustomrtEnter()
        {
            InitializeComponent();
            txtName.Text = Global.customersUser.firstName + " " + Global.customersUser.secondName;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            myFrame.Navigate(new AddUpdateCustomers(Global.customersUser));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Global.customersUser = null;
            NavigationService fram = NavigationService.GetNavigationService(this);
            fram.Navigate(new Login());
        }

        //private void Button_Click_2(object sender, RoutedEventArgs e)
        //{
        //    myFrame.Navigate(new add(Global.customersUser));להכניס בהמשך לaddUpdateShoppingDetauls
        //}
    }
}
