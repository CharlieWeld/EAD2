using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a car object of type Vechicle
            Vechicle myNewCar = new Car();

            // create references to the 
            // must explicitly cast to type Car
            // myNewCar is just an address to the object in memory
            Car myOtherCar = (Car)myNewCar;
            Car mySecondCar = myOtherCar;
            Car myCar = (Car)myNewCar;
           
            // remove references from Car
            // the .NET garage collector will now remove the object created in memory
            myNewCar = null;
            myOtherCar = null;

            printVechicleDetails(mySecondCar);

            Truck myTruck = new Truck();
            myTruck.Make = "Ford";
            myTruck.Model = "F950";
            myTruck.Year = 1998;
            myTruck.Colour = "Blue";
            myTruck.TowingCapacity = 30000;

            printVechicleDetails(myTruck);

            Console.ReadLine();


        }

        // Create a helper method
        private static void printVechicleDetails(Vechicle vechicle)
        {
            Console.WriteLine("Here are the vechicles details: {0}", vechicle.FormatMe());
        }

    }
    // Create an abstract base class
    abstract class Vechicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Colour { get; set; }

        public abstract string FormatMe();
    }

    class Car : Vechicle
    {
        

        public Car()
        {
            StreamReader carReader = new StreamReader("cars.txt");

            string line = "", lines = "";


            while (line != null)
            {
                line = carReader.ReadLine();
                if (line != null)
                    lines += line;
                lines += "\r\n";
            }
            carReader.Close();

            // read strings line by line
            StringReader lineReader = new StringReader(lines);

            Make = lineReader.ReadLine();
            Model = lineReader.ReadLine();
            Year = Int32.Parse(lineReader.ReadLine());
            Colour = lineReader.ReadLine();

            //Console.WriteLine(lines);
        }

        public override string FormatMe()
        {
            return String.Format("{0} - {1} - {2} - {3}",
                this.Make,
                this.Model,
                this.Colour,
                this.Year);
        }

        public double DetermineMarketValue()
        {
            double carValue;
            if (this.Year > 1999)
                carValue = 10000;
            else
                carValue = 2000;

            return carValue;
        }
    }

    // sealed means nobody can inherit from Truck
    sealed class Truck : Vechicle
    {
        public int TowingCapacity { get; set; }

        public override string FormatMe()
        {
            return String.Format("{0} - {1} - {2} - {3} - {4}",
              this.Make,
              this.Model,
              this.Colour,
              this.Year,
              this.TowingCapacity);
        }

    }
}

