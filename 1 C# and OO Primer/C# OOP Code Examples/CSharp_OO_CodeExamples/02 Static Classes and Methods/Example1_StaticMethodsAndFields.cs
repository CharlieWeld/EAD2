using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Car
    {
        // ---declare static field   -------
        //(!) A static field is not attached to an instance (ie to car objects created from the car class)
        //(2) A static field is attached to the class itself (its like a global variabel, only one of them exists and its accessed via the class (not instances/objects of the class)
        //(3) Static field must be called using class name=>  Car.CarsInGarage;
        public static int CarsInGarage = 0;

        public string Model { get; set; }

        public Car(string Model = "Not Specified")   //Can set default values for parameters
        {
            this.Model = Model;
            CarsInGarage++;     //NB : can call static member inside any method in the class itself
        }

        //declare static field 
        //A static method is not attached to an instance (ie to car objects created from the car class)
        //Static methods must be called using class name=>  Car.PrintCarCount;   
        public static void PrintCarCount()
        {
            // Model = "";   //ERROR : static method can't access non static variables or methods
            Console.WriteLine("Calling static method 'PrintCarCount' => Total number of cars in garage = " + Car.CarsInGarage);
        }

        public void drive()
        {
            Console.Write("heres is a picture of a car driving\n");

        }

        public override string ToString()
        {
            string output = string.Format("Model = {0}", Model);
            return output;
        }
    }


    class TestClass
    {
        static void Main(string[] args)
        {
            Car c1 = new Car();
            Car c2 = new Car("Ford");
            Car c3 = new Car("Fiat");

            c1.drive();  //instance method : called using the object

            Console.WriteLine("Calling static field 'CarsInGarage' =>  Total number of cars in garage = " + Car.CarsInGarage);  //CarsInGarage field called using the class name!!!

            //--The following line gives an error as Cant access static members from object, have to use class as per line above--
            //Console.WriteLine("Total number of cars in garage is  = " + c3.CarsInGarage);

            //--The following line gives an error as Cant access static methods from object, have to use class as per line above--
            //c1.PrintCarsInGarage();
			
            Car.PrintCarCount();   //PrintCarCount method called using the class name!!!

            Console.ReadLine();

        }
    }

}


