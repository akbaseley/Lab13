using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Lab13
{
    abstract class Player
    {
        #region DataTypes
        private string name;
        private Roshambo playerPick;
        #endregion

        #region
        public string Name { get => name; set => name = value; }
        internal Roshambo PlayerPick { get => playerPick; set => playerPick = value; }
        #endregion

        #region Constructors
        public Player()
        {

        }
        public Player(string n)
        {
            Name = n;
        }
        #endregion
        
        #region Methods
        public abstract Roshambo GenerateRoshambo();
        #endregion
    }
}
