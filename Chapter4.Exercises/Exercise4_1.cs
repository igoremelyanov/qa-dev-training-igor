using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Exercise_Solutions_Ch4
{
    [TestFixture]
    public class Exercises4_1
    {
        ////////////////Exercise 4-1
        
        [Test]
        public void Var()
        {
           // int x = 25;
            
           // x+= 1;
            //int result = x++;
           // Console.WriteLine("result {0}", result);
           // Assert.AreEqual(27, result , "Meanig result ");
            //x = x+5000;
           // x += 1;
            //Console.WriteLine("summ  x+=1 {0}", x);

           // int y = 6;

            //Console.WriteLine("summ x+y {0}", x + y);
           //ssert.AreEqual(30, x+y, "Meanig summ x + y not equal 30 ");

            //if (x+y || 30) && (x+y=30)
             //{
              //throw new Exception("Summ x + y return wrong value");
             //} 
        //else
            //{
              //  /throw new Exception("Summ x + y return wrong value");
                
           // }

            int original = 10;
            int result;
            //result = ++original; //from book
            //same as
            result = original+1;
            original +=1;

            Console.WriteLine("After prefix: {0}, {1}", original, result);
            // assign then increment
            
            //result = original++; //from book
            //same as
            result = original;
            original +=1 ;
            Console.WriteLine("After postfix: {0}, {1}", original, result);


            bool p = true;
            bool q = false;
            bool r = true;

            if (p && q) 
            {
                Console.WriteLine("TRUE {0}, {1}", p, r);
            }
            else
            {
               Console.WriteLine("FALSE {0}, {1}", p, r);
               
            }


            int input=1;
            string classify;
            // if-else construction.
            if (input > 0)
                classify = "positive";
            else
                classify = "negative";

            // ?: conditional operator.
            classify = (input > 0) ? "positive" : "negative";

            Console.WriteLine("CLASSIFY {0}", classify);
           





        }

    }
}
