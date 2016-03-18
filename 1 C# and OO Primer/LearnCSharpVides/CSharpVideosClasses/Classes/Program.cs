using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myNewCar = new Car();

            Car myOtherCar = myNewCar;
            Car mysecondCar = myOtherCar;
            Car myCar = myNewCar;

            Console.WriteLine("{0} - {1} - {2} - {3}", 
                myNewCar.Make,
                myOtherCar.Model,
                mysecondCar.Year,
                myCar.Colour);

            // create another reference to myNewCar
            // myNewCar is just an address to the object in memory
            

            // remove references from Car
            // the .NET garage collector will now remove the object created in memory
            myNewCar = null;
            myOtherCar = null;


        }

        
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Colour { get; set; }

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

            Console.WriteLine(lines);
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
}
