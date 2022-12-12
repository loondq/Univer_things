using OOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTests
{
    public class WeightViaPoundsTest
    {
        [TestCase(5, ExpectedResult = "2267,96")]
        public string WeightInGrammsViaPoundsTest(int pounds)
        {
            WeightViaPounds wp = new(pounds);
            return wp.Gramms.ToString();
        }

        [TestCase(5, ExpectedResult = "5")]
        public string WeightInPoundsViaPoundsTest(int pounds)
        {
            WeightViaPounds wp = new(pounds);
            return wp.Pounds.ToString();
        }

        [TestCase(5, ExpectedResult = "80")]
        public string WeightInOunceViaPoundsTest(int pounds)
        {
            WeightViaPounds wp = new(pounds);
            return wp.Ounce.ToString();
        }

        [TestCase(10, 20, ExpectedResult = "30")]
        public string SumOfPoundsTest(int pounds1, int pounds2)
        {
            WeightViaPounds wp1 = new(pounds1);
            WeightViaPounds wp2 = new(pounds2);
            return (wp1 + wp2).ToString();
        }

        [TestCase(10, 20, ExpectedResult = "10")]
        public string SubstractionOfPoundsTest(int pounds1, int pounds2)
        {
            WeightViaPounds wp1 = new(pounds1);
            WeightViaPounds wp2 = new(pounds2);
            return (wp2 - wp1).ToString();
        }

        [Test]
        public void NotCorrectSubstraction()
        {
            Assert.Throws<Exception>(SubstractionExceptionOfPounds);
        }

        public void SubstractionExceptionOfPounds()
        {
            WeightViaGramms wp1 = new(10);
            WeightViaGramms wp2 = new(20);
            var sub = (wp1 - wp2);
        }

        [Test]
        public void NotCorrectInputTest()
        {
            Assert.Throws<Exception>(NotCorrectInput);
        }

        private void NotCorrectInput()
        {
            WeightViaPounds wp = new(-10);
        }
    }
}
