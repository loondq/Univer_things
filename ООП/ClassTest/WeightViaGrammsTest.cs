using OOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTests
{
    public class WeightViaGrammsTest
    {
        [TestCase(1000, ExpectedResult = "1000")]
        public string WeightInGrammsViaGrammsTest(int gramms)
        {
            WeightViaGramms wg = new(gramms);
            return wg.Gramms.ToString();
        }

        [TestCase(1000, ExpectedResult = "2,2")]
        public string WeightInPoundsViaGrammsTest(int gramms)
        {
            WeightViaGramms wg = new(gramms);
            return wg.Pounds.ToString();
        }

        [TestCase(1000, ExpectedResult = "35,27")]
        public string WeightInOunceViaGrammsTest(int gramms)
        {
            WeightViaGramms wg = new(gramms);
            return wg.Ounce.ToString();
        }
        
        [TestCase(1000, 1000, ExpectedResult = "2000")]
        public string SumOfGrammsTest(int gramms1, int gramms2)
        {
            WeightViaGramms wg1 = new(gramms1);
            WeightViaGramms wg2 = new(gramms2);
            return (wg1 + wg2).ToString();
        }

        [TestCase(1000, 1000, ExpectedResult = "0")]
        public string SubstractionOfGrammsTest(int gramms1, int gramms2)
        {
            WeightViaGramms wg1 = new(gramms1);
            WeightViaGramms wg2 = new(gramms2);
            return (wg1 - wg2).ToString();
        }

        [TestCase(10, 20)]
        public void SubstractionExceptionOfGrammsTest(int gramms1, int gramms2)
        {
            WeightViaGramms wg1 = new(gramms1);
            WeightViaGramms wg2 = new(gramms2);
            Assert.Throws<Exception>(() => (wg1 - wg2).ToString());
        }

        [Test]
        public void NotCorrectInputTest()
        {
            Assert.Throws<Exception>(NotCorrectInput);
        }

        private void NotCorrectInput()
        {
            WeightViaGramms wg = new(-10);
        }
    }
}
