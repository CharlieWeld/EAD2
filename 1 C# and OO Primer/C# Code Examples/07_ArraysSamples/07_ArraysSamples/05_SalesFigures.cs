// 2D array

using System;

namespace Arrays
{
    class SalesFigures
    {
        private static void Main()          
        {    
            double[,] sales;                        // 2 dimensional array

            // array needed to hold daily sales for 2 products
            // 2 rows, each with 7 columns
            sales = new double[2, 7];               // sales.Length == 12

            // 1st product
            sales[0, 0] = 5;                        // row 0, column 0
            sales[0, 1] = 6;
            sales[0, 2] = 10;
            sales[0, 3] = 4;
            sales[0, 4] = 2;
            sales[0, 5] = 14;
            sales[0, 6] = 12;

            // 2nd product
            sales[1, 0] = 8;
            sales[1, 1] = 4;
            sales[1, 2] = 21;
            sales[1, 3] = 5;
            sales[1, 4] = 18;
            sales[1, 5] = 5;
            sales[1, 6] = 5;

            // display each cell
            for (int i = 0; i < sales.GetLength(0); i++)
            {
                Console.Write("Product " + i + " sales: "); 
                for (int j = 0; j < sales.GetLength(1); j++)
                {
                    Console.Write(sales[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

