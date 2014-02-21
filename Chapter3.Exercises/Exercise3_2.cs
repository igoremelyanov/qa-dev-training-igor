using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Exercises
{
    [TestFixture]
    public class Exercise3_2
    {
        ////////////////Exercise 3-2
        [Test]
        public void PrinOutAgain()
         {
            int i = 25;
            float f = 100.3f;
            double d = 98765.4321;
            char chr = 'M';
            string Str = "The quick movement of the enemy will jeopardize six gun boats";
            Console.Out.WriteLine("i {0}, float {1} double {2} , char {3}, string {4}", i, f, d, chr, Str);
         }
    }

}
