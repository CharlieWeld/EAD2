// for loop with nested if
// a program which prints the odd digits


//Notice in this loop we are using  'i<10' and not  'i<=10' as in previosu exampls
//Easier to mqke mistakes because we use < when we should be using  <= or vise-versa
// The lop below lopps from 0 up to  (but not inclusing 10)
// ie,  0,1, 2,3,4,5,6,7,8,9     (this is 10 times because we started at 0)

using System;

namespace Iteration
{
    class OddDigits
    {
        private static void Main()          
        {
            for (int i=0; i < 10; i++)           // 0..9
            {
                if (i % 2 != 0)                   // i is odd
                Console.WriteLine(i);
            } 
        }
    }
}



