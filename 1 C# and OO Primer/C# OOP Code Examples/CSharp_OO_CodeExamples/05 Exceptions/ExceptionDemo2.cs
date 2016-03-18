// Exceptions demo - part 2 - handled exception

using System;

/*
A try statement specifies a code block subject to error-handling or clean-up code. The try block must be followed by a catch block,a finally block, or both. The catch block executes when an error occurs in the try block. The finally block executes after execution leaves the try block (or if present, the catch block), to perform clean-up code, whether or not an error occurred.

A catch block has access to an Exception object, which contains information about the error. You use a catch block to either compensate for the error or rethrow the exception. You rethrow an exception if you merely want to log the problem, or if you want to rethrow a new, higher-level exception type.

A finally block adds determinism to your program by always executing no matter what. It's useful for clean-up tasks such as closing network connections.

*/


class Exception2
{
    public static void Main()
    {
        // try/catch lets us handle the exception gracefully and continue execution

        try                                              // try something which might cause an exception
        {
            int x = Int32.Parse("abc");                  // throws FormatException or OverflowException
        }
        catch (FormatException e)                         // catch this type of exception
        {
            Console.WriteLine("Caught a FormatException Exception");
            Console.WriteLine(e.Message);                // display description of error that caused the exception
        }
		
		finally                                                 // always runs whether exception caught or not
        {
            Console.WriteLine("In finally block");         
        }
       
        Console.WriteLine("After try/catch");
    }
}