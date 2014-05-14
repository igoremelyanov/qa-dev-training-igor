using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Exercises_for_Ch8
{
    [TestFixture]
    public class Exersise8_2222
    {
        public class Dog
        {
            //private int weight;
            //private string color;

            public int Weight { get; set; }
            public string Color { get; set; }

            public void DisplayDog()
            {
                Console.WriteLine("The dog weighs {0} pounds and is {1}.", Weight, Color);
            }

            public Dog(int myWeight, string myColor)
            {
                Weight = myWeight;
                Color = myColor;
            }
        }

        public class Tester
        {
            public void Run()
            {
                Dog fluffy = new Dog(77, "brown");
                fluffy.DisplayDog();
                Console.WriteLine("The dog is still {0}.", fluffy.Color);
                Console.Write("What is the dog's new weight? ");
                //int newWeight = Convert.ToInt32(Console.ReadLine());
                int newWeight = 770;
                fluffy.Weight = newWeight;
                fluffy.DisplayDog();
            }
        }

        [Test]
        public void Testing_Properties_of_Class_Dog()
        {
            Tester t = new Tester();
            t.Run();

        }
    }
}
