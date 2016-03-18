using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            // List intialiser
            List<Car> myCars = new List<Car>()
            {
                new Car() {Make="BMW", Model="550i", Colour=CarColour.Blue, StickerPrice=55000, Year=2009 },
                new Car() {Make="Ford", Model="Mustang", Colour=CarColour.Red, StickerPrice=60000, Year=2015 },
                new Car() {Make="Ford", Model="GT40", Colour=CarColour.White, StickerPrice=200000, Year=2016 },
                new Car() {Make="Pagani", Model="Zonda", Colour=CarColour.Black, StickerPrice=600000, Year=2014 },
                new Car() {Make="Ferrari", Model="360", Colour=CarColour.Red, StickerPrice=500000, Year=2010 }
            };

            // Method syntax
            var _bmws = myCars.Where(p => p.Year == 2010).Where(p => p.Make == "BMW");

            var _orderedCars = myCars.OrderByDescending(p => p.Year);

            var sumCars = myCars.Sum(p => p.StickerPrice);

            var allCars = from car in myCars
                          orderby car.Year
                          select car;

            // SQL syntax
            // Language Integrated 
            var bmws = from car in myCars
                       where car.Make == "Ford"
                       && car.Year == 2016
                       select new { car.Make, car.Model, car.Colour };

            foreach (var car in _orderedCars)
            {
                Console.WriteLine("{0}-{1}-{2}", car.Make, car.Model, car.Colour);
            }

            Console.ReadLine();
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double StickerPrice { get; set; }
        public CarColour Colour { get; set; }

    }

    enum CarColour
    {
        White,
        Black,
        Red,
        Blue,
        Yellow
    }
}
