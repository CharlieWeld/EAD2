using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingSwitch
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Type in a super hero's name to see his nickname: ");
            string userValue = Console.ReadLine();

            // Switch is good for many possible cases
            // BUT NOT good for complicated checking (e.g. using OR's AND's and other logic)


            // Use ToUpper() to match text

            switch (userValue.ToUpper())
            {
                case "BATMAN":
                    Console.WriteLine("Caped Crusader");
                    break;

                case "SUPERMAN":
                    Console.WriteLine("Man of Steal");
                    break;

                case "GREENLANTERN":
                    Console.WriteLine("Emerald Knight");
                    break;
                default:
                    Console.WriteLine("Does not compute");
                    break;
            }

            // Switch code snippet
            /*switch (switch_on)
            {
                default:
            }*/

            

        }
    }
}
