using System;

namespace Lab3.Extensions
{
    public static class TimeSpanExtension
    {
        public static string GetCustomTimeFormat(this TimeSpan time)
        {
            return time.ToString("%d") + " days, " + time.ToString(@"hh\:mm\:ss");
        }
    }
}