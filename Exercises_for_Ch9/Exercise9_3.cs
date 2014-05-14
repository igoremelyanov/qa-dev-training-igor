using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Exercises_for_Ch9
{
    [TestFixture]
    public class Exercise9_3
    {
        public static int Factorial(int myInt)
        {
            int result = 1;
                       //error - must be i <= myInt
            for (int i = 1; i < myInt; i++)
            {
                result = result * i;
            }
            return result;
        }

        [Test]
        public void Tsting_Debugger_Factorial()  //the factorial of 5 is 5 × 4 × 3 × 2 × 1=120.)
        {
            int input = 5;
            Console.WriteLine("{0} factorial is {1}", input, Factorial(input));
        }

    }
}
