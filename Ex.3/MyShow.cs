using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._3
{
    static class MyShow
    {
        public static void Print(this DateTime dateTime)
        {
            Console.WriteLine($"День {dateTime.Day} месяца {dateTime.Month} года {dateTime.Year + 5501} от сотворения мира.");
        }
    }
}
