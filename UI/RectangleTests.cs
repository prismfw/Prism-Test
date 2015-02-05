using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Prism.UI
{
    [TestClass]
    public class RectangleTests
    {
        [TestMethod]
        public void RectangleInstantiations()
        {
            //Size Struct for Rectangle Instantiation
            Size rectangleSize = new Size(20,20);

            //Point Struct for Rectangle Instantiation
            Point rectanglePoint1 = new Point(10,10);
            Point rectanglePoint2 = new Point(15,5);

            //Instantiation of Rectangle from Size Struct
            Rectangle rectangleFromSize = new Rectangle(rectangleSize);

            //Instantiation of Rectangle from Point Structs
            Rectangle rectangleFromPoints = new Rectangle(rectanglePoint1,rectanglePoint2);

            //Comparison Rectangle for Size Struct
            Rectangle rectangleComparisonSize = new Rectangle(0,0,20,20);

            //Comparison Rectangle for Points Struct
            Rectangle rectangleComparisonPoints = new Rectangle(10,10,5,-5);

            //Assert Statements
            Assert.AreEqual(rectangleComparisonSize, rectangleFromSize);
            Assert.AreEqual(rectangleComparisonPoints, rectangleFromPoints);

        
        }

        [TestMethod]
        public void RectangleBuiltins()
        {
            //Rectangle Struct Instantiation
            Rectangle rectangleCordinates = new Rectangle(10,10,20,25);

            //Coordinate Verification
            Assert.IsTrue(rectangleCordinates.Bottom == 35);
            Assert.IsTrue(rectangleCordinates.Top == 10);
            Assert.IsTrue(rectangleCordinates.Left == 10);
            Assert.IsTrue(rectangleCordinates.Right == 30);

        }

        
        [TestMethod]
        public void RectangleBuiltinEquals()
        {
            //Instantiate Rectangle for Equality Testing
            Rectangle testRectangle1 = new Rectangle(1, 1, 10, 10);
            Rectangle testRectangle2 = new Rectangle(1, 1, 10, 10);
            Rectangle testRectangle3 = new Rectangle(1, 1, 30, 40);

            //Test Cases
            Assert.IsTrue(testRectangle1.Equals(testRectangle2));
            Assert.IsTrue(Rectangle.Equals(testRectangle1, testRectangle2));
            Assert.IsFalse(Rectangle.Equals(testRectangle1, testRectangle3));
            Assert.IsFalse(testRectangle1.Equals(testRectangle3));

        
        }

        [TestMethod]
        public void RectangleContains()    
        {
            //Instantiate Points to Test
            Point testPoint1 = new Point(1,1);
            Point testPoint2 = new Point(21,32);

            //Instantiate Inner Test Rectangle
            Rectangle innerRectangle = new Rectangle(2, 2, 2, 2);

            //Instantiate Rectangle for Point Testing
            Rectangle testRectangle = new Rectangle(1, 1, 10, 10);

            //TestCases
            Assert.IsTrue(testRectangle.Contains(testPoint1));
            Assert.IsFalse(testRectangle.Contains(testPoint2));
            Assert.IsTrue(testRectangle.Contains(innerRectangle));
        }


        [TestMethod]
        public void RectangleOperators()
        {
            //Instantiate Rectangle for Operator Testing
            Rectangle testRectangle1 = new Rectangle(1, 1, 10, 10);
            Rectangle testRectangle2 = new Rectangle(1, 1, 10, 10);
            Rectangle testRectangle3 = new Rectangle(1, 1, 30, 40);

            //Test Cases
            Assert.IsTrue(testRectangle1 == testRectangle2);
            Assert.IsTrue(testRectangle1 != testRectangle3);
            Assert.IsFalse(testRectangle1 == testRectangle3);
        }


        [TestMethod]
        public void RectangleUnion()
        {
            //Instantiate Rectangle for Union Testing
            Rectangle testRectangle1 = new Rectangle(10, 10, 10, 10);
            Rectangle testRectangle2 = new Rectangle(10, 10, 10, 10);

            //Instantiate Points for Union Testing
            Point testPoint1 = new Point(30,30);
            Point testPoint2 = new Point(-5, -22);

            //Instantiate Comparison Rectangle
            Rectangle comparisonRectangle1 = new Rectangle(10,10,20,20);
            Rectangle comparisonRectangle2 = new Rectangle(-5,-22,25,42);

            //Union Result Rectangles
            testRectangle1.Union(testPoint1);
            testRectangle2.Union(testPoint2);

            //Test Cases
            Assert.AreEqual(comparisonRectangle1,testRectangle1);
            Assert.AreEqual(comparisonRectangle2, testRectangle2);
        }

    }
}
