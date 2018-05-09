using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Lab13
{
    class RandomPlayer:Player
    {
        public RandomPlayer(string name):base(name)
        {

        }

        public Random n = new Random();
        public override Roshambo GenerateRoshambo()
        {
            return (Roshambo)n.Next(0,3);
        }
    }
}
