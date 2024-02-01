using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema16prkt3
{
    class Program
    {
        static void Main(string[] args)
        {
            DateClass date = new DateClass(2024,01,27);
            
            //DateTime date2 = DateTime.Now;
            Console.WriteLine($"{date.Data.ToShortDateString()}");
            Console.WriteLine($"Предыдущий день : {date.BackDay().ToShortDateString()}");
            Console.WriteLine($"Следующий день : {date.NextDay().ToShortDateString()}");
            Console.WriteLine($"Дней до конца месяца : {date.DaysToEnd()}");

            DateTime date1 = DateTime.Parse(Console.ReadLine());
            DateTime date2 = DateTime.Parse(Console.ReadLine());
            Console.WriteLine($"Разница между датами в {date1.Subtract(date2).ToString("dd")} дней");

            
            Console.ReadKey();
        }
    }
}
