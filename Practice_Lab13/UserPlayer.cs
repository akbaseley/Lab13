using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Lab13
{
    class UserPlayer:Player
    {
        public UserPlayer(string name):base(name)
        {

        }

        public override Roshambo GenerateRoshambo()
        {   
            Roshambo Answer = Validation.UserInput("Rock, Paper, or Scissors? (r/p/s)", "r", "p", "s");
            return Answer;
        }
    }
}
