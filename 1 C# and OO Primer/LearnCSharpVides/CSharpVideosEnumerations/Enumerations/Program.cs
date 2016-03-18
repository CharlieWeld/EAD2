using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            //Console.WriteLine("Hello World!");

            Console.WriteLine("Type in a superhero's name to see his nickname: ");
            string userValue = Console.ReadLine();
            SuperHero myValue = SuperHero.Superman;

            if (Enum.TryParse<SuperHero>(userValue, true, out myValue))
            { 
                switch (myValue)
                {
                    case SuperHero.Batman:
                        Console.WriteLine("Caped Crusader");
                        break;
                    case SuperHero.Superman:
                        Console.WriteLine("Man of Steel");
                        break;
                    case SuperHero.GreenLantern:
                        Console.WriteLine("Emerald Knight");
                        break;
                    default:
                        
                        break;
                }
            }
            else
                Console.WriteLine("Wrong");
            Console.ReadLine();
        }
    }

    // Create an enumerator
    enum SuperHero
    {
        Batman,
        Superman,
        GreenLantern
    }
}
