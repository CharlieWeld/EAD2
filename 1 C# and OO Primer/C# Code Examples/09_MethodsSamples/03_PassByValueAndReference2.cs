// methods and parameter passing

using System;						

namespace MethodsandParameters                    
{
    class Integer
    {
        public int value;                           // avoid using public
    }

    class PassByValueAndReference
    {
        public static void Increment(int i)
        {
            i++;                                    // increment the copy
        }

        public static void Increment(Integer i)
        {
            i.value++;                            // access the same object on heap via a copy of the reference
        }
    }
          
    class Test
    {
        private static void Main()          
        {
            int j = 5;
            PassByValueAndReference.Increment(j);              // pass by value
            Console.WriteLine(j);                               // still 5, not 6

            Integer k = new Integer();
            k.value = 5;
            PassByValueAndReference.Increment(k);              // pass by value - of a reference
            Console.WriteLine(k.value);                         // 6
        }
    }
} 
	


