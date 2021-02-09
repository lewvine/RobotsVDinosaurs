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
        public DinoAttack attackMode;

        //Constructor
        public Dinosaur(string type, int health, int energy, DinoAttack attack)
        {
            this.type = type;
            this.health = health;
            this.energy = energy;
            this.attackMode = attack;
        }

        //Member methods
        public int Attack(Random rand)
        {
            int attack = rand.Next(this.attackMode.attackPower / 2, this.attackMode.attackPower);
            this.energy -= 10;
            return attack;
        }

        public void Loss(int diff)
        {
            this.health -= diff;
        }

        public void ChooseAttack(Herd herd)
        {
            
            Console.WriteLine($"{this.type}'s default weapon is the {this.attackMode.type}.  Choose the robot's weapon:" +
                $"\n (1) {herd.attackModes[0].type} with attack of {herd.attackModes[0].attackPower}" +
                $"\n (2) {herd.attackModes[1].type} with attack of {herd.attackModes[1].attackPower}" +
                $"\n (3) {herd.attackModes[2].type} with attack of {herd.attackModes[2].attackPower}");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    this.attackMode = herd.attackModes[0];
                    break;
                case "2":
                    this.attackMode = herd.attackModes[0];
                    break;
                case "3":
                    this.attackMode = herd.attackModes[0];
                    break;
                default:
                    this.attackMode = this.attackMode;
                    break;
            }

            Console.WriteLine($"You have chosen the {this.attackMode.type}");
            Console.WriteLine("PREPARE FOR BATTLE!");
            Console.ReadLine();
        }
    }
}
