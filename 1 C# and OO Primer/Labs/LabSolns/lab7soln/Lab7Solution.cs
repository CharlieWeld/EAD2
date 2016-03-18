// a program to calculate volume for a specified solid using a menu system
 
using System;

class CalcVolume
{
    public static void Main()
    {
        double volume = 0, radius = 0, length = 0, height = 0;
        int userChoice;

        do
        {
            Console.WriteLine("\nCalculation of volume for Solid Objects*");
            Console.WriteLine(" 1.\t Cube                ");
            Console.WriteLine(" 2.\t Cylinder        ");
            Console.WriteLine(" 3.\t Sphere       ");
            Console.WriteLine(" 4.\t Exit          ");
            Console.WriteLine(" **********************************");
            userChoice = Int32.Parse(Console.ReadLine());

            switch (userChoice)
            {
                case 1:
                    {
                        // enter length of the cube
                        Console.Write("Enter the length of the cube:  ");
                        length = Double.Parse(Console.ReadLine());

                        // calculate volume
                        volume = length * length * length;
                        Console.WriteLine("The volume for this cube is:  " + volume);
                        break;
                    }
                case 2:
                    {
                        // enter radius and height of the cylinder
                        Console.Write("Enter the radius of the cylinder:  ");
                        radius = Double.Parse(Console.ReadLine());
                        Console.Write("Enter the height of the cylinder:  ");
                        height = Double.Parse(Console.ReadLine());

                        // calculate volume
                        volume = Math.PI * (radius * radius) * height;

                        Console.WriteLine("The volume for this cylinder is:  " + volume);
                        break;
                    }
                case 3:
                    {
                        // enter radius of the sphere
                        Console.WriteLine("Enter the radius of the sphere:  ");
                        radius = Double.Parse(Console.ReadLine());

                        // calculate volume
                        volume = (4 / 3.0) * Math.PI * (radius * radius * radius);
                        Console.WriteLine("The volume for this sphere is: ", volume);
                        break;
                    }
            }
        }
        while (userChoice != 4);
    }
}
