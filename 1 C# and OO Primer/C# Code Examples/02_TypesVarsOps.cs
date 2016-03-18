// demo of types, variables and operators

// single line comment

/* the is a 
 * block
 * of comments
 */

 
using System;						

namespace TypesVarsOps                      // a custom namespace
{
    class Demo                              // a class
    {
        // the application entry point 
        private static void Main()          // a method inthe  Demo class
        {
            int a = 5;                      // integer variable - 32 bit value				

            long b;
            b = 5555555555;                 // 64 bit value
            Console.WriteLine(b);            

            // arithmetic expression involving operators and operands
            int answer = a + 4 * 3 - 7;     // precedence and associativity
            Console.WriteLine(answer);      // 10

            // to override precedence and assoicativity rules use brackets
            answer = (a + 4) * 3 - 7;
            Console.WriteLine(answer);      // 20

            // modulus
            Console.WriteLine(10 % 4);      // 2
           
            float radius = 10.5F;           // floating point literal
            const double pi = 3.1417;       // a constant never changes value and must be assigned when declared

            // calculate the area of a circle
            double area = pi * (radius * radius);
            Console.WriteLine(area);

            // * / + - %
           
            // a string of characters, a reference type
            String sentence = "This is a String";

            // a single character
            char fullStop = '.';            // 16 bit Unicode

            Console.Write(sentence);
            Console.WriteLine(fullStop);
            
            // boolean type
            bool isRaining = true;          // it is raining at the moment, camel case
            isRaining = false;              // it is not raining at the moment
            Console.WriteLine("Raining at the moment:" + isRaining);
  
            int age = 35;
            Console.WriteLine("My age " + age);   
            
            // it's my birthday
            age++;
            Console.WriteLine("My age is now " + age);               // String concatenation

            var aChar = 'a';                // implicitly typed as char

        }
    }
} 
	


