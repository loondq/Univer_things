using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class WeightViaGramms
    {
        private readonly double _gramms;

        public double Gramms { get { return _gramms; }}
        public double Pounds
        {
            get { return _gramms / 453.59237; }
            set { Pounds = value; }
        }
        public double Ounce
        {
            get { return _gramms / 28.349523125; }
            set { Ounce = value; }
        }
        public WeightViaGramms(double gramms)
        {
            _gramms = gramms;
            IsCorrectInput();
        }
        public WeightViaGramms(double pounds, double gramms)
        {
            _gramms = gramms + pounds * 453.59237;
            IsCorrectInput();
        }
        public static WeightViaGramms operator + (WeightViaGramms wg1, WeightViaGramms wg2)
        {
            var gramms = wg1.Gramms + wg2.Gramms;
            return new WeightViaGramms(gramms);
        }
        public static WeightViaGramms operator - (WeightViaGramms wg1, WeightViaGramms wg2)
        {
            var gramms = wg1.Gramms - wg2.Gramms;
            return new WeightViaGramms(gramms);
        }
        public override string ToString()
        {
            return Gramms.ToString();
        }
        private void IsCorrectInput()
        {
            if (_gramms < 0)
                throw new Exception("Масса не может быть отрицательной, проверяйте ввод!");
        }
    }
}
