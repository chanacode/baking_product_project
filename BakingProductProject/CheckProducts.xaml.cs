using BakingProductProject.model;
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

namespace BakingProductProject
{
    /// <summary>
    /// Interaction logic for CheckProducts.xaml
    /// </summary>
    public partial class CheckProducts : UserControl
    {
        AddUpdateProduct myProduct;
        Product p;
        public CheckProducts(AddUpdateProduct myProduct, Product p, bool isCheck)
        {
            InitializeComponent();
            this.myProduct = myProduct;
            this.p = p;
            this.DataContext = p;
            check1.IsChecked = isCheck;
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            myProduct.list.Add(p);//מוסיף את המוצר שנבחרה לרשימה בטופס האב
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            myProduct.list.Remove(p);//מסיר את השפה שבוטלה מהרשימה בטופס האב
        }

        private void UserControl_MouseEnter(object sender, MouseEventArgs e)
        {
            stcChoosen.Visibility= Visibility.Visible;
        }

        private void UserControl_MouseLeave(object sender, MouseEventArgs e)
        {
            stcChoosen.Visibility = Visibility.Collapsed;
        }
    }
}
