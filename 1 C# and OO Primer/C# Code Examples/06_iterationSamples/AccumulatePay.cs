/* 
 * A program to calculate pay for a specified number of employees and to accumulate the total amount payed to all employees.
   The number of employees is specified by the user. Input is the  number of employees, pay and the hours worked. 
 */

using System;

namespace Iteration
{
    class AccumulatePay
    {
        private static void Main()
        {
            double pay, rate, hours, totalPay = 0;
            int employeeCount = 0;
            int numberEmps;

            Console.Write("Enter the number of employees:");
            numberEmps = Int32.Parse(Console.ReadLine());

            while (employeeCount < numberEmps)
            {
                // Enter hours worked
                Console.Write("Enter the hours worked:  ");
                hours = Double.Parse(Console.ReadLine());

                // Enter rate per hour
                Console.Write("Enter the rate per hour:  ");
                rate = Double.Parse(Console.ReadLine());

                pay = rate * hours;

                totalPay = totalPay + pay;          // accumulate total pay

                // print out the pay for this employee
                Console.WriteLine("The pay for this employee is:  " + pay);
                employeeCount++;

            }
            Console.WriteLine("All employees processed");
            Console.WriteLine("Total Pay is: " + totalPay); 
        } 
    }
}



