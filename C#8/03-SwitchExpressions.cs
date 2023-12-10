using System;

namespace CSharp8.Features
{
    public static class SwitchExpressions
    {
        public static double DoMath(double x, double y, MathType math)
        {
            double outPut = 0;

            outPut = math switch // switch expression
            {
                MathType.Add => x + y,
                MathType.Subtract => x - y,
                MathType.Multiply => x * y,
                MathType.Divide => x / y,
                _ => throw new Exception("bad info passed in")
            };

            switch (math) // switch statement
            {
                case MathType.Add:
                    outPut = x + y;
                    break;
                case MathType.Subtract:
                    outPut = x - y;
                    break;
                case MathType.Multiply:
                    outPut = x * y;
                    break;
                case MathType.Divide:
                    outPut = x / y;
                    break;
                default:
                    throw new Exception("bad info passed in");
            }

            return outPut;
        }
    }

    public enum MathType
    {
        Add,
        Subtract,
        Multiply,
        Divide
    }
}
