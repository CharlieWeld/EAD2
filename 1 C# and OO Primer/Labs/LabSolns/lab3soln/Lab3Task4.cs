// Coinage problem

using System;

class Coinage
{
   public static void Main()
   {

        Console.Write("Please enter the total amount of coinage (cents): ");
        int totalCoinage = Int32.Parse(Console.ReadLine());

        int coinageLeft = totalCoinage;

        int fifties = coinageLeft / 5000;		                // how many 50s?		
	    coinageLeft = coinageLeft % 5000;

        int twenties = coinageLeft / 2000;                      // how many 20s?
	    coinageLeft = coinageLeft % 2000;

        int tens = coinageLeft / 1000;                          // how many 10s?
	    coinageLeft = coinageLeft % 1000;

        int fives = coinageLeft / 500;                          // how many 5s?
        coinageLeft = coinageLeft % 500;                        // left over change

        Console.WriteLine(fifties + " 50s " + twenties + " 20s " + tens + " 10s " + fives + " 5s " + coinageLeft + " change");
   }
}

