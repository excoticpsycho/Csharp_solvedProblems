//⦁	Given a string, count how many vowels and consonants it contains.
class vowels_consonants
{
    public static void Main()
    {

        System.Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        int vowels = 0; int consonants = 0;

        foreach (char ch in input.ToLower())
        {
            if (char.IsLetter(ch))
            {
                if ("aeiou".Contains(ch))
                {
                    vowels++;
            }
                else consonants++;
        }
       }
        System.Console.WriteLine($"vowels is {vowels}");
        System.Console.WriteLine($"consonants is {consonants}");
    }
}
