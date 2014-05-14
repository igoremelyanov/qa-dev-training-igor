using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Exercises_for_Ch9
{
    [TestFixture]
    public class Exercise9_2
    {
        public class Spagety
        {
            public void Run()
            {
                int myInt = 42;
                float myFloat = 9.685f;
                Console.WriteLine("Before starting: \n value of myInt:{0} \n value of myFloat: {1}", myInt, myFloat);
                // pass the variables by reference
                Multiply( ref myInt, ref myFloat );
                Console.WriteLine("After finishing: \n value of myInt:{0} \n value of myFloat: {1}", myInt, myFloat);
             }

            private static void Multiply (ref int theInt,ref float theFloat)
            {
                theInt = theInt * 2;
                theFloat = theFloat *2;
                Divide( ref theInt, ref theFloat);
            }
            private static void Divide (ref int theInt,ref float theFloat)
            {
                theInt = theInt * 3;  //error here -> must be /
                theFloat = theFloat * 3; //error here -> must be /
                Add(ref theInt, ref theFloat);
            }

            public static void Add(ref int theInt, ref float theFloat)
            {
                theInt = theInt - theInt; //error -> +
                theFloat = theFloat - theFloat;//error -> +
            }

        }

        [Test]
        public void Test_for_Plaing_with_Debugger_to_findf_bug_here()
        {
            Spagety s = new Spagety();
            s.Run();
        }
    }
}
