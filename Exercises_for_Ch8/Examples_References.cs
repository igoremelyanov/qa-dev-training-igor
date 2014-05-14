using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Exercises_for_Ch8
{
  [TestFixture]
  public class Examples_References
    {
      public class Doubler_Value
      {
          public void DoubleInt(int firstNum, int secondNum)
          {
              firstNum = firstNum * 2;
              secondNum = secondNum * 2;
          }
      }

      public class Doubler_Ref
      {
          public void DoubleInt(ref int firstNum, ref int secondNum)
          {
              firstNum = firstNum * 2;
              secondNum = secondNum * 2;
          }
      }

      private class Tester_Value
      {
          public void Run()
          {
              int first = 5;
              int second = 10;
              Console.WriteLine("Before doubling:");
              Console.WriteLine("First number: {0}, Second number: {1}",
              first, second);
              Doubler_Value d = new Doubler_Value();
              d.DoubleInt(first, second);
              Console.WriteLine("After doubling:");
              Console.WriteLine("First number: {0}, Second number: {1}",
              first, second);
          }

      }
      private class Tester_Ref
      {
          public void Run()
          {
              int first = 5;
              int second = 10;
              Console.WriteLine("Before doubling:");
              Console.WriteLine("First number: {0}, Second number: {1}",
              first, second);
              Doubler_Ref d = new Doubler_Ref();
              d.DoubleInt(ref first, ref second);
              Console.WriteLine("After doubling:");
              Console.WriteLine("First number: {0}, Second number: {1}",
              first, second);
          }

      }

      [Test] //////value    Befor and After - same result.  :(
      public void Testing_just_Values_from_TEXTbook()
      {
          Tester_Value t = new Tester_Value();
          t.Run();
      }


      [Test]  ////references  Now it's working  :)
      public void Testing_References_from_TEXTbook()
      {
          Tester_Ref t = new Tester_Ref();
          t.Run();
      }


    }
}
