using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnYieldDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var day = GetDays();
            //Console.WriteLine(day.Take(1).SingleOrDefault());
            //Console.WriteLine(day.Skip(1).Take(1).SingleOrDefault());
            foreach (var item in day)
            {
                Console.WriteLine(item);
            }
        }

        static IEnumerable<string> GetDays() {

            yield return "Понедельник";
            yield return "Вторник";
        }
    }
}
