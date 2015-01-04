using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exstensions;

namespace ExstensionExamples
{
    class Program
    {
        IEnumerable<String> cities = new[] { "Portsmouth", "Southampton", "London" };
        static void Main(string[] args)
        {
            //var date = new DateTime(2014, 11, 21);
            //Console.WriteLine(date.DayeToEndOfMonth());
            IEnumerable<String> cities = new[] { "Portsmouth", "Southampton", "London" };
            foreach (var item in cities.MyStartsWith("P"))
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }

    }           
   }
namespace Exstensions
{
    public static class Exstension
    {
        public static int DayeToEndOfMonth(this DateTime date)
        {
            return DateTime.DaysInMonth(date.Year, date.Month) - date.Day;
        }

        public static IEnumerable<String> MyStartsWith(this IEnumerable<String> input, String start)
        {
            foreach (var item in input)
            {
                if (item.StartsWith(start))
                {
                    yield return item;
                }
            }
        }
    }
}
