using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robotsVDinosaurs_proj
{
    public class Dinosaur
    {
        //Member variables
        public string type;
        public int health;
        public int energy;
        public int attackPower;

        //Constructor
        public Dinosaur(string type, int health, int energy, int attackPower)
        {
            this.type = type;
            this.health = health;
            this.energy = energy;
            this.attackPower = attackPower;
        }

        //Member methods
        public int Attack(Random rand)
        {
            int attack = rand.Next(this.attackPower / 2, this.attackPower);
            return attack;
        }

        public void Loss(int diff)
        {
            this.health -= diff;
        }
    }
}
