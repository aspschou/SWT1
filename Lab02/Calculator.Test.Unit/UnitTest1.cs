using System;
using NUnit.Framework;

namespace Calculator.Test.Unit
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        { }

        [TestCase(2, 2, 4)]
        [TestCase(-8, -8, -16)]
        [TestCase(-6, 2, -4)]
        public void AddTest(double a, double b, double c)
        {
            // Arrange
            calcC.Calculator uut = new calcC.Calculator();

            // Act
            double uu = uut.Add(a, b);

            // Assert
            Assert.AreEqual(c, uu);
        }

        [TestCase(2, 2, 0)]
        [TestCase(-2, -8, 6)]
        [TestCase(6, 8, -2)]
        public void SubtractTest(double a, double b, double c)
        {
            // Arrange
            calcC.Calculator uut = new calcC.Calculator();

            // Act
            double uu = uut.Subtract(a, b);

            // Assert
            Assert.AreEqual(c, uu);
        }

        [TestCase(-2, 3, -8)]
        [TestCase(4,7,16384)]
        [TestCase(5, -3, 0.008)]
        public void PowerTest(double a, double b, double c)
        {
            // Arrange
            calcC.Calculator uut = new calcC.Calculator();

            // Act
            double uu = uut.Power(a, b);

            // Assert
            Assert.AreEqual(c, uu);
        }

        [TestCase(2, 2, 4)]
        [TestCase(-4, -4, 16)]
        [TestCase(6, -8, -48)]
        public void MultiplyTest(double a, double b, double c)
        {
            // Arrange
            calcC.Calculator uut = new calcC.Calculator();

            // Act
            double uu = uut.Multiply(a, b);

            // Assert
            Assert.AreEqual(c, uu);
        }

        [TestCase(500.47,67,500.47/67)]
        [TestCase(24, 64, 0.375)]
        public void DivideTest(double a, double b, double c)
        {
            // Arrange
            calcC.Calculator uut = new calcC.Calculator();

            // Act
            double uu = uut.Divide(a, b);

            // Assert
            Assert.AreEqual(c, uu);
        }

        [TestCase(5,0)]
        public void DivideByZeroExceptionTest(double a, double b)
        {
            // Arrange
            calcC.Calculator uut = new calcC.Calculator();

            // Act & Assert
            Assert.Throws<DivideByZeroException>(() => uut.Divide(a, b));
        }

        [TestCase(7, 8, 9,24)]
        [TestCase(38, 1000000399, 2, 1000000439)]
        [TestCase(-6, 2, -4,-8)]
        public void AddToAccumulatorTest(double a, double b, double c, double d)
        {
            // Arrange
            calcC.Calculator uut = new calcC.Calculator();

            // Act
            double uu = uut.Add(a, b);
            uu = uut.Add(c);

            // Assert
            Assert.AreEqual(d, uu);
        }
    }
}