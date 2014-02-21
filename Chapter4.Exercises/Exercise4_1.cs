using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Exercises
{
    [TestFixture]
    public class Exercises4_1
    {
        ////////////////Exercise 4-1
        
        [Test]
        public void Var()
        {
            int x = 25;
            int y = 6;

            Console.WriteLine("summ x+y {0}", x + y);
            Assert.AreEqual(30, x+y, "Meanig summ x + y not equal 30 ");

            //if (x+y != 30)
             //{
              //throw new Exception("Summ x + y return wrong value");
             //} 


        }

    }
}
