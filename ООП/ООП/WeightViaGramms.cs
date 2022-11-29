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

        public double Gramms { get { return Math.Round(_gramms, 2); }}
        public double Pounds
        {
            get { return Math.Round(_gramms / 453.59237, 2); }
        }
        public double Ounce
        {
            get { return Math.Round(_gramms / 28.349523125, 2); }
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
            if (_gramms == 0)
                return "0";
            return _gramms.ToString("#.##");
        }
        private void IsCorrectInput()
        {
            if (_gramms < 0)
                throw new Exception("Масса не может быть отрицательной, проверяйте ввод!");
        }
    }
}
