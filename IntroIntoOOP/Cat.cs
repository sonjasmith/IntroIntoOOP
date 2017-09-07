using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroIntoOOP
{
    class Cat
    {
        //private is an access modifier. class itself only has access to the cat string field
        //fields are instance variables that
        private string name;
        private string furColor;
        private int furLength;
        private bool isMale;
        private int age;
        private bool isHungry;

        //properties (middle man)
        public string Name
        {
            get { return this.name; }
            set { this.name = value; } //refers to the instance of that object
        }
        public string FurColor { get; set; }
        public int FurLength { get; set; }
       
        public int Age
        {
            get { return this.age; }
        }
        //every class has a default constructor w/no parameters
        public Cat()
        {
            this.name = "Mittens";
        }
        public Cat(string name)
        {
            this.name = name;
        }
        //method overloading parameters
        public Cat (int age)
        {

        }
        public Cat(string name, string furColor, int furLength, 
            int age, bool isMale, bool isHungry)
        {  
            this.name = name;
            this.furColor = furColor;
            this.furLength = furLength;
            this.age = age;
            this.isMale = isMale;
            this.isHungry = isHungry;
            
            
        }
        public void Eat()
        {
            if (isHungry)
            {
                Console.WriteLine("I'm stuffed!");
            }
            else if (!isHungry) //
            {
                Console.WriteLine("I'm good, no food for me."); 
            }
        }
        public void Run()
        {
            Console.WriteLine("I am running really fast!");
            this.isHungry = true;
        }
        public void Sleep()
        {
            Console.WriteLine("I'm sleeping...zzz");
        }
        public void Talk()
        {
            Console.WriteLine("My name is{0} and yes I can talk",this.name);
        }
    }
}
