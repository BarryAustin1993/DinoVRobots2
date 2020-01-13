using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace League_of_Dinasaurs_vs_Robots
{
    class Fleet
    {
        //member variables (has a)

        public List<Robot> robots;
        public Robot CurrentRobot;
        int counter;

        //constructor (spawner)
        public Fleet()
        {
            robots = new List<Robot>();
            robots.Add(new Robot("Yasuo", 750, 100, 100));
            robots.Add(new Robot("Ashe", 500, 150, 100));
            robots.Add(new Robot("Leona", 1000, 75, 100));
        }
        //member methods (can do)
        public void IdiotProof()
        {

            if (counter <= 3)
            {
                counter += 1;
                Console.Clear();
                ChooseRobot();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("You have failed humanity! Hit enter to wake up!");
                // add in final game code later
            }
        }
        public void ChooseRobot()
        {
            List<string> RobotNames = new List<string>();
            for (int i = 0; i < robots.Count; i++)
            {
                if (robots[i].health <= 0)
                {
                    robots.RemoveAt(i);
                }
            }
            for (int j = 0; j < robots.Count; j++)
            {
                RobotNames.Add(robots[j].name);
            }
            Console.WriteLine("Choose your robot: ");
            for (int k = 0; k < RobotNames.Count; k++)
            {
                Console.Write(RobotNames[k] + " \n");
            }
            string userInput = Console.ReadLine().ToLower();
            Console.Clear();
            foreach (var RobotChoice in robots)
            {
                if (userInput == RobotChoice.name.ToLower())
                {
                    CurrentRobot = RobotChoice;
                }
                else
                {
                    Console.Clear();
                    IdiotProof();
                }
                
            }
        }

    }
}

