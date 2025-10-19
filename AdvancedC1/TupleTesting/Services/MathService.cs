using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TupleTesting.Services
{
    public class MathService
    {
        public (int Sum, int Product) SumAndProduct(int a, int b)
        {
            return (a + b, a * b);
        }

        public (int Min, int Max, double Average) Analyze(params int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                throw new ArgumentException("numbers cannot be null or empty");

            int min = numbers.Min();
            int max = numbers.Max();
            double avg = numbers.Average();
            return (min, max, avg);
        }
    }
}
