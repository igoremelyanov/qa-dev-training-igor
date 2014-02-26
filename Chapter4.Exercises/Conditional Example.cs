using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Exercise_Solutions_Ch4
{
    [TestFixture]
    public class Conditional_Example
    {
        [Test]
        public void Conditional()
        {
            int valueOne = 10;
            int valueTwo = 20;
            int maxValue = valueOne > valueTwo ? valueOne : valueTwo;
            Console.WriteLine("ValueOne: {0}, valueTwo: {1}, maxValue: {2}", valueOne, valueTwo, maxValue);
        }
    }
}
