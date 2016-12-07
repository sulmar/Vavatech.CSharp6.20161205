using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Vavatech.CSharp6.Extensions
{
    // Extensions method
    static class DateTimeExtensions
    {
        public static bool IsHoliday(this DateTime date)
        {
            return date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday;
        }

        public static bool IsValid(this HttpClient client)
        {
            return true;
        }
    }
}
