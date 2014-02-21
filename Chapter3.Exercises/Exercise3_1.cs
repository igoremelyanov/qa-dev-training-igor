using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Exercises
{
    [TestFixture]
    public class Exercise3_1
    {
         ////////////////Exercise 3-1
        [Test]
        public void DifferentVariables()
        {
            int i = 42;
            float f = 98.6f;
            double d = 1234567.56677;
            char chr = 'Z';
            string Str = "The quick brown fox jumped over the lazy dogs";
            Console.Out.WriteLine("i {0}, float {1} double {2} , char {3}, string {4}", i, f, d, chr, Str);
        }
    }
}
