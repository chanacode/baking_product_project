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

namespace BakingProductProject.UI
{
    /// <summary>
    /// Interaction logic for AddUpdatePayment.xaml
    /// </summary>
    public partial class AddUpdatePayment : Page
    {
        int status = 1;
        Payment pay;
        public AddUpdatePayment()
        {
            InitializeComponent();
            pay = new Payment();
            this.DataContext = pay;
        }
        public AddUpdatePayment(Payment pay)
        {
            InitializeComponent();
            this.pay = pay;
            this.DataContext = pay;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (pay.paymentCode == 0 || pay.paymentDate == null || pay.sum==0 || pay.cardNumber == null || pay.validNumber == null || pay.cvv == 0 || pay.codeShopping == null)
            {
                txtErorr.Text = "חסרים לך נתונים. כל הנתונים הם שדות חובה. ייתכן שאחד או יותר מהם חסר";
            }
            else
            {
                if (status == 1)
                {
                    //הוספה של העצם לרשימה
                    Global.paymentList.Add(pay);
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

