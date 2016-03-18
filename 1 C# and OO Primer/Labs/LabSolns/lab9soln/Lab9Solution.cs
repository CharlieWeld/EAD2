// Car Ferry system
 
using System;

class CarFerry
{
    public static void Main()
    {
        String registration;                // car reg
        int numberInCar;                    // number of passengers in a car
        double carCost;                     // cost for a car (€)
        int carsWithDriverOnly = 0;         // number of driver only cars
        int totalNumberPassengers = 0;      // total number of passengers
        double totalCost = 0;               // total cost of all cars
        String response;                    // yes or no
            
        Console.WriteLine("Welcome to the Dublin to HollyHead Ferry");
        
        // outer loop for cars 
        do
        {
            Console.Write("What is the car registration? ");
            registration = Console.ReadLine();
            Console.Write("How many people are there in the car? ");
            numberInCar = Int32.Parse(Console.ReadLine());
      
            if (numberInCar == 1)                   // if only the driver
            {   
                carCost = 100;
                carsWithDriverOnly++;
            }
            else                                    // if more than 1 in the car loop for each and determine ages & calculate accordingly
            {            
                carCost = 100;
                for (int i = 1; i <= numberInCar; i++)
                {
                    Console.Write("Is passenger " + i + " under 18? yes/no ");
                    response = Console.ReadLine();
                    if (response == "yes")
                    {
                        carCost += 10;
                    }
                    else                            // assume 'n'
                    {
                        carCost += 20;
                    }
                }
             }
        
            Console.WriteLine("Charge for car " + registration + " is /€" + carCost);   
            totalNumberPassengers += numberInCar;           // total number of passengers
            totalCost += carCost;                           // total cost 
            Console.Write("Are there more cars waiting to board? yes/no ");
            response = Console.ReadLine();                      // see if more cars ready to board
            
        } 
        while (response == "yes");
    
        // output overall stats
        Console.WriteLine("Total Charge: €" + totalCost + "\nDriver-only cars: " + carsWithDriverOnly + "\nNumber of passengers: " + totalNumberPassengers);
    }
}
