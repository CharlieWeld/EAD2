// methods and parameter passing

using System;

/*  When passing parameter into a method remeber
 *   -  we never actuallly pass the type/object in: a new type/object is created in the method and the value copied to that object/type 
 */

namespace MethodsandParameters
{
    class foo
    {
        public static void change(int param)
        {
            Console.WriteLine("Change method : COPY of x is passed in (value of x is copied to param)");
            param++;
            Console.WriteLine("param = " + param + ".  The COPY of x was incremented");

        }

        public static void change_usingref(ref int param)
        {
            Console.WriteLine("change_usingref  method : COPY of reference to x is passed in (refernce to x is copied to param");
            param++;
            Console.WriteLine("what was referenced to was incremented : both x and param reference the same thing => both will see the incremented value");
        }
    }


    class Test
    {
        private static void Main()
        {
            int x;

            x = 10;
            foo.change(x);    //pass by value => x will not change			
            Console.WriteLine(x);		// prints 10
            foo.change_usingref(ref x);  //pass by value => x will change
            Console.WriteLine(x);		// 11
        }
    }
}



