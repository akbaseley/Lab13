using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Lab13
{
    class RoshamboApp
    {
         public static string WhoWinsAgainstRockPlayer(List<Player> Opponents)
         {
            if (Opponents[2].PlayerPick == Opponents[0].PlayerPick)
            {
                string DrawCount = "Count";
                Console.WriteLine("It's a draw!");
                return DrawCount;
            }
            else if (Opponents[2].PlayerPick == Roshambo.paper)
            {
                Console.WriteLine($"{Opponents[2].Name} wins!");
                return Opponents[2].Name;
            }
            else
            {
                Console.WriteLine($"{Opponents[0].Name} wins!");
                return Opponents[0].Name;
            }
         }

        public static string WhoWinsAgainstRandomPlayer(List<Player> Opponents)
        {
            string DrawCount = "string";

            if (Opponents[2].PlayerPick == Opponents[1].PlayerPick)
            {
                Console.WriteLine("It's a draw!");
                return DrawCount;
            }

            else if (Opponents[2].PlayerPick == Roshambo.paper && Opponents[1].PlayerPick == Roshambo.rock ||
                    Opponents[2].PlayerPick == Roshambo.rock && Opponents[1].PlayerPick == Roshambo.scissors ||
                    Opponents[2].PlayerPick == Roshambo.scissors && Opponents[1].PlayerPick == Roshambo.paper)
            {
                Console.WriteLine($"{Opponents[2].Name} wins!");
                return Opponents[2].Name;
            }

            else if (Opponents[1].PlayerPick == Roshambo.paper && Opponents[2].PlayerPick == Roshambo.rock ||
                    Opponents[1].PlayerPick == Roshambo.rock && Opponents[2].PlayerPick == Roshambo.scissors ||
                    Opponents[1].PlayerPick == Roshambo.scissors && Opponents[2].PlayerPick == Roshambo.paper)
            {
                Console.WriteLine($"{Opponents[1].Name} wins!");
                return Opponents[1].Name;
            }
            
            else
            {
                return DrawCount;
            }
        }
       
    }
}
