using NUnit.Framework;

namespace Calculator.Test.Unit
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddTest()
        {
            // Arrange
            calcC.Calculator uut = new calcC.Calculator();

            // Act
            double uu = uut.Add(2, 2);

            // Assert
            Assert.AreEqual(4, uu);
        }

        [Test]
        public void SubtractTest()
        {
            // Arrange
            calcC.Calculator uut = new calcC.Calculator();

            // Act
            double uu = uut.Subtract(2, 2);

            // Assert
            Assert.That(uu, Is.EqualTo(0));
        }

        [Test]
        public void PowerTest()
        {
            // Arrange
            calcC.Calculator uut = new calcC.Calculator();

            // Act
            double uu = uut.Power(2, 2);

            // Assert
            Assert.AreEqual(4, uu);
        }

        [TestCase(2, 2, 4)]
        [TestCase(4, 4, 16)]
        [TestCase(6, 8, 48)]
        public void MultiplyTest(double a, double b, double c)
        {
            // Arrange
            calcC.Calculator uut = new calcC.Calculator();

            // Act
            double uu = uut.Multiply(a, b);

            // Assert
            Assert.That(uu, Is.EqualTo(c));
        }


        [TestCase(12, 3, ExpectedResult = 15)]
        public double AddTest2(double a, double b)
        {
            // Arrange
            calcC.Calculator uut = new calcC.Calculator();

            // Act & Assert
            return uut.Add(a, b);
        }
    }
}