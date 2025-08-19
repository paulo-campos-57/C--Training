using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C__Training.Models
{
    public class Calculator
    {

        // Regular Calculator
        public double Add(double v1, double v2)
        {
            return v1 + v2;
        }

        public double Subtract(double v1, double v2)
        {
            return v1 - v2;
        }

        public double Multiply(double v1, double v2)
        {
            return v1 * v2;
        }

        public double Divide(double v1, double v2)
        {
            if (v2 > 0)
            {
                return v1 / v2;
            }
            else
            {
                return double.MaxValue;
            }
        }

        public double Power(double v1, double v2)
        {
            return Math.Pow(v1, v2);
        }

        public double SqrRoot(double v1)
        {
            return Math.Sqrt(v1);
        }

        // Angle Calculator
        public double Sine(double angle)
        {
            double radian = angle * Math.PI / 180;
            return Math.Sin(radian);
        }

        public double Cosine(double angle)
        {
            double radian = angle * Math.PI / 180;
            return Math.Cos(radian);
        }

        public double Tangent(double angle)
        {
            double radian = angle * Math.PI / 180;
            return Math.Tan(radian);
        }
    }
}