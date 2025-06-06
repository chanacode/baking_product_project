﻿using BakingProductProject.model;
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
    /// Interaction logic for ShowListShoppingDetails.xaml
    /// </summary>
    public partial class ShowListShoppingDetails : Page
    {
        
        public ShowListShoppingDetails(Shopping shop)
        {
            InitializeComponent();
            lvShoppingDetails.ItemsSource = MyDB.shoppingDetailsDB.GetShoppingDetails().Where(x => x.shoppingCode.codeShopping == shop.codeShopping);
            //CalumCustomer.Width = 0;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new AddUpdateShopping());
        }


        //private void lvShoppingDetails_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    if (lvShoppingDetails.SelectedItem is ShoppingDetails)
        //    {
        //        ShoppingDetails shd = lvShoppingDetails.SelectedItem as ShoppingDetails;//המרת הפריט שנבחר לאוביקט מסוג מוצר
        //        NavigationService myFram = NavigationService.GetNavigationService(this);//המשתנה מיפריים מחזיק כרגע את הפריים שבו הדף הזה נמצא
        //        myFram.Navigate(new AddUpdateShoppingDetails(shd)); //דפדוף לדף ושליחת פרמטרים  
        //    }

        //}


    }

}
