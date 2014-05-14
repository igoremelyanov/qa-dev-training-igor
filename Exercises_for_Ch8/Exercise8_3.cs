using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Exercises_for_Ch8
{
    [TestFixture]
    public class Exercise8_3
    {
        public class Tester
        {
            public void Run()
            {
                Console.Write("Input an integer: ");
                //int x = Convert.ToInt32(Console.ReadLine());
                int x = 3;
                int doubleX = 0;
                int tripleX = 0;
                DoublerAndTripler(x, ref doubleX, ref tripleX);
                Console.WriteLine("Double {0} = {1}; triple {2} = {3}",x, doubleX, x, tripleX);
            }

            static void DoublerAndTripler(int theVal, ref int doubleValue, ref int tripleValue)
            {
                doubleValue = theVal * 2;
                tripleValue = theVal * 3;
            }

        }

        [Test]
        public void Testing_Reference()
        {
            Tester t = new Tester();
            t.Run();
        }

    }

   

    
}
