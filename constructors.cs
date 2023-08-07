using System;

class Vehicle
{
    // Fields
    private string make;
    private string colour;
    private string countryOfManufacture;
    private int maxSpeed;

    // Parameterized Constructor
    public Vehicle(string make, string colour, string countryOfManufacture, int maxSpeed)
    {
        this.make = make;
        this.colour = colour;
        this.countryOfManufacture = countryOfManufacture;
        this.MaxSpeed = maxSpeed; // Use the property to ensure validation
    }

    // Default Constructor
    public Vehicle()
    {
        // Set default values for the fields
        this.make = "Unknown";
        this.colour = "Black";
        this.countryOfManufacture = "Unknown";
        this.MaxSpeed = 80; // Use the property to ensure validation
    }

    // Property for maxSpeed with validation
    public int MaxSpeed
    {
        get { return maxSpeed; }
        set
        {
            if (value < 80)
            {
                Console.WriteLine("Error: Max speed cannot be less than 80.");
                maxSpeed = 80;
            }
            else
            {
                maxSpeed = value;
            }
        }
    }
}
