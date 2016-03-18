// demo of Strings

using System;						

namespace Strings                   
{
    class Demo                        
    {
        private static void Main()
        {
            // Strings are reference types - they are not the same as value types (int, long, float, double, bool, char)
            // Strings contain sequences of characters

            String message = "hello there";
            Console.WriteLine(message);

            // the String class has lots of useful members
            Console.WriteLine(message.Length);                  // 11
            Console.WriteLine(message.ToUpper());               // creates a new string with everything converted to upper case
            Console.WriteLine(message[0]);                      // messages[0] gets the character at position 0 in the string, positions are 0 to Length - 1

            message = message + " world!";                      // string concatenation

            bool match;
            match = message == "hello there world!";        //setting match to true as  message is equal to  "hello there world!"
            Console.WriteLine(match);       // true

            match = message == "Hello there world!";      //setting match to false as  message is not equal to  "Hello there world!"  (Capital H in hello)
            Console.WriteLine(match);       // false

        }
    }
} 
	


