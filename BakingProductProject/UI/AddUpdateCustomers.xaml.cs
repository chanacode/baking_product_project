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
    /// Interaction logic for AddUpdateCustomers.xaml
    /// </summary>
    public partial class AddUpdateCustomers : Page
    {
        Customers c;
        int status = 1;
        public AddUpdateCustomers()
        {
            InitializeComponent();
            c = new Customers();
            this.DataContext = c;
        }
        public AddUpdateCustomers(Customers c)
        {
            InitializeComponent();
            this.c = c;
            this.DataContext = c;

        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (c.customerCode == 0 || c.firstName == null || c.secondName == null || c.address == null || c.tel != null || c.password != null || c.userName != null)
            {
                txtErorr.Text = "חסרים לך נתונים. כל הנתונים הם שדות חובה. ייתכן שאחד או יותר מהם חסר";
            }
            else
            {
                bool x = false;
                if (status == 1)
                    x = MyDB.customersDB.Add(c);
                if (status == 2)
                    x = MyDB.customersDB.Update(c);
                if (x)//אם ההוספה או העדכון הצליחו
                {
                    txtOkC.Text = "נשמר בהצלחה";
                    if (Global.IsManager == false && Global.customersUser != null)
                    {
                        //שתי שורות אלו מרוקנות את הדף
                        c = new Customers();
                        if (Global.IsManager)
                        {
                            c = new Customers();
                            this.DataContext = c;
                        }
                    }
                    else
                        txtOkC.Text = "אירעה תקלה במהלך השמירה הנתונים לא נשמרו\n ייתכן שהנתונים שהזנת חסרים או שגויים";

                }

            }


        }

           
        }
    }

