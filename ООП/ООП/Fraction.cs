using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Fractions
    {
        private double numerator;
        private double denominator;
        
        public Fractions(int numerator, int denominator)
        {
            this.numerator = numerator;
            if (denominator == 0)
                throw new ArgumentException("Нельзя делить на ноль");
            this.denominator = denominator;
        }
        public void Sum(Fractions f)
        {
            numerator = numerator * f.denominator + denominator * f.numerator;
            denominator *= f.denominator;
            Reduction();
        }
        public void Substraction(Fractions f)
        {
            numerator = numerator * f.denominator - denominator * f.numerator;
            denominator = denominator * f.denominator;
            Reduction();
        }
        public void Multiplication(Fractions f)
        {
            numerator *= f.numerator;
            denominator *= f.denominator;
            Reduction();
        }
        public void Division(Fractions f)
        {
            numerator *= f.denominator;
            denominator *= f.numerator;
            Reduction();
        }
        public void Reduction()
        {
            double devider = NOD(numerator, denominator);
            numerator /= devider;
            denominator /= devider;
        }
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
            Console.WriteLine($"{numerator}/{denominator}");
        }
        private double NOD(double a, double b)
        {
            if (a == b) return a;
            if (a < b)
                return NOD(a, b - a);
            else return NOD(a - b, b);
        }
    }
}
