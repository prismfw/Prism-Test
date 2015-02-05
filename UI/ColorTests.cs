using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Prism.UI;

namespace Prism.UI
{
    [TestClass]
    public class ColorTests
    {
        //Add Color Checker to Make Sure Default Colors are Correct

        //Default Color Declarations
        Color purple = new Color(255, 0, 255);
        Color green = new Color(255, 255, 255);
        Color yellow = new Color(255, 255, 0);
        Color red = new Color(255,0,0);
        Color blue = new Color(0,0,255);


        [TestMethod]
        public void ColorAdd()
        {
            //Result Test Comparison Declarations
            Color brTest = new Color(255,0,255);
            Color byTest = new Color(255,255,255);
            Color rgTest = new Color(255,128,0);

            Color brResult = Color.Add(Color.Blue, Color.Red);
            Color byResult = Color.Add(Color.Blue, Color.Yellow);
            Color rgResult = Color.Add(Color.Red, Color.Green);

            Assert.AreEqual(brTest, brResult);
            Assert.AreEqual(byTest, byResult);
            Assert.AreEqual(rgTest, rgResult);
        }


        [TestMethod]
        public void ColorLerp()
        {
            //Lerp Results to Be Tested
            Color bwLerp = Color.Lerp(Color.Black, Color.White, 0.5f);
            Color rbLerp = Color.Lerp(Color.Red, Color.Blue, 0.5f);
            Color gyLerp = Color.Lerp(Color.Green, Color.Yellow, 0.5f);

            //Crazy Float Inputs
            Color bwLerpPosInfinity = Color.Lerp(Color.Black, Color.White, float.PositiveInfinity);
            Color bwLerpNan = Color.Lerp(Color.Black, Color.White, float.NaN);

            Color bwPosInfinity = new Color(255,255,255,255);
            Color bwNan = new Color(0,0,0,0);

            Assert.AreEqual(bwPosInfinity, bwLerpPosInfinity);
            Assert.AreEqual(bwNan, bwLerpNan);


            //Comparison Values for Final Verification of Lerp Method Functionality
            Color bwCmp = new Color(255,127,127,127);
            Color rbCmp = new Color(255,127,0,127);
            Color gyCmp = new Color(255,127,191,0);

            Assert.AreEqual(bwCmp, bwLerp);
            Assert.AreEqual(rbCmp, rbLerp);
            Assert.AreEqual(gyCmp, gyLerp);
        }

        [TestMethod]
        public void ColorLerpExceptions()
        { 
            
        }

        [TestMethod]
        public void ColorSubtract()
        {
            Color pbTest = new Color(0, 128, 0, 0);
            Color gbTest = new Color(0, 0, 128, 0);
            Color prTest = new Color(0, 0, 0, 128);

            Color pbResult = Color.Subtract(Color.Purple, Color.Blue);
            Color gbResult = Color.Subtract(Color.Green, Color.Blue);
            Color prResult = Color.Subtract(Color.Purple, Color.Red);

            Assert.AreEqual(pbTest, pbResult);
            Assert.AreEqual(gbTest, gbResult);
            Assert.AreEqual(prTest, prResult);
        }

        [TestMethod]
        public void ColorEqualsColor()
        {
            //Default Color Constructs
            Assert.IsTrue(Color.Blue.Equals(Color.Blue));
            Assert.IsTrue(Color.Red.Equals(Color.Red));
            Assert.IsTrue(Color.Yellow.Equals(Color.Yellow));

            //Init Color Struct from User Compared to Default
            Assert.IsTrue(Color.Equals(Color.Blue, blue));
            Assert.IsTrue(Color.Equals(Color.Red, red));
            Assert.IsTrue(Color.Equals(Color.Yellow, yellow));

            Assert.IsFalse(Color.Red.Equals(new Rectangle()));

        }

        [TestMethod]
        public void ColorOperators()
        {
            Assert.IsTrue(Color.Blue == Color.Blue);
            Assert.IsFalse(Color.Blue == Color.Red);

            Assert.IsTrue(Color.Yellow != Color.Orange);
            Assert.IsFalse(Color.Blue != Color.Blue);

            Color brTest = new Color(255, 0, 255);
            Color byTest = new Color(255, 255, 255);
            Color rgTest = new Color(255, 128, 0);

            Color brResult = Color.Blue + Color.Red;
            Color byResult = Color.Blue + Color.Yellow;
            Color rgResult = Color.Red + Color.Green;

            Assert.AreEqual(brTest, brResult);
            Assert.AreEqual(byTest, byResult);
            Assert.AreEqual(rgTest, rgResult);
        }
    }
}
