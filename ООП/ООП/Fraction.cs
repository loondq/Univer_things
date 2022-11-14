using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Fraction
    {
        private double numerator;
        private double denominator;

        public void SetNum(int a)
        {
            numerator = a;
        }
        public void SetDenom(int b)
        {
            if (b == 0)
                throw new ArgumentException("Нельзя делить на ноль");
            denominator = b;
        }
        public double GetNum()
        {
            return numerator;
        }
        public double GetDenum()
        {
            return denominator; 
        }

        public void Print()
        {
            Console.WriteLine($"{numerator/denominator}");
        }
    }
}
