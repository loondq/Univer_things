using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Complex
    {
        private int imaginaryPart;
        private int realPart;
        private int? addition = null;

        public Complex(int re, int im)
        {
            imaginaryPart = im;
            realPart = re;
        }
        public int GetMod() { return imaginaryPart; }
        public int GetArg() { return realPart; }
        public void Sum(Complex c)
        {
            realPart += c.realPart;
            imaginaryPart += c.imaginaryPart;
        }
        public void Substraction(Complex c)
        {
            realPart -= c.realPart;
            imaginaryPart -= c.imaginaryPart;
        }
        public void Multiplication(Complex c)
        {
            int re = realPart;
            realPart = re * c.realPart - imaginaryPart * c.imaginaryPart;
            imaginaryPart = re * c.imaginaryPart + imaginaryPart * c.realPart;
        }
        public void Division(Complex c)
        {
            if (imaginaryPart == c.imaginaryPart && realPart == c.realPart)
            {
                addition = 1;
                return;
            }
            int re = realPart;
            realPart = (re * c.realPart + imaginaryPart * c.imaginaryPart);
            imaginaryPart = (imaginaryPart * c.realPart - re * c.imaginaryPart);
            addition = c.realPart * c.realPart + c.imaginaryPart * c.imaginaryPart;
        }
        public override string ToString()
        {
            if (addition == 1) return "1";
            if (imaginaryPart == 0) return $"{realPart}";
            if (imaginaryPart == 1) return $"{realPart} + i";
            if (realPart == 0) return $"{imaginaryPart}i";
            if (addition != null)
            {
                if (imaginaryPart < 0) return $"{realPart} - {-imaginaryPart}i / {addition}";
                return $"{realPart} + {imaginaryPart}i / {addition}";
            }
            if (imaginaryPart < 0) return $"{realPart} - {-imaginaryPart}i";
            return $"{realPart} + {imaginaryPart}i";
        }
    }
}
