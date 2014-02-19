using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Chapter3.Exercises
{
    [TestFixture]
    public class Exercises
    {
        ////////////////Exercise 3-1
        
        //  private DateTime _dateTime;
        [Test]
        public void ImplicitCasting()
        {
            int i = 12;
            byte j = 4;
            Console.Out.WriteLine("int {0} +  byte {1} = total int {2}", i, j, i + j);
        }

    }
}
