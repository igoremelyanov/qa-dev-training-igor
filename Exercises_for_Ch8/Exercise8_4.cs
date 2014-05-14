using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Exercises_for_Ch8
{
    [TestFixture]
    public class Exercise8_4
    {
        public class Tester
        {
            public void Run()
            {
                Console.Write("Input an integer: ");
                //int x = Convert.ToInt32(Console.ReadLine());
                int x = 3;
                int doubleX; // uninitialized
                int tripleX; // uninitialized
                DoublerAndTripler(x, out doubleX, out tripleX);
                Console.WriteLine("Double {0} = {1}; triple {2} = {3}", x, doubleX, x, tripleX);
            }

            private static void DoublerAndTripler(int theVal, out int doubleValue, out int tripleValue)
            {
                doubleValue = theVal*2;
                tripleValue = theVal*3;
            }
        }

        [Test]
        public void Testing_References_but_differntli()
        {
            Tester t = new Tester();
            t.Run();
        }
    }

}
