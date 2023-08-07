using System;

class Product
{
    private double totalCost;
    private double discount;
    private double netCost;

    public Product(double totalCost)
    {
        this.totalCost = totalCost;
    }

    public void CalculateDiscount()
    {
        if (totalCost > 12000)
        {
            discount = totalCost * 0.1;
        }
        else if (totalCost >= 5000)
        {
            discount = totalCost * 0.05;
        }
        else
        {
            discount = 0;
        }
    }

    public void CalculateNetCost()
    {
        netCost = totalCost - discount;
    }

    public void DisplayDetails()
    {
        Console.WriteLine("Total Cost: " + totalCost);
        Console.WriteLine("Discount: " + discount);
        Console.WriteLine("Net Cost: " + netCost);
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter the total cost of items: ");
        double totalCost = double.Parse(Console.ReadLine());

        Product product = new Product(totalCost);
        product.CalculateDiscount();
        product.CalculateNetCost();
        product.DisplayDetails();
    }
}
