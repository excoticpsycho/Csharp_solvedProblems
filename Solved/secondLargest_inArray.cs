//⦁	Given an array, find the second largest number without sorting.
using System;
class second_largest_arr
{
    static void Main()
    {
        int[] arr = { 1, 23, 78, 56, 56, 44 };
        int largest = int.MinValue;
        int second_largest = int.MinValue;
        if (arr.Length < 2)
        {
            throw new Exception("Array must contain more than one elements");
        }
        foreach (int num in arr)
        {
            if (num > largest)
            {
                second_largest = largest;
                largest = num;
            }
            else if (num > second_largest && num != largest)
            {
                second_largest = num;
            }
        }
        //Console.WriteLine($"largest {largest}");
        Console.WriteLine($"second largest {second_largest}");
        if (second_largest == int.MinValue)
        {
            throw new Exception("No second largest element");
        }
    }
}