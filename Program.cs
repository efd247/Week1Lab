using System;

class Program
{
    static void Main(string[] args)
    {
        string input;
        int num1, num2;

        Console.WriteLine("Enter 1st Number:");
        input = Console.ReadLine();
        num1 = Convert.ToInt32(input);

        Console.WriteLine("Enter 2nd Number:");
        input = Console.ReadLine();
        num2 = Convert.ToInt32(input);

        Console.WriteLine("Sum is: {0}", Sum(num1, num2));

        Console.ReadKey();

        Console.WriteLine("Power is: {0}", Power(num1, num2));
    }

    static int Sum(int x, int y)
    {
        return x * y;
    }

    static int Power(int number, int exponent)
{
    int result = 1;

    for (int i = 0; i < exponent; i++)
    {
        result = result * number;
    }

    return result;
}
}