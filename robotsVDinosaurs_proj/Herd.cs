using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robotsVDinosaurs_proj
{
    public class Herd
    {
        //Member variables
        public List<Dinosaur> dinosaurs;
        public List<DinoAttack> attackModes;

        //Constructor
        public Herd()
        {
            //instantiate a list
            dinosaurs = new List<Dinosaur>();
            attackModes = new List<DinoAttack>();

            DinoAttack slash = new DinoAttack("slash", 20);
            DinoAttack stomp = new DinoAttack("stomp", 24);
            DinoAttack chomp = new DinoAttack("chomp", 32);

            //Create individual dinosaurs
            //Dinosaur(string type, int health, int energy, DinoAttack attack)
            Dinosaur spinosaurus = new Dinosaur("Spinosaurus", 100, 100, slash);
            Dinosaur triceratops = new Dinosaur("Triceratops", 100, 100, stomp);
            Dinosaur allosaurus = new Dinosaur("Allosaurus", 100, 100, chomp);      

            //Add individual dinosaurs to list
            dinosaurs.Add(spinosaurus);
            dinosaurs.Add(triceratops);
            dinosaurs.Add(allosaurus);

            attackModes.Add(slash);
            attackModes.Add(stomp);
            attackModes.Add(chomp);


        }
        //Member methods

        public void LostRound(Dinosaur dino)
        {
            Console.WriteLine($"{dino.type} has been defeated!");
            this.dinosaurs.Remove(dino);
        }

        public Dinosaur NextPlayer()
        {
            Dinosaur dino = this.dinosaurs.First();
            Console.WriteLine($"{dino.type} is now joining the fight!");
            return dino;
        
        }
    }
}
