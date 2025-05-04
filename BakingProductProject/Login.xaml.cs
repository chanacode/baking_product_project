using BakingProductProject.UI;
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

namespace BakingProductProject
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            txtError.Visibility = Visibility.Collapsed;
            Global.customersUser = MyDB.customersDB.GetCustomers().FirstOrDefault(x => x.firstName == txtId.Text && x.secondName == txtId.Text);
            if (Global.customersUser != null)
            {
                txtId.Text = "";
                NavigationService nav = NavigationService.GetNavigationService(this);
                nav.Navigate(new CustomrtEnter());
            }
            else
            {
                //    Global.customersUser = MyDB.customers(txtId.Text);
                if (Global.customersUser != null)
                {
                    txtId.Text = "";

                    NavigationService nav = NavigationService.GetNavigationService(this);//לבדק האם לעשות בדיקה לעובד
                    nav.Navigate(new WorkerEnter());

                }
                else
                {
                    if (txtId.Text == "אני מנהל")
                    {
                        Global.IsManager = true;
                        txtId.Text = "";

                        NavigationService nav = NavigationService.GetNavigationService(this);
                        nav.Navigate(new MainWindow());
                    }
                    else
                    {
                        txtError.Visibility = Visibility.Visible;
                    }
                }
            }



        }

        private void btnAddCustomer_Click(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new AddUpdateCustomers());
        }

    }
}

