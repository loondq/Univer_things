using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Fractions
    {
        private int numerator;
        private int denominator;

        public int Numerator
        {
            get { return numerator; }
            set
            { 
                numerator = value;
            }
        }
        public int Denominator
        {
            get { return denominator; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Нельзя делить на ноль");
                denominator = value;
            }
        }
        
        public Fractions(int numerator, int denominator)
        {
            this.numerator = numerator;
            if (denominator == 0)
                throw new ArgumentException("Нельзя делить на ноль");
            this.denominator = denominator;
            Reduction();
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
            denominator *= f.denominator;
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
            int devider = NOD(numerator, denominator);
            numerator /= devider;
            denominator /= devider;
        }
        public override string ToString()
        {
            if (Denominator == 1) return $"{Numerator}";
            return $"{Numerator}/{Denominator}";
        }
        private int NOD(int number1, int number2)
        {
            int a = Math.Abs(number1);
            int b = Math.Abs(number2);
            if (a == b) return a;
            if (a < b)
                return NOD(a, b - a);
            else return NOD(a - b, b);
        }
        public static Fractions operator + (Fractions f1, Fractions f2)
        {
            var n = f1.numerator * f2.denominator + f1.denominator * f2.numerator;
            var d = f1.denominator * f2.denominator;
            return new Fractions(n, d);
        }
    }
}
