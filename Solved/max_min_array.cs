//Given an array of integers, find the maximum and minimum elements without using built-in functions.
class min_max
{
    public static void Main()
    {
        int[] numbers = { 5, 7, 10, 4, 15, 1, 20 };
        int min = numbers[0];
        int max = numbers[0];
        System.Console.WriteLine(numbers.Length);

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
            }

            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }
        System.Console.WriteLine($"max {max}");
        System.Console.WriteLine($"min {min}");

    }
}