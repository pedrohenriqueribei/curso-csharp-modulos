using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


    
    public static class DateTimeExtensions
    {
        public static string Elapsed(this DateTime thisObj)
        {
            TimeSpan duration = DateTime.Now - thisObj;

            if (duration.TotalHours < 24.0)
            {
                return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " hours";
            }
            else
            {
                return duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " days";
            }

        }
    }

