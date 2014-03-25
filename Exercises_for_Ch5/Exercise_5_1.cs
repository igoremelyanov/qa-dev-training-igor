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
    public void IFELSE_Example()
    {
        int valueOne = 10;
        int valueTwo = 20;

        Console.WriteLine("Testing valueOne against valueTwo...");


        if (valueOne > valueTwo)
        {
            Console.WriteLine("ValueOne: {0} larger than ValueTwo: {1}",
                              valueOne, valueTwo);
            //Assert.True(valueOne > valueTwo, "ValueOne should be > than ValueTwo"); 
        }
        else
        {
            Console.WriteLine("Nope, ValueOne: {0} is NOT larger than ValueTwo:{1}", valueOne, valueTwo);
            //Assert.True(valueOne < valueTwo, "ValueOne should be > than ValueTwo"); 
        }


    }

    [Test]
    public void Statment_While2()
    { 
        int counterVariable = 0;
    // while the counter variable is less than 10
    // print out its value
        while (++counterVariable < 10)
            {       
                Console.WriteLine("counterVariable: {0}", counterVariable);
                 
            }

   
}
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
                //j += 2;
                //j = j + 2;
            } while ((j+=2) <= 10);
        }

        [Test]
        public void Statment_For()
        {
            for (int g = 0; g <= 10; ++g)
            {
                Console.WriteLine("g= {0}", g);
            }
        }

    [Test]
     public void Stat_For_fromMira()
    {
        for (int counter = 1; counter <= 200; counter++)
        {
            Console.Write("{0} ", counter);
            if (counter % 10 == 0)
            {
                Console.WriteLine("\t{0}", counter);
            }
        }
    }

}
    

