using System;
class Gameguess
{
    public static void Main()
    {
        bool playAgain =  true;
        int guesses, number, choice;
        Random random = new Random();
        while (playAgain)
        {
            guesses = 0; number = 0; choice = 0;
            number = random.Next(1, 101);
            while (choice != number)
            {
                Console.Write("Guess a number b/w 1 and 100: ");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice > number)
                {
                    Console.WriteLine("Guess is High!");
                }
                else if (choice < number)
                {
                    Console.WriteLine("Guess is Low!");
                }
                guesses++;
            }
            Console.WriteLine($"Guessed the correct number {number} in {guesses} guessess. ");
            Console.WriteLine("Would you like to PlayAgain Y/N ? ");
            string? yes_or_no = Console.ReadLine();
            if (yes_or_no != null)
            {
                 yes_or_no = yes_or_no.ToUpper();
            }
           
            if (yes_or_no == "Y")
            {
                playAgain = true;
            }
            else
            {
                playAgain = false;
            }

        }
        Console.WriteLine("Thanks for playing :) ");
    }
}