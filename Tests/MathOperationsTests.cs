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
        public void GenerateSecureRandomNumber_ReturnsNumberWithinRange()
        {
            int minValue = 1;
            int maxValue = 100;

            int result = mathOperations.GenerateSecureRandomNumber(minValue, maxValue);

            Assert.That(result, Is.GreaterThanOrEqualTo(minValue));
            Assert.That(result, Is.LessThanOrEqualTo(maxValue));
        }

        [Test]
        public void MultiplyMatrices_TwoMatrices_ReturnsProduct()
        {
            double[,] matrix1 = { { 1, 2 }, { 3, 4 } };
            double[,] matrix2 = { { 5, 6 }, { 7, 8 } };
            double[,] expected = { { 19, 22 }, { 43, 50 } };

            Assert.That(mathOperations.MultiplyMatrices(matrix1, matrix2), Is.EqualTo(expected));
        }
       
    }
}
