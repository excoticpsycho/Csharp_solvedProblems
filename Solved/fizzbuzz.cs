/*print numbers from 1 to N, but for multiples of 3 print “Fizz” instead of the number, 
for multiples of 5 print “Buzz”, and for multiples of both print “FizzBuzz”*/
using System;
public class FizzBuzz {
    public static void Main()
    {
        System.Console.Write("Enter limit n: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int i;
        for (i = 1; i <= n; i++)
        {
            if ((i % 3 == 0) && (i % 5 == 0))
            {
                System.Console.WriteLine("FizzBuzz");
            }
            else if (i % 3 == 0)
            {
                System.Console.WriteLine("Fizz");
            }
            else if (i % 5 == 0)
            {
                System.Console.WriteLine("Buzz");
            }
            else System.Console.WriteLine(i);
        }

}
}
