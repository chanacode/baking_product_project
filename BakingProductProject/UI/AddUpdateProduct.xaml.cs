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
    /// Interaction logic for AddUpdateProduct.xaml
    /// </summary>
    public partial class AddUpdateProduct : Page
    {
        public List<Product> list;
        Product p;
        int status = 1;
        public AddUpdateProduct()
        {
            InitializeComponent();
            p = new Product();
            this.DataContext = p;
            list = new List<Product>();
            List<Product> productsList = MyDB.productDB.GetProductD();
            foreach (var item in productsList)
            {
                //מייצרת יוזר חדש ומוסיפה לסטק
                ucProducts.Children.Add(new CheckProducts(this, item, false));
            }
            //טעינת הערים
            //cmbCity.ItemsSource = Global.sharat.GetAllCities();
        }
    
        public AddUpdateProduct(Product p)
        {
            InitializeComponent();
            this.p = p;
            this.DataContext = p;
            list = MyDB.productDB.GetProductD();
        //טעינת המוצרים
        List<Product> products = MyDB.productDB.GetProductD();
        foreach (var item in products)
        {
            if (products.FirstOrDefault(x => x.productCode == item.productCode) != null)
                ucProducts.Children.Add(new CheckProducts(this, item, true));
            else
                ucProducts.Children.Add(new CheckProducts(this, item, false));

        }
    }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (p.productCode ==0 || p.productName == null || p.available != true)
            {
                txtErorr.Text = "חסרים לך נתונים. כל הנתונים הם שדות חובה. ייתכן שאחד או יותר מהם חסר";
            }
            else
            {
                if (status == 1)
                {
                    //הוספה של העצם לרשימה
                    Global.products.Add(p);
                    txtOkP.Text = " נשמר בהצלחה ";
                }
                else//עדכון
                {
                    //עדכון באקסס חסר בינתיים
                    txtOkP.Text = " עודכן בהצלחה ";
                }
            }
        }
    }
}

