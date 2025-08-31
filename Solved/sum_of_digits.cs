//Given a number, find the sum of its digits.
class sum_of_digits
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int num = Math.Abs(Convert.ToInt32(Console.ReadLine()));
        int sum = 0;
        while (num != 0)
        {
            sum = sum + (num % 10);
            num = num / 10;
        }

        Console.WriteLine($"Sum is {sum}");
    }
}
