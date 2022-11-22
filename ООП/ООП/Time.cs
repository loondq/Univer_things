using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Time
    {
        int hours;
        int minutes;
        int seconds;

        public int Hours
        {
            get { return hours; }
            set { hours = value; }
        }
        public int Minutes
        {
            get { return minutes; }
            set { minutes = value; }
        }
        public int Seconds
        {
            get { return seconds; }
            set { seconds = value; }
        }
        public Time(int hours, int minutes, int seconds)
        {
            this.hours = hours;
            this.minutes = minutes;
            this.seconds = seconds;
            TimeReduser();
            IsCorrectTime();
        }
        public Time(int hours, int minutes)
        {
            seconds = 0;
            this.minutes = minutes;
            this.hours = hours;
            TimeReduser();
            IsCorrectTime();
        }
        public Time(int seconds)
        {
            this.seconds = seconds;
            TimeReduser();
            IsCorrectTime();
        }
        public Time()
        {
            hours = 0;
            minutes = 0;
            seconds = 0;
        }
        public static int InSeconds(int hours, int minutes, int seconds)
        {
            return (hours * 3600) + (minutes * 60) + seconds;
        }
        public static Time operator + (Time t1, Time t2)
        {
            var hours = t1.Hours + t2.Hours;
            var minutes = t1.Minutes + t2.Minutes;
            var seconds = t1.Seconds + t2.Seconds;
            return new Time(hours, minutes, seconds);
        }
        public static Time operator - (Time t1, Time t2)
        {
            var seconds = t1.Seconds - t2.Seconds;
            var minutes = t1.Minutes - t2.Minutes;
            var hours = t1.Hours - t2.Hours;
            if (seconds < 0)
            {
                minutes--;
                seconds += 60;
            }
            if (minutes < 0)
            {
                hours--;
                minutes += 60;
            }
            return new Time(hours, minutes, seconds);
        }   
        public static Time operator * (Time t1, int number)
        {
            return new Time(t1.Hours * number, t1.Minutes * number, t1.Seconds * number);
        }
        public static Time operator / (Time t1, int number)
        {
            return new Time(t1.Hours / number, t1.Minutes / number, t1.Seconds / number);
        }
        private void TimeReduser()
        {
            if (Seconds > 59)
            {
                Minutes += Seconds / 60;
                Seconds %= 60;
            }
            if (Minutes > 59)
            {
                Hours += Minutes / 60;
                Minutes %= 60;
            }
            if (Hours > 23)
                Hours %= 24;
        }   
        private void IsCorrectTime()
        {
            if (Hours < 0 || Minutes < 0 || Seconds < 0)
                throw new Exception("Время не может быть отрицательным, проверяйте ввод!");
        }
        public override string ToString()
        {
            StringBuilder hoursStr = new(hours.ToString());
            StringBuilder minutesStr = new(minutes.ToString());
            StringBuilder secondsStr = new(seconds.ToString());

            if (hoursStr.Length != 2) hoursStr.Insert(0, "0");
            if (minutesStr.Length != 2) minutesStr.Insert(0, "0");
            if (secondsStr.Length != 2) secondsStr.Insert(0, "0");

            return $"{hoursStr}:{minutesStr}:{secondsStr}";
        }
    }
}
