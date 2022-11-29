using OOP;

namespace ClassTests
{
    public class TimeTests
    {

        [TestCase(34, 72, 72, ExpectedResult = "11:13:12")]
        public string TimeTransformerTime(int hours, int minutes, int seconds)
        {
            Time t = new(hours, minutes, seconds);
            return t.ToString();
        }

        [TestCase(745, ExpectedResult = "00:12:25")]
        public string TimeFromSecondsTest(int seconds)
        {
            return new Time(seconds).ToString();
        }

        [TestCase(23, 453, ExpectedResult = "06:33:00")]
        public string TimeFromHoursAndMinutesTest(int hours, int minutes)
        {
            return new Time(hours, minutes).ToString();
        }

        [TestCase(10, 50, 30, 15, 9, 89, ExpectedResult = "02:00:59")]
        public string TimeSumTest(int hours1, int minutes1, int seconds1, int hours2, int minutes2, int seconds2)
        {
            Time t1 = new(hours1, minutes1, seconds1);
            Time t2 = new(hours2, minutes2, seconds2);
            return (t2 + t1).ToString();
        }

        [TestCase(10, 50, 30, 15, 9, 89, ExpectedResult = "04:19:59")]
        public string TimeSubstractionTest(int hours1, int minutes1, int seconds1, int hours2, int minutes2, int seconds2)
        {
            Time t1 = new(hours1, minutes1, seconds1);
            Time t2 = new(hours2, minutes2, seconds2);
            return (t2 - t1).ToString();
        }

        [TestCase(10, 50, 30, 15, 9, 89)]
        public void TimeSubstractionExceptionTest(int hours1, int minutes1, int seconds1, int hours2, int minutes2, int seconds2)
        {
            Time t1 = new(hours1, minutes1, seconds1);
            Time t2 = new(hours2, minutes2, seconds2);
            Assert.Throws<Exception>(() => (t1 - t2).ToString());
        }

        [TestCase(10, 50, 30, 5, ExpectedResult = "06:12:30")]
        public string TimeMultiplicationTest(int hours, int minutes, int seconds, int number)
        {
            Time t1 = new(hours, minutes, seconds);
            int numb = number;
            return (t1 * numb).ToString();
        }

        [TestCase(10, 50, 30, 5, ExpectedResult = "02:10:06")]
        public string TimeDivisionTest(int hours, int minutes, int seconds, int number)
        {
            Time t1 = new(hours, minutes, seconds);
            int numb = number;
            return (t1 / numb).ToString();
        }
    }
}