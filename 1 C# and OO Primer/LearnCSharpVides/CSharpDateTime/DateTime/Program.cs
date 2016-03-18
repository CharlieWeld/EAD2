using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myValue = DateTime.Now;

            //Console.WriteLine(myValue.ToShortTimeString());
            //Console.WriteLine(myValue.ToShortDateString());
            //Console.WriteLine(myValue.ToLongDateString());

            // Math with DateTime
            myValue.AddDays(3);
            //Console.WriteLine(myValue.ToLongDateString());
            //Console.WriteLine(myValue.AddHours(3).ToLongTimeString());

            //Console.WriteLine(myValue.AddDays(-3).ToString());

            DateTime time = DateTime.Now;

            // returns the month in the year eg. 2 for feb
            //Console.WriteLine(time.Month.ToString());

            // use constructor to create a date time
            DateTime myDTime = new DateTime(1977, 12, 3, 15,2,34);
            Console.WriteLine(myDTime.ToString());

            // Get time elapsed using TimeSpan
            DateTime myBirthday = DateTime.Parse("12/4/1988");
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);

            Console.WriteLine(myAge.);

        }
    }
}
