// Read in and analyse sales figures for sales men
 
using System;

class SalesMen
{
    public static void Main()
    {
        double[] sales;
        String[] names;
        int numberOfSalesmen;
        double totalSales = 0;

        // read in the number of salesmen
        Console.Write("Enter the number of salesmen in the company: "); 
        numberOfSalesmen = Int32.Parse(Console.ReadLine());
 
        // create the arrays
        sales = new double[numberOfSalesmen];
        names = new String[numberOfSalesmen];
 
        // read in the sales figures and total up
        for (int i=0; i < sales.Length; i++)
        { 
            Console.Write("Enter the name of salesman " + (i+1) +  ": "); 
            names[i] = Console.ReadLine();
            Console.Write("Enter the sales for salesman " + names[i] +  ": ");
            sales[i] = Int32.Parse(Console.ReadLine());

            totalSales += sales[i]; 
        } 
 
        // find index in array with highest sales
        int bestSalesManIndex = 0;
        for (int i=0; i < sales.Length;i++)
        { 
            if (sales[i] > sales[bestSalesManIndex])
            {
                bestSalesManIndex = i;
            }
        }

        Console.WriteLine("\nSales Report");
 
        for (int i=0; i < sales.Length;i++)
        { 
            Console.WriteLine("Salesman: " + names[i] +" Sales: " + sales[i] ); 
        } 
        Console.WriteLine("Best performing salesman: " + names[bestSalesManIndex]);
        Console.WriteLine("Total sales: " + totalSales);
    }
}
