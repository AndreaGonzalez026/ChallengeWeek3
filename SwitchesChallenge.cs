using System;
					
public class Menu
{
  public static void Main()
  {
    Combo combo1 = new Combo();
    Combo combo2 = new Combo();
    Combo combo3 = new Combo();
    
    combo1.entree = "Hamburger";
    combo1.side = "Fries";
    combo1.drink = "Dr Pepper";
    
    combo2.entree = "Hamburger";
    combo2.side = "Apple Slices";
    combo2.drink = "Coke";
    
    combo3.entree = "Hotdog";
    combo3.side = "Fries";
    combo3.drink = "Dr Pepper";
    
    Console.WriteLine("Combo #1 Entree: " + combo1.entree);
	Console.WriteLine("Combo #1 Side: " + combo1.side);
    Console.WriteLine("Combo #1 Drink: " + combo1.drink);
    
    Console.WriteLine("Combo #2 Entree: " + combo2.entree);
	Console.WriteLine("Combo #2 Side: " + combo2.side);
    Console.WriteLine("Combo #2 Drink: " + combo2.drink);
    
    Console.WriteLine("Combo #3 Entree: " + combo3.entree);
	Console.WriteLine("Combo #3 Side: " + combo3.side);
    Console.WriteLine("Combo #3 Drink: " + combo3.drink);
    
    Price();
 }
  
	public static void Price()
	{
		Console.WriteLine("Menu Combos Prices");
		Console.WriteLine("Combo 1 Price:" + DoMath(4, 3));
        Console.WriteLine("Combo 2 Price:" + DoMath(4, 2));
        Console.WriteLine("Combo 3 Price:" + DoMath(3, 3));
	}
	
	public static void DoMath (int value, int value2) 
    {
		var number = value + value2;
		Console.WriteLine(number);
        
        }
	}
    
public class Combo
 {
    public string entree;
    public string side;
    public string drink;
 }
