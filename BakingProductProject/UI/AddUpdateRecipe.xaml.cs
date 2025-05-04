using BakingProductProject.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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
    /// Interaction logic for AddUpdateRecipe.xaml
    /// </summary>
    public partial class AddUpdateRecipe : Page
    {
        int status = 1;
        Recipe r;
        public AddUpdateRecipe()
        {
            InitializeComponent();
            r = new Recipe();
            this.DataContext = r;
        }
        public AddUpdateRecipe(Recipe r)
        {

            InitializeComponent();
            this.r = r;
            this.DataContext = r;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (r.recipeCode == 0 || r.recipeName == null || r.difficulityLevel == null || r.preparationTime == 0 || r.numbersOfServings == 0 || r.parveOrDairy == null || r.AllProductAvailabe == true || r.like == 0 || r.pictureOfRecipe == null )
            {
                txtErorr.Text = "חסרים לך נתונים. כל הנתונים הם שדות חובה. ייתכן שאחד או יותר מהם חסר";
            }
            else
            {
                if (status == 1)
                {
                    //הוספה של העצם לרשימה
                    Global.recipe.Add(r);
                    txtOkR.Text = " נשמר בהצלחה ";
                }
                else//עדכון
                {
                    //עדכון באקסס חסר בינתיים
                    txtOkR.Text = " עודכן בהצלחה ";
                }
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string fileName = MyImage.UploadImage_Dlg();
            r.pictureOfRecipe = fileName;
            image1111.Source = MyImage.GetImage(fileName);
        }
    }
    }


