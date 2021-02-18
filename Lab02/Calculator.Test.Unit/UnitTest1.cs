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

        [TestCase(2, 2)]
        [TestCase(0, 0)]
        [TestCase(-6, -6)]
        public void AddTestOneParameter(double a, double b)
        {
            // Arrange
            calcC.Calculator uut = new calcC.Calculator();

            // Act
            double uu = uut.Add(a);

            // Assert
            Assert.AreEqual(b, uu);
        }

        [TestCase(2, 2, 4)]
        [TestCase(-8, -8, -16)]
        [TestCase(-6, 2, -4)]
        public void AddTestTwoParameters(double a, double b, double c)
        {
            // Arrange
            calcC.Calculator uut = new calcC.Calculator();

            // Act
            double uu = uut.Add(a, b);

            // Assert
            Assert.AreEqual(c, uu);
        }

        [TestCase(2, -2)]
        [TestCase(-2, +2)]
        [TestCase(6, -6)]
        public void SubtractTestOneParameter(double a, double b)
        {
            // Arrange
            calcC.Calculator uut = new calcC.Calculator();

            // Act
            double uu = uut.Subtract(a);

            // Assert
            Assert.AreEqual(b, uu);
        }

        [TestCase(2, 2, 0)]
        [TestCase(-2, -8, 6)]
        [TestCase(6, 8, -2)]
        public void SubtractTestTwoParameters(double a, double b, double c)
        {
            // Arrange
            calcC.Calculator uut = new calcC.Calculator();

            // Act
            double uu = uut.Subtract(a, b);

            // Assert
            Assert.AreEqual(c, uu);
        }

        [TestCase(-2, 3, -8)]
        [TestCase(5, -3, 0.008)]
        [TestCase(-5, 3.5, double.NaN)]
        public void PowerTestOneParameter(double a, double b, double c)
        {
            // Arrange
            calcC.Calculator uut = new calcC.Calculator();
            uut.Add(a);

            // Act
            double uu = uut.Power(b);

            // Assert
            Assert.AreEqual(c, uu);

        }
        [TestCase(-2, 3, -8)]
        [TestCase(5, -3, 0.008)]
        [TestCase(-5, 3.5, double.NaN)]
        public void PowerTestTwoParameters(double a, double b, double c)
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
        [TestCase(0, -8, 0)]
        public void MultiplyTestOneParameter(double a, double b, double c)
        {
            // Arrange
            calcC.Calculator uut = new calcC.Calculator();
            uut.Add(a);

            // Act
            double uu = uut.Multiply(b);

            // Assert
            Assert.AreEqual(c, uu);
        }


        [TestCase(2, 2, 4)]
        [TestCase(-4, -4, 16)]
        [TestCase(0, -8, 0)]
        public void MultiplyTestTwoParameters(double a, double b, double c)
        {
            // Arrange
            calcC.Calculator uut = new calcC.Calculator();

            // Act
            double uu = uut.Multiply(a, b);

            // Assert
            Assert.AreEqual(c, uu);
        }

        [TestCase(500.47, 67, 500.47 / 67)]
        [TestCase(24, 64, 0.375)]
        public void DivideTestOneParameter(double a, double b, double c)
        {
            // Arrange
            calcC.Calculator uut = new calcC.Calculator();
            uut.Add(a);

            // Act
            double uu = uut.Divide(b);

            // Assert
            Assert.AreEqual(c, uu);
        }

        [TestCase(52.5, 7.5, 7)]
        [TestCase(24, 64, 0.375)]
        public void DivideTestTwoParameters(double a, double b, double c)
        {
            // Arrange
            calcC.Calculator uut = new calcC.Calculator();

            // Act
            double uu = uut.Divide(a, b);

            // Assert
            Assert.AreEqual(c, uu);
        }

        [TestCase(5,0)]
        public void DivideByZeroExceptionTestOneParameters(double a, double b)
        {
            // Arrange
            calcC.Calculator uut = new calcC.Calculator();
            uut.Add(a);

            // Act & Assert
            Assert.Throws<DivideByZeroException>(() => uut.Divide(b));
        }

        [TestCase(5,0)]
        public void DivideByZeroExceptionTestTwoParameters(double a, double b)
        {
            // Arrange
            calcC.Calculator uut = new calcC.Calculator();

            // Act & Assert
            Assert.Throws<DivideByZeroException>(() => uut.Divide(a, b));
        }

        [TestCase(2, 2)]
        [TestCase(0, 0)]
        [TestCase(-6, -6)]
        public void AddTestOneParameterAccumulator(double a, double b)
        {
            // Arrange
            calcC.Calculator uut = new calcC.Calculator();

            // Act
            uut.Add(a);

            // Assert
            Assert.AreEqual(b, uut.Accumulator);
        }

        [TestCase(2, 2, 4)]
        [TestCase(-8, -8, -16)]
        [TestCase(-6, 2, -4)]
        public void AddTestTwoParametersAccumulator(double a, double b, double c)
        {
            // Arrange
            calcC.Calculator uut = new calcC.Calculator();

            // Act
            uut.Add(a, b);

            // Assert
            Assert.AreEqual(c, uut.Accumulator);
        }

        [TestCase(2, -2)]
        [TestCase(-2, +2)]
        [TestCase(6, -6)]
        public void SubtractTestOneParameterAccumulator(double a, double b)
        {
            // Arrange
            calcC.Calculator uut = new calcC.Calculator();

            // Act
            uut.Subtract(a);

            // Assert
            Assert.AreEqual(b, uut.Accumulator);
        }

        [TestCase(2, 2, 0)]
        [TestCase(-2, -8, 6)]
        [TestCase(6, 8, -2)]
        public void SubtractTestTwoParametersAccumulator(double a, double b, double c)
        {
            // Arrange
            calcC.Calculator uut = new calcC.Calculator();

            // Act
            uut.Subtract(a, b);

            // Assert
            Assert.AreEqual(c, uut.Accumulator);
        }

        [TestCase(-2, 3, -8)]
        [TestCase(5, -3, 0.008)]
        [TestCase(-5, 3.5, double.NaN)]
        public void PowerTestOneParameterAccumulator(double a, double b, double c)
        {
            // Arrange
            calcC.Calculator uut = new calcC.Calculator();
            uut.Add(a);

            // Act
            uut.Power(b);

            // Assert
            Assert.AreEqual(c, uut.Accumulator);

        }
        [TestCase(-2, 3, -8)]
        [TestCase(5, -3, 0.008)]
        [TestCase(-5, 3.5, double.NaN)]
        public void PowerTestTwoParametersAccumulator(double a, double b, double c)
        {
            // Arrange
            calcC.Calculator uut = new calcC.Calculator();

            // Act
            uut.Power(a, b);

            // Assert
            Assert.AreEqual(c, uut.Accumulator);
        }

        [TestCase(2, 2, 4)]
        [TestCase(-4, -4, 16)]
        [TestCase(0, -8, 0)]
        public void MultiplyTestOneParameterAccumulator(double a, double b, double c)
        {
            // Arrange
            calcC.Calculator uut = new calcC.Calculator();
            uut.Add(a);

            // Act
            uut.Multiply(b);

            // Assert
            Assert.AreEqual(c, uut.Accumulator);
        }


        [TestCase(2, 2, 4)]
        [TestCase(-4, -4, 16)]
        [TestCase(0, -8, 0)]
        public void MultiplyTestTwoParametersAccumulator(double a, double b, double c)
        {
            // Arrange
            calcC.Calculator uut = new calcC.Calculator();

            // Act
            uut.Multiply(a, b);

            // Assert
            Assert.AreEqual(c, uut.Accumulator);
        }

        [TestCase(500.47, 67, 500.47 / 67)]
        [TestCase(24, 64, 0.375)]
        [TestCase(8, 4, 2)]
        public void DivideTestOneParameterAccumulator(double a, double b, double c)
        {
            // Arrange
            calcC.Calculator uut = new calcC.Calculator();
            uut.Add(a);

            // Act
            uut.Divide(b);

            // Assert
            Assert.AreEqual(c, uut.Accumulator);
        }

        [TestCase(52.5, 7.5, 7)]
        [TestCase(24, 64, 0.375)]
        [TestCase(8, 4, 2)]

        public void DivideTestTwoParametersAccumulator(double a, double b, double c)
        {
            // Arrange
            calcC.Calculator uut = new calcC.Calculator();

            // Act
            uut.Divide(a, b);

            // Assert
            Assert.AreEqual(c, uut.Accumulator);
        }

        [TestCase(7, 8, 0)]
        [TestCase(7, 88, 0)]
        [TestCase(1992, 1993, 0)]
        public void ClearTest(double a, double b, double c)
        {
            // Arrange
            calcC.Calculator uut = new calcC.Calculator();
            uut.Add(a, b);

            // Act
            uut.Clear();

            // Assert
            Assert.AreEqual(c, uut.Accumulator);
        }
    }
}