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
    /// Interaction logic for AddUpdateKindOfIndividuals.xaml
    /// </summary>
    public partial class AddUpdateKindOfIndividuals : Page
    {
        KindsOfIndividuals k;
        int status = 1;
        public AddUpdateKindOfIndividuals()
        {
            InitializeComponent();
            k = new KindsOfIndividuals();
            this.DataContext = k;
        }
        public AddUpdateKindOfIndividuals(KindsOfIndividuals k)
        {
            InitializeComponent();
            this.k = k;
            this.DataContext = k;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (k.unitTypeCode == 0 || k.unitTypeName == null)
            {
                txtErorr.Text = "חסרים לך נתונים. כל הנתונים הם שדות חובה. ייתכן שאחד או יותר מהם חסר";
            }
            else
            {
                if (status == 1)
                {
                    //הוספה של העצם לרשימה
                    Global.KindsOfIndividualsList.Add(k);
                    txtOkK.Text = " נשמר בהצלחה ";
                }
                else//עדכון
                {
                    //עדכון באקסס חסר בינתיים
                    txtOkK.Text = " עודכן בהצלחה ";
                }
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}




    