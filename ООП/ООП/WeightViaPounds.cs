using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class WeightViaPounds
    {
        private readonly double _pounds;

        public double Gramms 
        {
            get { return _pounds * 453.9237; } 
        }
        public double Pounds
        {
            get { return _pounds; }
        }
        public double Ounce
        {
            get { return _pounds * 16; }
        }
        public WeightViaPounds(double pounds)
        {
            _pounds = pounds;
            IsCorrectInput();
        }
        public WeightViaPounds(double pounds, double ounce)
        {
            _pounds = pounds + ounce / 16;
            IsCorrectInput();
        }
        public static WeightViaPounds operator +(WeightViaPounds wp1, WeightViaPounds wp2)
        {
            var pounds = wp1.Pounds + wp2.Pounds;
            return new WeightViaPounds(pounds);
        }
        public static WeightViaPounds operator -(WeightViaPounds wp1, WeightViaPounds wp2)
        {
            var pounds = wp1.Pounds - wp2.Pounds;
            return new WeightViaPounds(pounds);
        }
        public override string ToString()
        {
            return Pounds.ToString();
        }
        private void IsCorrectInput()
        {
            if (_pounds < 0)
                throw new Exception("Масса не может быть отрицательной, проверяйте ввод!");
        }
    }
}
