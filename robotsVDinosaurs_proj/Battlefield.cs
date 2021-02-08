using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robotsVDinosaurs_proj
{
    public class Battlefield
    {
        //Member Variables

        //Constructor
        public Battlefield()
        {
            //Create a fleet and a herd instance
            Fleet fleet = new Fleet();
            Herd herd = new Herd();

            //Call battle action once fleet and herd have been created.
            this.Battle(herd, fleet);
        }

        //Member methods

        public void Battle(Herd herd, Fleet fleet)
        {
            //Start with first player from each side
            Dinosaur dinosaurPlayer = herd.dinosaurs.First();
            Robot robotPlayer = fleet.robots.First();
            
            while(dinosaurPlayer.health > 0 && robotPlayer.health > 0)
            {
                Round(dinosaurPlayer, robotPlayer);
            }
            if (dinosaurPlayer.health == 0)
            {
                Console.WriteLine($"{dinosaurPlayer.type} has been defeated!");
                Console.ReadLine();
                herd.dinosaurs.Remove(dinosaurPlayer);
                if (herd.dinosaurs.Count > 0)
                {
                    dinosaurPlayer = herd.dinosaurs.First();
                    Console.WriteLine($"{dinosaurPlayer.type} is now joining the fight!");
                    Console.ReadLine();
                    Round(dinosaurPlayer, robotPlayer);
                }
                else
                {
                    Console.WriteLine("GAME OVER!  THE DINOSAURS HAVE BEEN DEFEATED!");
                    Console.ReadLine();
                }
            }
            else if (robotPlayer.health == 0)
            {
                Console.WriteLine($"{robotPlayer.name} has been defeated!");
                fleet.robots.Remove(robotPlayer);
                Console.ReadLine();
                if (fleet.robots.Count > 0)
                {
                    robotPlayer = fleet.robots.First();
                    Console.WriteLine($"{robotPlayer.name} is now joining the fight!");
                    Console.ReadLine();
                    Round(dinosaurPlayer, robotPlayer);
                }
                else
                {
                    Console.WriteLine("GAME OVER!  THE ROBOTS HAVE BEEN DEFEATED!");
                    Console.ReadLine();
                }
            }
        }

        public void Round(Dinosaur dinosaur, Robot robot)
        {

            int dinoAttackValue = dinosaur.Attack();
            int robotAttackValue = robot.Attack();

            if (dinoAttackValue > robotAttackValue)
            {
                robot.Loss(dinoAttackValue);
                Console.WriteLine($"{dinosaur.type} attacked with {dinoAttackValue}.");
                Console.WriteLine($"{robot.name} attacked with {robotAttackValue}.");
                Console.WriteLine($"{dinosaur.type} wins!  {robot.name} loses {dinoAttackValue} health.");
                Console.WriteLine($"{dinosaur.type} health: {dinosaur.health}.  Robot health: {robot.health}");
                Console.WriteLine("Hit ENTER to go to the next round.");
                Console.ReadLine();
            }
            else if(dinoAttackValue < robotAttackValue)
            {
                dinosaur.Loss(robotAttackValue);
                Console.WriteLine($"{dinosaur.type} attacked with {dinoAttackValue}.");
                Console.WriteLine($"{robot.name} attacked with {robotAttackValue}.");
                Console.WriteLine($"{robot.name} wins!  {dinosaur.type} loses {robotAttackValue} health.");
                Console.WriteLine($"{dinosaur.type} health: {dinosaur.health}.  {robot.name} health: {robot.health}");                Console.WriteLine("His ENTER to go to the next round.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("The attacks offset!");
                Console.WriteLine($"{dinosaur.type} health: {dinosaur.health}.  {robot.name} health: {robot.health}.");
                Console.WriteLine("His ENTER to go to the next round.");
                Console.ReadLine();
            }



        }


    }
}
