using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Exercises
{
    [TestFixture]
    public class Exercise4_2
    {
        [Test]
        public void TryIt()
        {
            int varA = 5;
            int varB = ++varA;
            int varC = varB++;
            Console.WriteLine( "A: {0}, B: {1}, C: {2}", varA, varB, varC );
        }

    }
}
