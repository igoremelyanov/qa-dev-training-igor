using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

 
    [TestFixture]
    public class Exercise_5_1
        {
        [Test]
        public void Statment_While()
        {
            int i = 0;
            while (++i <=10)
            {
                Console.WriteLine("i= {0}", i);
                //i +=1;
                //i++;
            }
            

        }

        [Test]
        public void Statment_Do_while()
        {
            int j = 0;
            do
            {
                Console.WriteLine("j= {0}", j);

            } while (++j <= 10);
        }

        [Test]
        public void Statment_For()
        {
            for (int g = 0; g <= 10; ++g)
            {
                Console.WriteLine("g= {0}", g);
            }
        }


        }
    

