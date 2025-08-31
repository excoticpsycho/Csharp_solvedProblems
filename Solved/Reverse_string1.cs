using System;
class reverseString
{
    public static void Main()
    {
        Console.Write("Enter string: ");
        string str = Console.ReadLine();
        int i, len = str.Length;
        string str_rev = "";
        for (i = len - 1; i >= 0; i--)
        {
            str_rev += str[i];
        }
        Console.WriteLine("Reversed string: " + str_rev);
    }
}