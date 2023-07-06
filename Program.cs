using System;

class Program
{
   public static void Main()
    {
        Console.WriteLine("Enter the first number: ");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second number: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        int sum = number1 + number2;

        Console.WriteLine("The sum of {0} and {1} is {2}", number1, number2, sum);

        Console.ReadLine();
    }
}
