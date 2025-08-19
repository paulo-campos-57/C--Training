using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C__Training.Models
{
    public class Calculator
    {
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
    }
}