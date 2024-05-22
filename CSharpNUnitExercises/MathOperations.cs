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

        public int GenerateSecureRandomNumber(int minValue, int maxValue)
        {
            return new Random().Next(minValue, maxValue + 1);
        }
        
        public double[,] MultiplyMatrices(double[,] matrix1, double[,] matrix2)
        {
            var m1 = Matrix<double>.Build.DenseOfArray(matrix1);
            var m2 = Matrix<double>.Build.DenseOfArray(matrix2);
            return m1.Multiply(m2).ToArray();
        }
    }
}