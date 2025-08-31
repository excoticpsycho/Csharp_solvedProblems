using System;
using System.Text;
class str_rev
{
    public static void Main()
    {
        Console.Write("Enter a  String: ");
        string str = Console.ReadLine();
        StringBuilder str_rev = new StringBuilder();
        int i, len = str.Length;
        for (i = len - 1; i >= 0; i--)
        {
            str_rev.Append(str[i]);
        }
        Console.WriteLine($"Reversed String is {str_rev}");
    }
}