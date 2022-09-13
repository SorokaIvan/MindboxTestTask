using Microsoft.VisualStudio.TestTools.UnitTesting;
using MindboxTestTask;
using System;

namespace MindboxTestTaskTests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void Circle_Square_MustBeCorrect()
        {
            double diameter = 30;
            double expected = 706.5;

            Circle circle = new Circle(diameter);
            double actual = circle.Square();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Circle_Ñreation_MustThrowsErrorIfDiameterLessThenZero()
        {
            double diameter = -30;

            Assert.ThrowsException<FigureException>(() =>
            {
                Circle circle = new Circle(diameter);
            });
        }
    }
}