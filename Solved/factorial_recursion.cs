//⦁	Write a program to find the factorial of a number using recursion and iteration
using System.Globalization;

class factorial
{
    static void Main()
    {
        int num = 10;
        System.Console.WriteLine(factorial_num_recursion(num));
        System.Console.WriteLine(factorial_num(num));


    }
    static int factorial_num_recursion(int num)
    {
        if (num == 1)
            return 1;
        else
            return num * factorial_num(num - 1);
    }
    static int factorial_num(int num)
    {
        int result;
        for (int i = 1; i <= num; i++)
        {
            result *= i;

        }
        return result;
    }
}