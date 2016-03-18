// demo of Console I/O - reading input from the keyboard and printing to the screen

using System;						

namespace ConsoleIO
{
    class Demo          
    {
        // the application entry point 
        private static void Main() 
        {
            Console.Write("Please enter your name: ");
            String name = Console.ReadLine();                           // read a String from the console

            Console.Write("Please enter your age: ");
            int age = Int32.Parse(Console.ReadLine());                  // convert the String to an int

            Console.Write("Please enter your height in metres: ");
            double height = Double.Parse(Console.ReadLine());           // convert the String to a double

            Console.WriteLine("Hello " + name + " your age is " + age + " and your height is " + height + " metres");
            
        }
    }
} 
	


