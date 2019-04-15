using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public static class InputChecker
    {
        public static DateTime ConvertToDate(string stringDate)
        {
            char[] separators = {'.',':','/',' '};
            string[] parsedDate = stringDate.Split(separators);

            if (parsedDate.Length == 3)
            {
                try
                {
                    if (Convert.ToInt32(parsedDate[0]) > 31)
                    {
                        return new DateTime(Convert.ToInt32(parsedDate[0]), Convert.ToInt32(parsedDate[1]), Convert.ToInt32(parsedDate[2]));
                    }
                    else
                    {
                        return new DateTime(Convert.ToInt32(parsedDate[2]), Convert.ToInt32(parsedDate[1]), Convert.ToInt32(parsedDate[0]));
                    }
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Debug.WriteLine("An error occured when constructing a date. Exception message follows");
                    Debug.WriteLine(e.ToString());
                    return DateTime.MinValue;
                }
            }
            return DateTime.Now;
        }

        public static string CheckName(string name)
        {

            string unwanted = "0123456789.,/;'][{}_:";

            foreach (char character in unwanted)
            {
                if (name.Contains(character))
                {
                    return String.Empty;
                }
            }
            return name;

            
        }

        public static string CheckEmail(string email)
        {
            if (email.Contains("@"))
            {
                return email;
            }
            else
            {
                return String.Empty;
            }
        }
    }
}
