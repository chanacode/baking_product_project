using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Globalization;
using System.Text.RegularExpressions;


namespace BakingProductProject.UI
{
    public class HebrewValide : ValidationRule//עברית בלבד
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string s = value.ToString();
            for (int i = 0; i < s.Length; i++)
            {
                if ((s[i] < 'א' || s[i] > 'ת') && s[i]!=' ' && s[i]!= '"' && s[i] != '\'')
                    return new ValidationResult(false, "!!!!!!!!!!!!!!!!!!!!!!!הכנס ערך באותיות עברית בלבד");
            }
            return ValidationResult.ValidResult;
        }
    }
    class PhoneValide : ValidationRule//טלפון או פלאפון
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            //בניית מחרוזת שמהווה את הרצף של הבדיקה
            string pattern = @"\b0[2 4 7 8 3 77 73 72][1-9]\d{6}$";
            //יצרת עצם שיודע לבדוק לפי המחרוזת
            Regex reg = new Regex(pattern);

            //בניית מחרוזת שמהווה את הרצף של הבדיקה
            string pattern1 = @"\b05[2 3 4 5 6 7 8 0]\d{7}$";
            //יצרת עצם שיודע לבדוק לפי המחרוזת
            Regex reg1 = new Regex(pattern1);

            if (reg.IsMatch(value.ToString()) || reg1.IsMatch(value.ToString()))//תקין
                return ValidationResult.ValidResult;
            else
                return new ValidationResult(false, "הקש מספר טלפון תקין");
        }
    }

    class MailValide : ValidationRule//מייל
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            //בדיקה שיש במחרוזת את הסימן שטרודל וגם יש נקודה והיא ממוקמת אחרי השטרודל
            if (value.ToString().IndexOf('@') != -1 && value.ToString().LastIndexOf('.') > value.ToString().IndexOf('@'))//תקין
                return ValidationResult.ValidResult;
            else
                return new ValidationResult(false, "הקש מייל תקין");
        }
    }
    class IdValide : ValidationRule//תעודת זהות
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string s = value.ToString();
            int x;
            if (!int.TryParse(s, out x))
                return new ValidationResult(false, "תעודת זהות צריכה להכיל מספרים בלבד"); ;
            if (s.Length < 5 || s.Length > 9)
                return new ValidationResult(false, "האורך אינו תקין"); ;
            for (int i = s.Length; i < 9; i++)
                s = "0" + s;
            int sum = 0;
            for (int i = 0; i < 9; i++)
            {
                int k = ((i % 2) + 1) * (Convert.ToInt32(s[i]) - '0');
                if (k > 9)
                    k -= 9;
                sum += k;
            }
            //בדיקה
            if (sum % 10 == 0)//תקין
                return ValidationResult.ValidResult;
            else
                return new ValidationResult(false, "תעודת זהות לא תקינה");
        }
    }
    class NumValide : ValidationRule//מספר
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string s = value.ToString();
            int x;
            if (!int.TryParse(s, out x))
                return new ValidationResult(false, "הכנס מספר בלבד");
           else
                return ValidationResult.ValidResult;
        }
    }
    class PasswordValide : ValidationRule//סיסמא
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            string s = value.ToString();
            int x;
            if (!int.TryParse(s, out x))
                return new ValidationResult(false, "הכנס לפחות 5 ספרות  ");
            else
                return ValidationResult.ValidResult;
        }
    }
}

//class  הבדיקהValide : ValidationRule
//{
//    public override ValidationResult Validate(object value, CultureInfo cultureInfo)
//    {
//        //בדיקה
//        if ()//תקין
//            return ValidationResult.ValidResult;
//        else
//            return new ValidationResult(false, "הודעה מתאימה");
//    }
//}
