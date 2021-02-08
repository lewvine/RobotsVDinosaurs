using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robotsVDinosaurs_proj
{
    class Fleet
    {
        //Member variables
        List<Robot> robots;

        //Constructor
        public Fleet()
        {
            Weapon lance = new Weapon("lance", 10);
            Weapon javelin = new Weapon("javelin", 5);
            Weapon saber = new Weapon("saber", 3);

            Robot c3p0 = new Robot("C3PO", 100, 100, lance);
            Robot r2d2 = new Robot("R2D2", 100, 100, javelin);
            Robot hal = new Robot("Hal", 100, 100, saber);

            List<Robot> robots = new List<Robot>();
            robots.Add(c3p0);
            robots.Add(r2d2);
            robots.Add(hal);
        }
        //Member methods

    }
}
