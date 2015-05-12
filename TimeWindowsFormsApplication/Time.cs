using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeWindowsFormsApplication
{
    class Time
    {
        protected int hour;
        protected int minute;
        protected int second;
        public void SetTime(int _hour, int _minute, int _second)
        {
            hour = _hour;
            minute = _minute;
            second = _second;
        }
        public int GetHour()
        {
            return hour;
        }
        public int GetMinute()
        {
            return minute;
        }
        public int GetSecond()
        {
            return second;
        }

        public void AddSecond(ref int _hour, ref int _minute, ref int _second)
        {
            
            second = _second + 1;
            if (second == 60)
            {
                second = 0;
                minute = _minute + 1;
            }
            if (minute == 60)
            {
                minute = 0;
                hour = _hour + 1;
            }
            SetTime(hour,minute,second);
            _hour = hour;
            _minute = minute;
            _second = second;
        }

    }
}
