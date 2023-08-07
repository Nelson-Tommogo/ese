using System;

class Product
{
    private double total_cost;
    private double discount;
    private double net_cost;

    public Product(double totalCost)
    {
        total_cost = totalCost;
    }

    public Product()
    {
        total_cost = 0;
    }

    public void dataIn()
    {
        Console.Write("Enter the total cost of items: ");
        total_cost = double.Parse(Console.ReadLine());
    }

    public void compute()
    {
        if (total_cost > 12000)
        {
            discount = total_cost * 0.1;
        }
        else if (total_cost >= 5000)
        {
            discount = total_cost * 0.05;
        }
        else
        {
            discount = 0;
        }

        net_cost = total_cost - discount;
    }

    public void dataOut()
    {
        Console.WriteLine("Total Cost: " + total_cost);
        Console.WriteLine("Discount: " + discount);
        Console.WriteLine("Net Cost: " + net_cost);
    }
}

class Program
{
    static void Main()
    {
        Product product = new Product();
        product.dataIn();
        product.compute();
        product.dataOut();
    }
}
