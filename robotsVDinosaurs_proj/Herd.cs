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

        //Constructor
        public Herd()
        {
            List<Dinosaur> dinosaurs = new List<Dinosaur>();

            //Dinosaur(string type, int health, int energy, int attackPower)
            Dinosaur spinosaurus = new Dinosaur("Spinosaurus", 100, 100, 5);
            Dinosaur triceratops = new Dinosaur("Triceratops", 100, 100, 3);
            Dinosaur allosaurus = new Dinosaur("Allosaurus", 100, 100, 4);
            dinosaurs.Add(spinosaurus);
            dinosaurs.Add(triceratops);
            dinosaurs.Add(allosaurus);
        }
        //Member methods
    }
}
