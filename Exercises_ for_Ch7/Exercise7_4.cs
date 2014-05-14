using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Exercises__for_Ch7
{
    [TestFixture]
    public class Exercise7_4
    {
        public class Point
        {
            public int xCoord;
            public int yCoord;

            public void DisplayPoint()
            {
                Console.WriteLine("({0}, {1})", xCoord, yCoord);
            }

            //constructor
            public Point(int x, int y)
            {
                xCoord = x;
                yCoord = y;
            }
        }

        public class Square
        {
            private Point topLeft;
            private Point topRight;
            private Point bottomRight;
            private Point bottomLeft;
            private int sideLength;

            public void displaySquare()
            {
                Console.WriteLine("The four corners are:");
                topLeft.DisplayPoint();
                topRight.DisplayPoint();
                bottomLeft.DisplayPoint();
                bottomRight.DisplayPoint();
            }

            //constructor
            public Square(Point myPoint, int myLength)
            {
                sideLength = myLength;
                topLeft = myPoint;
                topRight = new Point(topLeft.xCoord + sideLength, topLeft.yCoord);
                bottomLeft = new Point(topLeft.xCoord, topLeft.yCoord + sideLength);
                bottomRight = new Point(topLeft.xCoord + sideLength, topLeft.yCoord + sideLength);
            }

        }

        [Test]
        
        public void Testing_Graph_for_geometry()
        {
            Point startPoint = new Point(3, 3);
            int length = 5;
            Square mySquare = new Square(startPoint, length);
            mySquare.displaySquare();

        }

    }
}
