using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Exercises_for_Ch10
{
    [TestFixture]
    class Exercise10_2
    {
        public class SortExecution
        {
            public void Run()
            {
                int[] intArray = new int[10];
                Console.WriteLine("You'll be asked to enter 10 integers");
                // enter data into the array
                for (int i = 0; i < intArray.Length; i++)
                {
                    Console.Write("Enter an integer: ");
                    //string theEntry = Console.ReadLine();
                    string theEntry = i.ToString()+10; 
                    intArray[i] = Convert.ToInt32(theEntry);
                }
                // sort and reverse the array
                //Array.Sort(intArray);
                Array.Reverse(intArray);
                Console.WriteLine("\nValues:");
                foreach (int j in intArray)
                {
                    Console.WriteLine("{0}", j);
                }
            }
        }

        [Test]
        public void Testing_Array_Sort_and_Reverse()
        {
            SortExecution se = new SortExecution();
            se.Run();
        }
    }
}
