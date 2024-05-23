using System;

public class Temperature
{
    public void Main()
    {
        Console.WriteLine("Please enter the temperature in Celsius:");
       
       if (int.TryParse(input, out temperature))
        {
            if (temperature > 30)
            {
                Console.WriteLine("It's HOT outside. Stay hydrated and avoid prolonged sun exposure.");
            }
            else
            {
                Console.WriteLine("The weather is GOOD. Enjoy your day!");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid temperature.");
        }
    }
}
