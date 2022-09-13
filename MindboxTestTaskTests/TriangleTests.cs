using Microsoft.VisualStudio.TestTools.UnitTesting;
using MindboxTestTask;

namespace MindboxTestTaskTests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void Triangle_Square_MustBeCorrect()
        {
            double SideA = 5;
            double SideB = 3;
            double SideC = 4;
            double expected = 6;

            Triangle triangle = new Triangle(SideA, SideB, SideC);
            double actual = triangle.Square();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Triangle_CheckRightTriangle_MustBeCorrect_True()
        {
            double SideA = 3;
            double SideB = 5;
            double SideC = 4;
            bool expected = true;

            Triangle triangle = new Triangle(SideA, SideB, SideC);
            bool actual = triangle.CheckRightTriangle();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TriangleCheckRightTriangle_MustBeCorrect_False()
        {
            double SideA = 10;
            double SideB = 5;
            double SideC = 8;
            bool expected = false;

            Triangle triangle = new Triangle(SideA, SideB, SideC);
            bool actual = triangle.CheckRightTriangle();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Triangle_Сreation_MustThrowsErrorIfSideLessThenZero()
        {
            double SideA = -10;
            double SideB = 5;
            double SideC = 8;

            Assert.ThrowsException<FigureException>(() =>
            {
                Triangle triangle = new Triangle(SideA, SideB, SideC);
            });
        }

        [TestMethod]
        public void Triangle_Сreation_MustThrowsErrorIfSummTwoSidesMoreThenThirdSide()
        {
            double SideA = 25;
            double SideB = 6;
            double SideC = 8;

            Assert.ThrowsException<FigureException>(() =>
            {
                Triangle triangle = new Triangle(SideA, SideB, SideC);
            });
        }
    }
}
