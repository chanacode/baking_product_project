using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using BakingProductProject.viewModel;
using System.Windows.Media.Imaging;
using Microsoft.Win32;

namespace BakingProductProject
{
    public class UsingCakes//מחלקה לפעולות שרות בעניין תמונות
    {
        public static BitmapImage GetImage(string name)
        {
            if (name == null || name == "")
                return null;
            string path = BaseDB.GetCurrentPath() + @"MyPictures\" + name;
            if (File.Exists(path))
            {
                return new BitmapImage(new Uri(path));
            }
            return null;
        }
        public static string SaveImage(string sourcefileName)
        {
            if (sourcefileName != null)
            {
                string fileName = System.IO.Path.GetFileName(sourcefileName);//חותכת את שם הקובץ
                string path = BaseDB.GetCurrentPath() + @"Pictures\" + fileName;//מייצר נתיב חדש ממיקום התיקייה פלוס שם הקובץ
                if (!File.Exists(path)) //אם הקובץ הזה לא קיים כבר בתיקייה
                {
                    byte[] imgArray = File.ReadAllBytes(sourcefileName);   //קוראת את הקובץ לתוך מערך ביטים
                    var stream = new MemoryStream(imgArray);//מייצרת ממנו אובייקט חדש
                    System.Drawing.Image img = System.Drawing.Image.FromStream(stream);
                    img.Save(path);//שומרת בנתיב לתיקייה שלנו
                }
                return fileName;
            }
            return null;
        }
        public static string AddPicture()
        {
            string filename = null;
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "All Images | *.jpg;*.jpeg;*.tif;*.tiff;*.bmp;*.png|JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
            Nullable<bool> result = dlg.ShowDialog();
            if(result==true)
            {
                filename = SaveImage(dlg.FileName);
            }
            return filename;



        }
    }
}
