﻿using System;
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
    /// Interaction logic for LoginPrincipal.xaml
    /// </summary>
    public partial class LoginPrincipal : Page
    {
        public LoginPrincipal()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           if (txtPassword.Password == "מנהל")
            {
                txtPassword.Password = "";
               txtPassword.Password = "";
               Global.IsManager = true;
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
