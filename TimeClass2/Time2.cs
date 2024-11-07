using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Time2
{
    private int hour;
    private int minute;
    private int second;

   public Time2(int hour = 0, int minute = 0, int second = 0)
    {
        SetTime(hour, minute, second);
    }
    public Time2(Time2 time)
        : this(time.Hour, time.Minute, time.Second) { }

    public void SetTime(int hour,int minute, int second)
    {
        Hour = hour;
        Minute = minute;
        Second = second;
    }
    public int Hour
    {
        get
        {
            return hour;
        }
        set
        {
            if (value < 0 || value > 23)
            {
                throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Hour)}must be 0-23");

            }
            hour = value;
        }
    }
    public int Minute
    {
        get
        {
            return minute;
        }
        set
        {
            if (value < 0 || value > 59)
            {
                throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Minute)}must be 0-59");

            }
            minute = value;
        }
    }
       public int Second
    {
        get
        {
            return second;
        }
        set
        {
            if (value < 0 || value > 23)
            {
                throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Second)}must be 0-59");

            }
            second = value;
        }
    }

    public string ToUniversalString() =>
         $"{Hour.ToString("D2")}: {Minute.ToString("D2")}: {Second.ToString("D2")}";
}