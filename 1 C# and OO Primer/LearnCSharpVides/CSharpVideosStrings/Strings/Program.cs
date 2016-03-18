using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 1. Escape character \ (backslash)
// - put the backslash in front of a character such as the quote
namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. escape character
            //string myString = "this \"is my c:\\\" drive";

            // 2. String.Format
            string yourString = String.Format("{0}!", "Bonzai");

            // 3. number formating
            //string string1 = String.Format("{0:N}", 124345678.987);
            //string string1 = String.Format("{0:C}", 123.44);
            //string string1 = String.Format("Phone Number: {0:(###) ###-####}", 1274517789);
            //Console.WriteLine(string1);

            // 4. Using string builder if strings are going to be concatenated
            /*
            StringBuilder myString = new StringBuilder();

            for (int i = 0; i < 100; i++)
            {
                myString.Append(i);
                myString.Append('-');
            }

            Console.WriteLine(myString);
            */
            string string3 = " Poor Jenny got lost in the city   ";

            //string3 = string3.Substring(0, 4);
            //string3 = string3.ToUpper();
            //string3 = string3.Replace(' ', '*');
            string string4 = String.Format("Lenght {0} - without spaces {1} ", string3.Length, string3.Trim().Length);

            Console.WriteLine(string4);

        }
    }
}
