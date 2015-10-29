using System;

namespace Observer_Clocks
{
    class ClockTimer : Subject
    {
        System.Threading.Timer timer;
        private TimeSpan currentTime;

        static void TimerProc(object o)
        {
            (o as ClockTimer).Tick();
        }

        public ClockTimer()
        {
            timer = new System.Threading.Timer(TimerProc, this, 1000, 1000);
        }

        public void Tick()
        {
            currentTime = DateTime.Now.TimeOfDay;
            Notify();
        }

        public int GetHour()
        {
            return currentTime.Hours;
        }

        public int GetMinute()
        {
            return currentTime.Minutes;
        }

        public int GetSecond()
        {
            return currentTime.Seconds;
        }

        public TimeSpan GetTime()
        {
            return currentTime;
        }
    }
}
