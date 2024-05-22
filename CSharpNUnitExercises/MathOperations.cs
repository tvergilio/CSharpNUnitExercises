using System.Numerics;
using MathNet.Numerics.LinearAlgebra;

namespace CSharpNUnitExercises
{
    public class MathOperations
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Modulus(int a, int b)
        {
            return a % b;
        }

        public double Power(double a, double b)
        {
            return Math.Pow(a, b);
        }

        public Complex AddComplex(Complex a, Complex b)
        {
            return a + b;
        }

        public Complex MultiplyComplex(Complex a, Complex b)
        {
            return a * b;
        }

        public double[,] MultiplyMatrices(double[,] a, double[,] b)
        {
           var matrix1 = Matrix<double>.Build.DenseOfArray(a);
           var matrix2 = Matrix<double>.Build.DenseOfArray(b);
           return matrix1.Multiply(matrix2).ToArray();
        }

        public int GenerateSecureRandomNumber(int minValue, int maxValue)
        {
            return new Random().Next(minValue, maxValue + 1);
        }
    }
}