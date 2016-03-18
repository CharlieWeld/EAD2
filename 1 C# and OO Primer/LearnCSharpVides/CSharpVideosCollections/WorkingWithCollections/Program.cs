using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Car car1 = new Car();
            car1.Model = "Hitachi";
            Car car2 = new Car();
            Book book1 = new Book();
            */
            
            // 1. Collections ArrayLists

            // 2. Dictionaries
            // Key value Pair
            Dictionary<string, Car> myDict = new Dictionary<string, Car>();

            //myDict.Add("Ford", car1);
            //myDict.Add("Toyota", car2);

            //Console.WriteLine(myDict["Ford"]);
            /*
            // 3. Generic Collection
            // Its generic collection until you make it specific 
            // by specify its data type
            List<Car> myList = new List<Car>();

            myList.Add(car1);
            myList.Add(car2);

            foreach (Car car in myList)
            {
                // No Casting
                Console.WriteLine(car.Model);
            }
            */
            // Object Initialisers
            Car car1 = new Car() { Make = "VW", Model = "Jetta" };
            Car car2 = new Car() { Make = "Nissan", Model = "Skyline" };

            // Collection Initialisers
            // List keeps a reference for each object
            List<Car> myList = new List<Car>() {
                new Car { Make = "Toyota", Model = "Supra" },
                new Car { Make = "Honda", Model = "S2000" }
                };

            foreach (var item in myList)
            {
                Console.WriteLine(item.Model);
            }


            Console.ReadLine();
            
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }

    }

    class Book
    {

    }
}
