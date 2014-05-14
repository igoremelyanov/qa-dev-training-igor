using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Exercises_for_Ch8
{
    [TestFixture]
    public class Exersise8_2
    {
        public class Dog
        {
            private int weight;
            private string color;
            
            public int Weight
            {
                get
                {
                    return weight;
                }
                set
                {
                    weight = value;
                }
            }
            public string Color
            {
                get
                {
                    return color;
                }
                set
                {
                    color = value;
                }
            }

            public void DisplayDog()
            {
                Console.WriteLine("The dog weighs {0} pounds and is {1}.", weight, color);
            }

            public Dog()
            {
            }

            public Dog(int myWeight, string myColor)
            {
                weight = myWeight;
                color = myColor;
            }
        }

        public class Tester
        {
            public void Run()
            {
                Dog fluffy = new Dog(25, "brown");
                Dog Dog_Default_Constractor = new Dog();
                fluffy.DisplayDog();
                Console.WriteLine("The dog is still {0}.", fluffy.Color);
                Console.Write("What is the dog's new weight? ");
                //int newWeight = Convert.ToInt32(Console.ReadLine());
                int newWeight = 50;
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
