//Given a number, find the sum of its digits.
class sum_of_digits
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int len = num.ToString().Length;
        int[] num_array = new int[len];
        for (int i = 0; i < len; i++)
        {
            num_array[i] = num % 10;
            num = num / 10;
        }
        int sum = 0;
        for (int i = 0; i < len; i++)
        {
            sum += num_array[i];
        }
        System.Console.WriteLine($"Sum = {sum}");

    }
}
