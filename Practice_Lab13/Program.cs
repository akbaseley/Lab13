using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Lab13
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Player> Opponents = new List<Player>
            { new RockPlayer("Bruce"),
                new RandomPlayer("Tony"),
                new UserPlayer(Validation.GetUserName("Hi! What is your name? ")) };

            string UserChoice = Validation.UserInput($"Who would you like to play, {Opponents[2].Name}? Bruce (b) or Tony (t)", "b", "t");

            bool ContinueRock = true;
            if (UserChoice == "b")
            {
                int RockPlayerWins = 0, UserPlayerWins = 0, draw = 0;

                while (ContinueRock)
                {
                    Opponents[2].PlayerPick = Opponents[2].GenerateRoshambo();
                    Opponents[0].PlayerPick = Opponents[0].GenerateRoshambo();

                    Console.WriteLine($"{Opponents[2].Name}: {Opponents[2].PlayerPick} " +
                      $"\n{Opponents[0].Name}: {Opponents[0].PlayerPick}");

                    string WinningPlayer = RoshamboApp.WhoWinsAgainstRockPlayer(Opponents);

                    if (WinningPlayer == Opponents[2].Name)
                    {
                        UserPlayerWins++;
                    }
                    else if (WinningPlayer == Opponents[0].Name)
                    {
                        RockPlayerWins++;
                    }
                    else
                    {
                        draw++;
                    }

                    Console.WriteLine($"\n{Opponents[2].Name} wins: {UserPlayerWins} " +
                        $"\n{Opponents[0].Name} wins: {RockPlayerWins} \nTie Games: {draw}");

                    string Response = Validation.UserInput("Would you like to play again? y/n", "y", "n");

                    if (Response == "n")
                    {
                        Console.WriteLine("Okay! Bye!");
                        ContinueRock = false;
                    }
                }

            }
            else if (UserChoice == "t")
            {
                int RandomPlayerWins = 0, UserPlayerWins = 0, draw = 0;

                bool ContinueRandom = true;
                while (ContinueRandom)
                {
                    Opponents[2].PlayerPick = Opponents[2].GenerateRoshambo();
                    Opponents[1].PlayerPick = Opponents[1].GenerateRoshambo();

                    Console.WriteLine($"{Opponents[2].Name}: {Opponents[2].PlayerPick} " +
                        $"\n{Opponents[1].Name}: {Opponents[1].PlayerPick}");

                    string WinningPlayer = RoshamboApp.WhoWinsAgainstRandomPlayer(Opponents);

                    if (WinningPlayer == Opponents[2].Name)
                    {
                        UserPlayerWins++;
                    }
                    else if (WinningPlayer == Opponents[1].Name)
                    {
                        RandomPlayerWins++;
                    }
                    else
                    {
                        draw++;
                    }

                    Console.WriteLine($"\n{Opponents[2].Name} wins: {UserPlayerWins} " +
                        $"\n{Opponents[1].Name} wins: {RandomPlayerWins} " +
                        $"\nTied Games: {draw}");

                    string Response = Validation.UserInput($"\nWould you like to play again? y/n", "y", "n");

                    if (Response == "n")
                    {
                        Console.WriteLine("Okay! Bye!");
                        ContinueRandom = false;
                    }
                }
            }
        }
    }
}
