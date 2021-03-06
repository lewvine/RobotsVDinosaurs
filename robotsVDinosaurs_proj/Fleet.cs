﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robotsVDinosaurs_proj
{
    public class Fleet
    {
        //Member variables
        public List<Robot> robots;
        public List<Weapon> weapons;

        //Constructor
        public Fleet()
        {
            //create a new list
            robots = new List<Robot>();
            weapons = new List<Weapon>();

            //Create individual weapons for each robot
            Weapon lance = new Weapon("lance", 20);
            Weapon javelin = new Weapon("javelin", 24);
            Weapon saber = new Weapon("saber", 32);

            //Create individual robots
            Robot c3p0 = new Robot("C3PO", 100, 100, lance);
            Robot r2d2 = new Robot("R2D2", 100, 100, javelin);
            Robot hal = new Robot("Hal", 100, 100, saber);

            //Add individual robots to robot list
            robots.Add(c3p0);
            robots.Add(r2d2);
            robots.Add(hal);

            //Add individual weapons to the weapons list
            
            weapons.Add(lance);
            weapons.Add(javelin);
            weapons.Add(saber);
        }
        //Member methods
        public void LostRound(Robot robot)
        {
            Console.WriteLine($"{robot.name} has been defeated!");
            this.robots.Remove(robot);
        }

        public Robot NextPlayer()
        {
            Robot robot = this.robots.First();
            Console.WriteLine($"{robot.name} is now joining the fight!");
            return robot;
        }
    }
}
