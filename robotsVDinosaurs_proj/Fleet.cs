using System;
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

        //Constructor
        public Fleet()
        {
            //create a new list
            robots = new List<Robot>();

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
        }
        //Member methods

    }
}
