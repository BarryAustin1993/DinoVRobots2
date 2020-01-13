using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace League_of_Dinasaurs_vs_Robots
{
    class Herd
    {
        //member variables (has a)

        public List<Dinosaur> dinosaurs;
        public Dinosaur CurrentDinosaur;
        public string computerInput;

        //constructor (spawner)
        public Herd()
        {
            dinosaurs = new List<Dinosaur>();
            dinosaurs.Add(new Dinosaur("Anivia", 500, 150, 100));
            dinosaurs.Add(new Dinosaur("Chogath", 1000, 75, 100));
            dinosaurs.Add(new Dinosaur("Renekton", 750, 100, 100));
        }
        //member methods (can do)
        public void ChooseDinosaur()
        {
            List<string> types = new List<string>();
            for (int i = 0; i < dinosaurs.Count; i++)
            {
                if (dinosaurs[i].health <= 0)
                {
                    dinosaurs.RemoveAt(i);
                }

            }
            for (int j = 0; j < dinosaurs.Count; j++)
            {
                types.Add(dinosaurs[j].type);
            }
            for (int k = 0; k < types.Count; k++)
            {
                Random random = new Random();
                int index = random.Next(types.Count);

                computerInput = types[index].ToLower();
            }
            foreach (var item in dinosaurs)
            {
                if (computerInput == item.type.ToLower())
                {
                    CurrentDinosaur = item;
                }
            }

        }
    }
}