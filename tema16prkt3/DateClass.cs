using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema16prkt3
{
    class DateClass
    {
        DateTime data;

        public DateClass()
        {

        }
        public DateClass(int year,int month,int day)
        {
            data = new DateTime(year, month, day);
        }
        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }
        public DateTime NextDay()
        {
            return data.AddDays(1);
        }
        public DateTime BackDay()
        {
            return data.AddDays(-1);
        }
        public int DaysToEnd()
        {
            return DateTime.DaysInMonth(data.Year, data.Month) - data.Day;
        }
    }
}
