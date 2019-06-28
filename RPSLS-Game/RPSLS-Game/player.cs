﻿using System;
using System.Collections.Generic;

namespace RPSLSGame
{
    public abstract class Player
    {
        // member variables (has a)
        public Random random;
        public List<string> Gestures;
        public string name;
        public string gesture;
        public int currentScore;
        public string input;
        public string randomNumber;

        //public int randomNumber;
        //public Random random;

        // constructor
        public Player()
        {
            
        }

        // member methods (can do)

        // adds each gesture to gestures List
        public void AddGestures()
        {
            Gestures.Add("rock");
            Gestures.Add("paper");
            Gestures.Add("scissors");
            Gestures.Add("lizard");
            Gestures.Add("spock");
        }

        // user chooses a gesture
        public virtual void ChooseGesture()
        {
            input = PlayerInput();
            switch (input)
            {
                case "1":
                    Console.WriteLine($"{name} played 'Rock'");
                    gesture = "rock";
                    break;
                case "2":
                    Console.WriteLine($"{name} played 'Paper'");
                    gesture = "paper";
                    break;
                case "3":
                    Console.WriteLine($"{name} played 'Scissors'");
                    gesture = "scissors";
                    break;
                case "4":
                    Console.WriteLine($"{name} played 'Lizard'");
                    gesture = "lizard";
                    break;
                case "5":
                    Console.WriteLine($"{name} played 'Spock'");
                    gesture = "spock";
                    break;
                default:
                    Console.WriteLine("Woops something unexpected happened!");
                    break;
            }
        }

        //public void RandomGesture()
        //{
        //    Console.Clear();
        //    random = new Random();
        //    randomNumber = Convert.ToString(random.Next(1, 6));

        //    switch (randomNumber)
        //    {
        //        case "1":
        //            Console.WriteLine($"{name} played 'Rock'");
        //            gesture = "rock";
        //            break;
        //        case "2":
        //            Console.WriteLine($"{name} played 'Paper'");
        //            gesture = "paper";
        //            break;
        //        case "3":
        //            Console.WriteLine($"{name} played 'Scissors'");
        //            gesture = "scissors";
        //            break;
        //        case "4":
        //            Console.WriteLine($"{name} played 'Lizard'");
        //            gesture = "lizard";
        //            break;
        //        case "5":
        //            Console.WriteLine($"{name} played 'Spock'");
        //            gesture = "spock";
        //            break;
        //        default:
        //            Console.WriteLine("Woops something unexpected happened!");
        //            break;
        //    }
        //}

        // player inputs
        public string PlayerInput()
        {
            Console.WriteLine("\nMake your move! Type one of the following numbers: \n1:Rock \n2:Paper \n3:Scissors \n4:Lizard \n5:Spock");
            input = Convert.ToString(Console.ReadLine());
            while (!ValidateHand(input))
            {
                ValidateHand(input);
                Console.WriteLine("Invalid user input.\nPlease type one of the following: 1:Rock, 2:Paper, 3:Scissors, 4:Lizard, and 5:Spock");
                input = Convert.ToString(Console.ReadLine());
            }
            return input;
        }

        // validates user input for gesture
        public bool ValidateHand(string input)
        {
            if (input == "1" || input == "2" || input == "3" || input == "4" || input == "5")
            {
                return true;
            }
            return false;
        }
    }
}
