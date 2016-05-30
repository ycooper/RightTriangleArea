using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RightTriangleArea;

namespace TriangleTest
{
    [TestClass]
    public class RightTriangleTest
    {
        [TestMethod]
        public void RightTriangle_NegativeSides_ArgumentException()//Проверка сторон на отрицательные значения
        {
            //arrange
            double a = 1;
            double b = -7;
            double c = 3;

            //act
            try
            {
                RightTriangle TestTriangle = new RightTriangle(a, b, c);
            }
            catch (ArgumentException e)
            {
                //assert
                StringAssert.Contains(e.Message, RightTriangle.NegativeSideErrorMessage);
                return;
            }
            Assert.Fail("No exception was thrown.");
        }

        [TestMethod]
        public void RightTriangle_InvalidSides_ArgumentException()//Проверка треугольника на прямоугольность
        {
            //arrange
            double a = 1;
            double b = 7;
            double c = 3;

            //act
            try
            {
                RightTriangle TestTriangle = new RightTriangle(a, b, c);
            }
            catch (ArgumentException e)
            {
                //assert
                StringAssert.Contains(e.Message, RightTriangle.PythagoreanErrorMessage);
                return;
            }
            Assert.Fail("No exception was thrown.");
        }

        [TestMethod]
        public void RightTriangle_CorrectInput_Area()//Проверка правильности расчета площади
        {
            // arrange
            double a = 5;
            double b = 3;
            double c = 4;
            double expected = 6;
            RightTriangle TestTriangle = new RightTriangle(a, b, c);

            // act
            double area = TestTriangle.Area();

            // assert
            Assert.AreEqual(expected, area, 0.001, "Area is incorrect");
        }
    }
}
