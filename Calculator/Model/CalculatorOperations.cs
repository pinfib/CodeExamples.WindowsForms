using System;
using System.Collections.Generic;

namespace Calculator.Model
{
    internal static class CalculatorOperations
    {
        internal static Dictionary<string, Func<double, double, double>> GetBinaryOperations()
        {
            return new Dictionary<string, Func<double, double, double>>()
            {
                ["+"] = (x, y) => x + y,
                ["-"] = (x, y) => x - y,
                ["*"] = (x, y) => x * y,
                ["/"] = (x, y) => x / y,
                ["x^y"] = (x, y) => Math.Pow(x, y)
            };
        }

        internal static Dictionary<string, Func<double, double>> GetUnaryOperations()
        {
            return new Dictionary<string, Func<double, double>>()
            {
                ["-/+"] = (x) => -x,
                ["x^2"] = (x) => Math.Pow(x, 2),
                ["\u221Ax"] = (x) => Math.Sqrt(x),
                ["|x|"] = (x) => Math.Abs(x)
            };
        }
    }
}