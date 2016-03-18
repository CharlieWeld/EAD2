// arrays
// an array of chars, initialised to specified values

using System;

namespace Arrays
{
    class Sentence
    {
        private static void Main()          
        {
            // an array of chars, initialised to non default values, this is like a string
            char[] sentence = {'H', 'e', 'l', 'l', 'o', ' ', 'W', 'o', 'r', 'l', 'd'};     // initial values can be specified by a variable                     
             
            // print the sentence
            for (int i = 0; i < sentence.Length; i++)
            {
                Console.Write(sentence[i]);
            }

            Console.WriteLine();

            // print the backwards
            for (int i = sentence.Length - 1; i >= 0; i--)
            {
                Console.Write(sentence[i]);
            }

            Console.WriteLine();

            // print 1st char
            Console.WriteLine(sentence[0]);

            // print last char
            Console.WriteLine(sentence[sentence.Length-1]);
        }
    }
}

