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
            //Задание 1
            DateClass date = new DateClass(2024, 01, 27);

            //DateTime date2 = DateTime.Now;
            Console.WriteLine($"{date.Data.ToShortDateString()}");
            Console.WriteLine($"Предыдущий день : {date.BackDay().ToShortDateString()}");
            Console.WriteLine($"Следующий день : {date.NextDay().ToShortDateString()}");
            Console.WriteLine($"Дней до конца месяца : {date.DaysToEnd()}");

            //Задание 2
            Console.WriteLine("\tДля определения разницы между датами в днях");
            Console.Write("Введите первую дату: ");
            DateTime date1 = DateTime.Parse(Console.ReadLine());
            Console.Write("Введите вторую дату: ");
            DateTime date2 = DateTime.Parse(Console.ReadLine());
            Console.WriteLine($"\nРазница между датами в {date1.Subtract(date2).ToString("dd")} дней\n");

            //Задание 3
            Console.Write("Введите время 1 процедуры ");
            DateTime date3 = DateTime.Parse(Console.ReadLine());

            Console.Write("Введите время следующей процедуры ");
            DateTime date4 = DateTime.Parse(Console.ReadLine());

            double interval = Math.Abs((date3 - date4).TotalMinutes);
            Console.WriteLine($"Интервал между процедурами - {interval} min");

            Console.Write("Количество процедур: ");
            int count = int.Parse(Console.ReadLine());

            int i = 3;

            DateTime time = date4;

            Console.WriteLine($"\tВремя 1 процедуры: {date3.ToShortTimeString()} ");
            Console.WriteLine($"\tВремя 2 процедуры: {date4.ToShortTimeString()} ");

            while (i<=count)
            {
                time = time.AddMinutes(interval);
                
                Console.WriteLine($"\tВремя {i} процедуры: {time.ToShortTimeString()}");
                i++;
            }
            

            Console.ReadKey();
        }
    }
}
