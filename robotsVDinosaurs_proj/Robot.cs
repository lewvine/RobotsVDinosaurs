using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robotsVDinosaurs_proj
{
    public class Robot
    {
        //Member variables
        public string name;
        public int health;
        public int powerLevel;
        public Weapon weapon;
        public Random rand;

        //Constructor
        public Robot(string name, int health, int powerLevel, Weapon weapon)
        {
            this.name = name;
            this.health = health;
            this.powerLevel = powerLevel;
            this.weapon = weapon;
            this.rand = new Random();
        }
        //Member methods
        public int Attack(int atk)
        {
            int attack = rand.Next(1, atk);
            return attack;
        }
        public void Loss(int diff)
        {
            this.health -= diff;
        }

    }
}
