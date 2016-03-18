// Program to convert a temperature in degrees Fahrenheit to degrees Celsius

using System;

// in the default namespace

class FahrenheitToCelsius
{
   public static void Main()
   {
       // 2 constants
      const int Base = 32;                                  // Pascal casing for constants
      const double ConversionFactor = 5.0 / 9.0;

      // 2 variables
      double fahrenheitTemp = 35;           // value to convert
      double celsiusTemp;                   // unassigned at the moment

      // apply the formula
      celsiusTemp = ConversionFactor * (fahrenheitTemp - Base);

      // print the results
      Console.WriteLine(fahrenheitTemp + " Fahrenheit" + " is " + celsiusTemp + " Celsius");
   }
}