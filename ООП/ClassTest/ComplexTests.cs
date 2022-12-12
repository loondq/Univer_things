using OOP;

namespace ClassTests
{
    public class ComplexTests
    {
        [TestCase(2, 2, ExpectedResult = "2 + 2i")]
        public string CreateComplex(int re, int im)
        {
            Complex c = new(re, im);
            return c.ToString();
        }

        [TestCase(20, 20, 10, 10, ExpectedResult = "30 + 30i")]

        public string ComplexSumTest(int re1, int im1, int re2, int im2)
        {
            Complex c1 = new(re1, im1);
            Complex c2 = new(re2, im2);
            return (c1 + c2).ToString();
        }

        [TestCase(20, 20, 10, 10, ExpectedResult = "10 + 10i")]

        public string ComplexSubstractionTest(int re1, int im1, int re2, int im2)
        {
            Complex c1 = new(re1, im1);
            Complex c2 = new(re2, im2);
            return (c1 - c2).ToString();
        }

        [TestCase(10, 10, 20, 20, ExpectedResult = "400i")]
        public string ComplexMultiplicationTest(int re1, int im1, int re2, int im2)
        {
            Complex c1 = new(re1, im1);
            Complex c2 = new(re2, im2);
            return (c1 * c2).ToString();
        }

        [TestCase(20, 20, 20, 20, ExpectedResult = "1")]
        public string ComplexDivisionTest(int re1, int im1, int re2, int im2)
        {
            Complex c1 = new(re1, im1);
            Complex c2 = new(re2, im2);
            return (c1 / c2).ToString();
        }

        [TestCase(6, 8, ExpectedResult = "10")]

        public string ComplexModTest(int re, int im)
        {
            Complex c1 = new(re, im);
            return c1.GetMod().ToString();
        }
    }
}
