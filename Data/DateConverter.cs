using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public static class DateConverter
    {

        public static DateTime ConvertToDate(string stringDate)
        {
            string[] parsedDate = stringDate.Split('.');
            DateTime myDate = new DateTime(Convert.ToInt32(parsedDate[2]), Convert.ToInt32(parsedDate[1]), Convert.ToInt32(parsedDate[0]));

            return myDate;
        }


    }
}
