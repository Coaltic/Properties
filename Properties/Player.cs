using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Player
    {
        // public/private/protected/ect. = Access Modifier

        private int health;
        private int _shield;

        public int Shield
        {
            get
            {
                return _shield;
            }
            set
            {
                _shield = value;
            }
        }

        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public Player(string name)
        {
            this._name = name;
        }

        public void SetHealth(int health)
        {
            if (health > 100) health = 100;
            this.health = health;
        }

        public int GetHealth()
        {

            return health;
        }
    }
}
