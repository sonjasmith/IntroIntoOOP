using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroIntoOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat1 = new Cat();
            Cat cat2 = new Cat("neko", "black",3, 1, true,false);

            //Console.WriteLine(cat1.Name);
            //Console.WriteLine(cat2.Name);
            cat1.Name = "gato";
            //Console.WriteLine(cat1.Name);
            //Console.WriteLine(cat2.Age);
            //Console.WriteLine(cat1.Age);

            //cat2.Eat();
            //cat2.Run();
            ////cat2.Eat();
            //cat2.Talk();
            //cat1.Talk();
            //cat1.FurColor = "red";
            //Console.WriteLine(cat1.FurColor);
            Dog coco = new Dog();

            //coco.Run();
            //coco.Cuddle("Sam");
            //Console.WriteLine(coco.Weight);
            //coco.Weight = 400;
            //Console.WriteLine(coco.Weight);



            SuperHero goodGuy = new SuperHero("Super Good Guy");
            goodGuy.FightEvil();
            goodGuy.FightEvil();
            goodGuy.FightEvil();
            goodGuy.FightEvil();
            goodGuy.FightEvil();
            goodGuy.FightEvil();
            goodGuy.NextLevel();
        }
    }
}
