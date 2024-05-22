using System.Numerics;

namespace CSharpNUnitExercises
{
    public class Numbers
    {
        public decimal CalculateVat(decimal value)
        {
            return Math.Round(value * 0.2m, 2);
        }

        public double HypotenuseLength(double sideA, double sideB)
        {
            return Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));
        }

        public BigInteger Fibonacci(int n)
        {
            if (n <= 0)
            {
                return 0;
            }

            if (n == 1)
            {
                return 1;
            }

            BigInteger a = 0;
            BigInteger b = 1;

            for (var i = 2; i <= n; i++)
            {
                BigInteger temp = a + b;
                a = b;
                b = temp;
            }

            return b;
        }
    }
}