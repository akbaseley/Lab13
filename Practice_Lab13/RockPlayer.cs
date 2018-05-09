using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Lab13
{
    class RockPlayer : Player
    {
        public RockPlayer(string name) : base(name)
        {

        }

        public override Roshambo GenerateRoshambo()
        {
            return (Roshambo)0;
        }
    }
}
