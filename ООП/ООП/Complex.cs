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
        private Complex(int re, int im, int ad)
        {
            realPart = re;
            imaginaryPart = im;
            addition = ad;
        }
        public int RealPart
        {
            get { return realPart; }
            set { realPart = value; }
        }
        public int ImaginaryPart
        {
            get { return imaginaryPart; }
            set { imaginaryPart = value; }
        }
        public int? Addition
        {
            get { return addition; }
            set { addition = value; } 
        }
        public double GetMod() { return Math.Sqrt(realPart * realPart + imaginaryPart * imaginaryPart); }
        public double GetArg()
        {
            if (realPart < 0)
            {
                if (imaginaryPart >= 0) return Math.PI + Math.Atan(imaginaryPart / realPart);
                if (imaginaryPart < 0) return -Math.PI + Math.Atan(imaginaryPart / realPart);
            }
            if (realPart == 0)
            {
                if (imaginaryPart > 0) return Math.PI / 2;
                if (imaginaryPart < 0) return -Math.PI / 2;
            }
            return Math.Atan(imaginaryPart / realPart);
        }
        public static Complex operator + (Complex c1, Complex c2)
        {
            var re = c1.realPart + c2.realPart;
            var im = c1.imaginaryPart + c2.imaginaryPart;
            return new Complex(re, im);
        }
        public static Complex operator - (Complex c1, Complex c2)
        {
            var re = c1.realPart - c2.RealPart;
            var im = c1.imaginaryPart - c2.imaginaryPart;
            return new Complex(re, im);
        }
        public static Complex operator * (Complex c1, Complex c2)
        {
            var re = c1.realPart * c2.realPart - c1.imaginaryPart * c2.imaginaryPart;
            var im = c1.realPart * c2.imaginaryPart + c1.imaginaryPart * c2.realPart;
            return new Complex(re, im);
        }
        public static Complex operator / (Complex c1, Complex c2)
        {
            int addition;
            var re = c1.realPart * c2.realPart + c1.imaginaryPart * c2.imaginaryPart;
            var im = c1.imaginaryPart * c2.realPart - c1.realPart * c2.imaginaryPart;
            addition = c2.realPart * c2.realPart + c2.imaginaryPart * c2.imaginaryPart;
            if (c1.imaginaryPart == c2.imaginaryPart && c1.realPart == c2.realPart)
            {
                addition = 1;
            }
            return new Complex(re, im, addition);
        }
        public override string ToString()
        {
            if (addition == 1) return "1";
            if (realPart == 0)
            {
                if (imaginaryPart == 1) return "i";
                return $"{imaginaryPart}i";
            }
            if (imaginaryPart == 0) return $"{realPart}";
            if (imaginaryPart == 1) return $"{realPart} + i";
            if (addition != null)
            {
                if (imaginaryPart < 0) return $"({realPart} - {-imaginaryPart}i) / {addition}";
                return $"({realPart} + {imaginaryPart}i) / {addition}";
            }
            if (imaginaryPart < 0) return $"{realPart} - {-imaginaryPart}i";
            return $"{realPart} + {imaginaryPart}i";
        }
    }
}
