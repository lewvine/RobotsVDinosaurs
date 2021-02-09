﻿using System;
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
            //instantiate a list
            dinosaurs = new List<Dinosaur>();

            //Create individual dinosaurs
            //Dinosaur(string type, int health, int energy, int attackPower)
            Dinosaur spinosaurus = new Dinosaur("Spinosaurus", 100, 100, 20);
            Dinosaur triceratops = new Dinosaur("Triceratops", 100, 100, 24);
            Dinosaur allosaurus = new Dinosaur("Allosaurus", 100, 100, 32);      

            //Add individual dinosaurs to list
            dinosaurs.Add(spinosaurus);
            dinosaurs.Add(triceratops);
            dinosaurs.Add(allosaurus);
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
