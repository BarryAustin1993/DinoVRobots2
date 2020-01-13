using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace League_of_Dinasaurs_vs_Robots
{
    class Dinosaur
    {
        //member variables (has a)
        public string type;
        public int health;
        public int energy;
        public int attackPower;


        //constructor (spawner)
        public Dinosaur(string typepass, int healthpass, int energyPass, int attackPowerPass)
        {
            type = typepass;
            health = healthpass;
            energy = energyPass;
            attackPower = attackPowerPass;

        }



        //member methods (can do)

    }
}
