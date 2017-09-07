﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroIntoOOP
{
    class SuperHero
    {
        private string alterEgo;
        private int currentPower;
        private int maxPower;
        private int numberOfBattles;

        //properties
        public string AlterEgo
        {
            get { return this.alterEgo; }
            set { this.alterEgo = value; }
        }

        public int CurrentPower
        {
            get { return this.currentPower; }

        }

        public int MaxPower
        {
            get { return this.maxPower; }

        }

        public int NumberOfBattles
        {
            get { return this.numberOfBattles; }

        }
        
        //constructors
        public SuperHero()
        {
            this.alterEgo = "Bag Guy";
            this.currentPower = 5;
            this.maxPower = 5;
            this.numberOfBattles = 0;
        }
        
        public SuperHero(string alterEgo)
        {
            this.alterEgo = alterEgo;
            this.currentPower = 10;
            this.maxPower = 10;
            this.numberOfBattles = 0;
        }

        public void FightEvil()
        {
            if(this.currentPower < 2)
            {
                Console.WriteLine("I'm to weak to fight I need sleep!");
            }
            else
            {
                this.numberOfBattles += 1;
                this.currentPower -= 2;
                Console.WriteLine("That was tough but I made it out ok. My current power is {0}", this.currentPower);
            }
           
        }

        //default
        public void Sleep()
        {
            Console.WriteLine("I feel better than ever!! I am at max Power!!");
            this.currentPower = maxPower;
        }

        public void NextLevel()
        {
            if(numberOfBattles % 3 == 0)
            {
                this.maxPower += 10;
                this.currentPower = this.maxPower;
            }
            else
            {
                Console.WriteLine("You don't have enough battles under your belt.");
            }
        }
    }
}
