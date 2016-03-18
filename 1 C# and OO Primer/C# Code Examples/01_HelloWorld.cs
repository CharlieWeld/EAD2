// HelloWorld.cs - my first program

using System;						// bring System namespace into scope

class HelloWorld                                                // a class
{
	// the application entry point 
	private static void Main()                                  // a method
	{
		Console.WriteLine("Hello there C# and .NET World!");	// a statement, all statements finish with ;
	}			
}


// go to VS 2010 command prompt
// csc HelloWorld.cs - produces HelloWorld.exe (a .NET PE)
// run & managed by the CLR

// this is an applicaiton application (.exe)
// assemblies are either applications or libraries
// if there was no entry point (Main) then it would be a library assembly (.dll)