using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Exercises__for_Ch7
{
    [TestFixture]
    public class Exercice7_1and7_2
    {
        class Math
        {
            public int Add(int Left, int Right)
            {
                return Left+Right;
            }

            public int Multiply(int Left, int Right)
            {
                return Left * Right;
            }

        }

        class Static_Math
        {
            static public int Add(int Left, int Right)
            {
                return Left + Right;
            }
            
            static public int Multiply(int Left, int Right)
            {
                return Left * Right;
            }
        }

        public class Viechle
        {
            public string Color;
            private string Size;
            protected int Wheels;

            public int Get_Wheels(int Wheels)
            {
                return Wheels;
            }

        }

        private class Toyota : Viechle
        {
            public int Get_Wheels_Toyota(int Wheels2)
            {
                Console.WriteLine("Wheel:{0}", Wheels2);
                return Wheels2 = Wheels; 
            }
            
        }


        [Test]
        public void Testing_First_Created_Class_Named_MATH()
        {
            
            Math m = new Math();
            int Sum = m.Add(3,5);
            int product = m.Multiply(3, 5);

            Console.WriteLine("Sum:{0}", Sum);

        }

        [Test]
        public void Testing_MATH_with_STATIC_Methods()
        {
            int Mul = Static_Math.Multiply(3, 5);
            int prod = Static_Math.Add(3, 5);
            Console.WriteLine("Mul:{0}", Mul);

        }

        [Test]
        public void Testing_PROTECTED_one()
        {
            Toyota car = new Toyota();
            car.Get_Wheels_Toyota(5);


        }




    }
}
