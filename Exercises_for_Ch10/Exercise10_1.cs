using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Exercises_for_Ch10
{
    [TestFixture]
    public class Exercise10_1
    {
        public class Dog
        {
            public int Weight { get; set; }
            public string Name { get; set; }

            public Dog(int theWeight, string theName)
            {
                this.Weight = theWeight;
                this.Name = theName;
            }
        }

        public class Execute
        {
            public void Run()
            {
                Dog milo = new Dog(26, "Milo");
                Dog frisky = new Dog(10, "Frisky");
                Dog laika = new Dog(50, "Laika");
                Dog[] dogArray = { milo, frisky, laika };
                // output array values
                foreach (Dog d in dogArray)
                {
                    Console.WriteLine("Dog {0} weights {1} pounds.", d.Name, d.Weight);
                }
            }
        }

        [Test]
        public void Testing_Array_of_Dog_Objects()
        {
            Execute e = new Execute();
            e.Run();

        }

    }

    

}
