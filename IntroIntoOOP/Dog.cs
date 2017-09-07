using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroIntoOOP
{
    class Dog
    {
        //private is an access modifier. class itself only has access to the cat string field
        //fields are instance variables that 
        private int hairLength;
        private int height;
        private int runningSpeed;
        private double weight;



    //properties (middle man)
    public int HairLength
    {
        get { return this.hairLength; }
        set { this.hairLength = value; } //refers to the instance of that object
    }

    public double Weight
    {
        get { return this.hairLength; }
        set { this.weight = value; }
    }

    public int Height
    {
        get { return this.height; }
        set { this.height = value; }
    }

    public int RunningSpeed
    {
        get { return this.runningSpeed; }
        set { this.runningSpeed = value; }
    }

    public Dog()
    {
        this.weight = 220d;
        this.height = 3;
        this.runningSpeed = 80;
        this.hairLength = 3;
    }

    public Dog(double weight, int height, int runningSpeed, int hairLength)
    {
        this.weight = weight;
        this.height = height;
    }

    public void Run()
    {
        Console.WriteLine("I am running faster than you!!!");
    }

    public void Cuddle(string name)
    {
        Console.WriteLine("{0} and the dog are cuddling...the dog is the big spoon", name);
    }
       }
    }

