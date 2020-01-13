using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace League_of_Dinasaurs_vs_Robots
{
    class Battlefield
    {
        //member variables (has a)
        public Herd herd;
        public Fleet fleet;
        //constructor (spawner)
        public Battlefield()
        {
            herd = new Herd();
            fleet = new Fleet();
        }

        //member methods (can do)
        public void Instructions()
        {
            Console.WriteLine("Welcome to League of Robots! \n" +
                "We are in a time far ahead of your own, and have called your concious forward through a dream continuium! \n " +
                "You have been selected as having extrodinary capabilites that we need to utilize to ensure human exsistance! \n" +
                "You will be given three Robots to choose from. Should one fall you will be transfered to another! \n" +
                "Should all three fall, your concious will be transported back to 2020, and you will wake up from a bad dream! \n" +
                "However the Human race will have lost its last chance at survival, make sure you win! \n" +
                "\n" +
                "We have selected three of our best Robots for you! \n" +
                "Yasuo - Is a Fighter class, melee attacks with average attack and health! \n" +
                "Ashe - Is a Ranged class, ranged attacks with high attack and less health \n" +
                "Leona - Is a Tank class, melee attacks with low attack and high health");

        }
        public void RunSim()
        {
            Instructions();
            fleet.ChooseRobot();
            herd.ChooseDinosaur();
            DisplayScreen();
        }
        public void DisplayScreen()
        {
            Console.WriteLine("Enemy: " + herd.CurrentDinosaur.type +
                "\nHealth: " + herd.CurrentDinosaur.health +
                "\nAttack: " + herd.CurrentDinosaur.attackPower +
                 "\n" +
                "\nRobot: " + fleet.CurrentRobot.name +
                "\nHealth: " + fleet.CurrentRobot.health +
                "\nPower Level: " + fleet.CurrentRobot.powerLevel);
            GameDecision();
        }
        public void PlayerChoice()
        {
            Console.WriteLine("\nPlease choose to:\n1: Attack\n2: Dodge\n3: Charge!");
            string userdecision = Console.ReadLine();
            switch (userdecision)
            {
                case "1":
                    RoboAttackSeq();
                    break;
                case "2":

                    break;
                case "3":

                    break;
                default:
                    Console.Clear();
                    DisplayScreen();
                    break;
            }
            Console.ReadLine();
        }
        public string ComputerChoice()
        {
            List<String> Options = new List<string>() { "1", "2", "3" };
            Random random = new Random();
            int index = random.Next(Options.Count);

            string computerChoice = Options[index];

            switch (computerChoice)
            {
                case "1":
                    DinoAttackSeq();
                    break;
                case "2":
                    //blocksequence();
                    break;
                case "3":
                    //Chargesequence();
                    break;
                default:

                    break;
            }
            return computerChoice;
        }
        public void DinoAttackSeq()
        {
            fleet.CurrentRobot.health -= herd.CurrentDinosaur.attackPower;
        }
        public void RoboAttackSeq()
        {
            herd.CurrentDinosaur.health -= fleet.CurrentRobot.attackPower;
        }
        public void TurnSequence()
        {
            if (fleet.CurrentRobot.health > 0 && herd.CurrentDinosaur.health > 0)
            {
                PlayerChoice();
                ComputerChoice();
                DisplayScreen();
                Console.Clear();
            }
            else if (fleet.CurrentRobot.health <= 0)
            {
                Console.WriteLine(fleet.CurrentRobot.name + "has taken too much damage and is non-functional, please one of the remaining robots!");
                fleet.ChooseRobot();
                DisplayScreen();
            }
            else if (herd.CurrentDinosaur.health <= 0)
            {
                
                herd.ChooseDinosaur();
                DisplayScreen();
                //replace fighter
            }


        }
        public void GameDecision()
        {
            if (herd.dinosaurs.Count > 0 && fleet.robots.Count > 0)
            {
                TurnSequence();
            }
            else if (herd.dinosaurs.Count == 0)
            {
                WinnerMessage();
                Console.ReadLine();
            }
            else if (fleet.robots.Count == 0)
            {
                LoserMessage();
                Console.ReadLine();
            }
        }
        public void WinnerMessage()
        { 
            Console.Clear();
            Console.WriteLine("Thank you for all you have done for humanity!\n You will not be able to be compensated and no one from your time will know what you have done!\nBut know that from this point on in history you will be remembered");
            Console.ReadLine();
        }
        public void LoserMessage()
        {
            Console.Clear();
            Console.WriteLine("Humanity has lost, it will not affect your time. However you now live with the knowledge that you have doomed humanity");
            Console.ReadLine();
        }

    }
}


