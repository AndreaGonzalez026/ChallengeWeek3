using System;

public class ExamGrader
{
    public void Main()
    {
        Console.WriteLine("Please enter your exam scores as percentages:");
       
       if (int.TryParse(acoreInput, out score))
        {
            if (score>= 90)
            {
                Console.WriteLine("Your Grade is A");
            }
            else if (score >=80)
            {
                Console.WriteLine("Your Grade is B");
            }
             else if (score >=70)
            {
                Console.WriteLine("Your Grade is C");
            }
             else if (score >=60)
            {
                Console.WriteLine("Your Grade is D");
            }
             else
            {
                Console.WriteLine("Your Grade is F");
            }
         
        }
        else
        {
            Console.WriteLine("Invalid score. Please enter a score between 0 & 100");
        }
    }
}
