// a product for sale in a shop

using System;

class Product
{
    // fields
    private String code;
    private String name;
    private double sellingPrice;
    private double costPrice;
    private int onHand;
    private double accumulatedProfit;

    // shared field
    private static double vatRate = 0.20;                       // applies to each product

    // non-default constructor
    public Product(String code, String name, double sellingPrice, double costPrice)
    {
        this.code = code;
        this.name = name;
        this.sellingPrice = sellingPrice;
        this.costPrice = costPrice;

        this.onHand = 0;
        this.accumulatedProfit = 0;
    }

    // a delivery came in, increase stock on hand
    public void RenewStockLevel(int deliveryQty)
    {
        this.onHand += deliveryQty;
    }

    // sell some product if enough on hand
    public bool Sell(int units)
    {
        if (units <= onHand)
        {
            onHand -= units;
            accumulatedProfit += (units * (sellingPrice - costPrice)) * (1.0 - vatRate);
            return true;
        }
        else
        {
            return false;
        }
    }

    // report the accumualted profit for this product
    public double GetAccumulatedProfit()
    {
        return accumulatedProfit;
    }
}

// a test class
class ProductTest
{
    public static void Main()
    {
        // create a product
        Product p1 = new Product("p123", "Widget", 100, 50);
        p1.RenewStockLevel(100);                                         // 50 on hand

        bool more;

        do
        {  
            Console.Write("How many units do you wish to buy? ");
            int units = Int32.Parse(Console.ReadLine());

            if (p1.Sell(units))            // success
            {
                Console.WriteLine("Sale successful, accumulated profit to date: €" + p1.GetAccumulatedProfit());
            }
            else                           // failure
            {
                Console.WriteLine("Sorry: Insufficent stock on hand");
            }
            Console.Write("Do you want to buy some more (yes/no)? ");
            String input = Console.ReadLine();
            if (input == "yes")
            {
                more = true;
            }
            else
            {
                more = false;
            }

        } while (more == true);

    }
}
