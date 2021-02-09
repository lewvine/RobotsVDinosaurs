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

        //Constructor
        public Robot(string name, int health, int powerLevel, Weapon weapon)
        {
            this.name = name;
            this.health = health;
            this.powerLevel = powerLevel;
            this.weapon = weapon;
        }
        //Member methods
        public int Attack(Random rand)
        {
            int attack = rand.Next(this.weapon.attackPower / 2, this.weapon.attackPower);
            this.powerLevel -= 10;
            return attack;
        }
        public void Loss(int diff)
        {
            this.health -= diff;
        }

        public void ChooseWeapon(Fleet fleet)
        {
            Console.WriteLine($"{this.name}'s default weapon is the {this.weapon.type}.  Choose the robot's weapon:" +
                $"\n (1) {fleet.weapons[0].type} with attack of {fleet.weapons[0].attackPower}" +
                $"\n (2) {fleet.weapons[1].type} with attack of {fleet.weapons[1].attackPower}" +
                $"\n (3) {fleet.weapons[2].type} with attack of {fleet.weapons[2].attackPower}");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    this.weapon = fleet.weapons[0];
                    break;
                case "2":
                    this.weapon = fleet.weapons[1];
                    break;
                case "3":
                    this.weapon = fleet.weapons[2];
                    break;
                default:
                    this.weapon = this.weapon;
                    break;
            }

            Console.WriteLine($"You have chosen the {this.weapon.type}");
            Console.WriteLine("PREPARE FOR BATTLE!");
            Console.ReadLine();
        }

    }
}
