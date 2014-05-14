using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Exercises_for_Ch8
{
    [TestFixture]
    public class Exersise8_1
    {
        public class Tripler
        {
            public int TriplerInt;
            public float TriplerFloat;

            public void Run_Int()
            {
                Console.WriteLine("Triple Int {0}", TriplerInt);
            }

            public void Run_Float()
            {
                Console.WriteLine("Triple Float {0}", TriplerFloat);
            }

            //constructor
            public Tripler(int theVal)
            {
               // return theVal*3;
               TriplerInt = theVal*3;
            }

            //overload constructor
            public Tripler(float theVal)
            {
                //return theVal * 3.0f;
                TriplerFloat = theVal*3.0f;
            }

       }

        [Test]
        public void Testin_Overloading_Constractor()
        {
            Tripler tripler1 = new Tripler(5);
            Tripler tripler2 = new Tripler(5.3f);
            //Console.WriteLine("Triple int {0} ", tripler1.TriplerInt);
            //Console.WriteLine("Triple float {0} ", tripler2.TriplerFloat);

            tripler1.Run_Int();
            tripler2.Run_Float();

        }   

    }
}
