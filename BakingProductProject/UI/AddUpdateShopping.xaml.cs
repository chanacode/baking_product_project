using BakingProductProject.model;
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
using static System.Net.Mime.MediaTypeNames;

namespace BakingProductProject.UI
{
    /// <summary>
    /// Interaction logic for AddUpdateShopping.xaml
    /// </summary>
    public partial class AddUpdateShopping : Page
    {
        int status = 1;
        Shopping sh;
        public AddUpdateShopping()
        {
            InitializeComponent();
            sh = new Shopping();
            this.DataContext = sh;
        }
        public AddUpdateShopping(Shopping sh)
        {

            InitializeComponent();
            this.sh = sh;
            this.DataContext = sh;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (sh.codeShopping == 0 || sh.dateShopping == null || sh.amountForPaying == 0)
            {
                txtErorr.Text = "חסרים לך נתונים. כל הנתונים הם שדות חובה. ייתכן שאחד או יותר מהם חסר";
            }
            else
            {
                if (status == 1)
                {
                    //הוספה של העצם לרשימה
                    Global.shoppingList.Add(sh);
                    txtOkSh.Text = " נשמר בהצלחה ";
                }
                else//עדכון
                {
                    //עדכון באקסס חסר בינתיים
                    txtOkSh.Text = " עודכן בהצלחה ";
                }
            }
        }
    }
}
