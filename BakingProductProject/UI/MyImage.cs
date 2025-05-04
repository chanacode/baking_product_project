using BakingProductProject.viewModel;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using System.Drawing;

namespace BakingProductProject.UI
{
    internal class MyImage
    {
        public static string UploadImage_Dlg()
        {
            string filename = null;
            // יצירת אוביקט שיודע לפתוח חלון 
            OpenFileDialog dlg = new OpenFileDialog();
            // קביעת מסנן לבחירת קובץ רק סיומות אלו יוכלו להיבחר 
            dlg.Filter = "All Images | *.jpg;*.jpeg;*.tif;*.tiff;*.bmp;*.png|JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
            //פותח חלונית בחירת תמונה ומחזיר האם נבחרה תמונה 
            Nullable<bool> result = dlg.ShowDialog();
            if (result == true)
            {
                filename = SaveImage(dlg.FileName);
            }
            return filename;
        }


        //  שמירת התמונה בתיקייה המקומית
        public static string SaveImage(string sourcefileName)
        {
            if (sourcefileName != null)
            {
                string fileName = System.IO.Path.GetFileName(sourcefileName);
                string path = BaseDB.GetCurrentPath() + @"Pituer\" + fileName;
                if (!File.Exists(path))
                {

                    byte[] imgArray = File.ReadAllBytes(sourcefileName);
                    var stream = new MemoryStream(imgArray);
                    Image img = Image.FromStream(stream);
                    img.Save(path);
                }
                return fileName;
            }
            return null;
        }
        public static BitmapImage GetImage(string name)
        {
            if (name == null || name == "")
                return null;
            string path = BaseDB.GetCurrentPath() + @"Pituer\" + name;
            if (File.Exists(path))//אם הקובץ לא קיים בתיקייה מקומית
            {
                return new BitmapImage(new Uri(path));
            }
            return null;
        }

    }
}

