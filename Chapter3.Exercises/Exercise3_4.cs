using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Exercises
{
    [TestFixture]
    public class Exercise3_4
    {
        ///////// Exercise3-4
        /// 
        enum MyCalendar
        {
            Jaun = 1,
            Feb = 2,
            March = 3,
            April = 4
        }

        [Test]
        public void EnumCalendar()
        {
            
            Console.WriteLine("{0}",(int)MyCalendar.Feb);


        }
    }
}
