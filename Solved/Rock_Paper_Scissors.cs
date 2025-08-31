using System;
class Game
{
    static void Main()
    {
        Random random = new Random();
        string? player_ch = "", computer = "";
        bool playAgain = true;
        while (playAgain)
        {
            switch (random.Next(1, 4))
            {
                case 1:
                    computer = "ROCK";
                    break;
                case 2:
                    computer = "PAPER";
                    break;
                case 3:
                    computer = "SCISSORS";
                    break;
                default:
                    break;

            }
            while (player_ch != "ROCK" && player_ch != "PAPER" && player_ch != "SCISSORS")
            {
                Console.Write("Enter your choice [ROCK/PAPER/SCISSORS]: ");
                 player_ch = Console.ReadLine();
                if (player_ch != null)
                {
                    player_ch = player_ch.ToUpper();
                }
            }
            Console.WriteLine($"Your choice is {player_ch}");
            Console.WriteLine($"Computer's choice is {computer}");
            switch (player_ch)
            {
                case "ROCK":
                    if (computer == "ROCK") Console.WriteLine("It's a Draw!");
                    else if (computer == "PAPER") Console.WriteLine("Computer Wins!");
                    else Console.WriteLine("Player Wins!");
                    break;
                case "PAPER":
                    if (computer == "PAPER") Console.WriteLine("It's a Draw!");
                    else if (computer == "SCISSORS") Console.WriteLine("Computer Wins!");
                    else Console.WriteLine("Player Wins!");
                    break;
                case "SCISSORS":
                    if (computer == "SCISSORS") Console.WriteLine("It's a Draw!");
                    else if (computer == "PAPER") Console.WriteLine("Computer Wins!");
                    else Console.WriteLine("Player Wins!");
                    break;
            }
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
    }
}