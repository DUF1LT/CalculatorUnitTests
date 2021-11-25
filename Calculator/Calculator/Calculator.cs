using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        public double Sum(double a, double b)
        {
            return a + b;
        }

        public double Substract(double a, double b)
        {
            return a - b;
        }

        public double Divide(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException($"Argument {nameof(b)} can't be zero!");

            return a / b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Sqrt(double a)
        {
            if (a < 0)
                throw new ArgumentException($"Argument {nameof(a)} can't be less then zero");

            return Math.Sqrt(a);
        }
    }
}
