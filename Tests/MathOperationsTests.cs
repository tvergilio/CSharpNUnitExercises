using CSharpNUnitExercises;

namespace Tests
{
    public class MathOperationsTests
    {
        private MathOperations mathOperations;

        [SetUp]
        public void Setup()
        {
            mathOperations = new MathOperations();
        }

        [Test]
        public void Add_TwoNumbers_ReturnsSum()
        {
            Assert.Multiple(() =>
            {
                Assert.That(mathOperations.Add(2, 3), Is.EqualTo(5));
                Assert.That(mathOperations.Add(-1, -1), Is.EqualTo(-2));
                Assert.That(mathOperations.Add(0, 0), Is.EqualTo(0));
            });
        }

        [Test]
        public void Subtract_TwoNumbers_ReturnsDifference()
        {
            Assert.Multiple(() =>
            {
                Assert.That(mathOperations.Subtract(5, 3), Is.EqualTo(2));
                Assert.That(mathOperations.Subtract(-1, -1), Is.EqualTo(0));
                Assert.That(mathOperations.Subtract(0, 0), Is.EqualTo(0));
            });
        }

        [Test]
        public void Multiply_TwoNumbers_ReturnsProduct()
        {
            Assert.Multiple(() =>
            {
                Assert.That(mathOperations.Multiply(2, 3), Is.EqualTo(6));
                Assert.That(mathOperations.Multiply(-1, -1), Is.EqualTo(1));
                Assert.That(mathOperations.Multiply(0, 5), Is.EqualTo(0));
            });
        }

        [Test]
        public void Divide_TwoNumbers_ReturnsQuotient()
        {
            Assert.Multiple(() =>
            {
                Assert.That(mathOperations.Divide(6, 3), Is.EqualTo(2));
                Assert.That(mathOperations.Divide(-6, -2), Is.EqualTo(3));
                Assert.That(mathOperations.Divide(5, 2), Is.EqualTo(2.5));
            });
        }

        [Test]
        public void Modulus_TwoNumbers_ReturnsRemainder()
        {
            Assert.Multiple(() =>
            {
                Assert.That(mathOperations.Modulus(5, 3), Is.EqualTo(2));
                Assert.That(mathOperations.Modulus(10, 5), Is.EqualTo(0));
                Assert.That(mathOperations.Modulus(-7, 3), Is.EqualTo(-1));
            });
        }

        [Test]
        public void SquareRoot_Number_ReturnsSquareRoot()
        {
            Assert.Multiple(() =>
            {
                Assert.That(mathOperations.SquareRoot(9), Is.EqualTo(3));
                Assert.That(mathOperations.SquareRoot(0), Is.EqualTo(0));
                Assert.That(mathOperations.SquareRoot(16), Is.EqualTo(4));
            });
        }

        [Test]
        public void Power_NumberAndExponent_ReturnsPower()
        {
            Assert.Multiple(() =>
            {
                Assert.That(mathOperations.Power(2, 3), Is.EqualTo(8));
                Assert.That(mathOperations.Power(5, 0), Is.EqualTo(1));
                Assert.That(mathOperations.Power(2, -2), Is.EqualTo(0.25));
            });
        }

        [Test]
        public void Sin_AngleInRadians_ReturnsSine()
        {
            Assert.Multiple(() =>
            {
                Assert.That(mathOperations.Sin(0), Is.EqualTo(0));
                Assert.That(mathOperations.Sin(Math.PI / 2), Is.EqualTo(1));
                Assert.That(mathOperations.Sin(Math.PI), Is.EqualTo(0).Within(0.0001));
            });
        }

        [Test]
        public void Cos_AngleInRadians_ReturnsCosine()
        {
            Assert.Multiple(() =>
            {
                Assert.That(mathOperations.Cos(0), Is.EqualTo(1));
                Assert.That(mathOperations.Cos(Math.PI / 2), Is.EqualTo(0).Within(0.0001));
                Assert.That(mathOperations.Cos(Math.PI), Is.EqualTo(-1));
            });
        }

        [Test]
        public void Log_Number_ReturnsLogarithm()
        {
            Assert.Multiple(() =>
            {
                Assert.That(mathOperations.Log(1), Is.EqualTo(0));
                Assert.That(mathOperations.Log(Math.E), Is.EqualTo(1).Within(0.0001));
                Assert.That(mathOperations.Log(100), Is.EqualTo(4.605).Within(0.001));
            });
        }

        [Test]
        public void Exp_Number_ReturnsExponent()
        {
            Assert.Multiple(() =>
            {
                Assert.That(mathOperations.Exp(0), Is.EqualTo(1));
                Assert.That(mathOperations.Exp(1), Is.EqualTo(Math.E).Within(0.0001));
                Assert.That(mathOperations.Exp(2), Is.EqualTo(Math.E * Math.E).Within(0.0001));
            });
        }
    }
}
