using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Exercises__for_Ch7
{
    [TestFixture]
    public class Exercice7_1
    {
        class Math
        {
            public int Add(int Left, int Right)
            {
                return Left+Right;
            }
        }

        class Static_Math
        {
            static public int Multiplay(int Left, int Right)
            {
                return Left * Right;
            }
        }


        [Test]
        public void Testing_First_Created_Class_Named_MATH()
        {
            Math m = new Math();
            int Sum = m.Add(3,5);

            Console.WriteLine("Sum:{0}", Sum);

        }

        [Test]
        public void Testing_MATH_with_STATIC_Methods()
        {
            int Mul = Static_Math.Multiplay(3, 5);

            Console.WriteLine("Mul:{0}", Mul);

        }




    }
}
