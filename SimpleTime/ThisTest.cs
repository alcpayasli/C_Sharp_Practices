using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ThisTest
{
    static void Main()
    {
        var time = new SimpleTime(15, 30, 19);
        Console.WriteLine(time.BuildString());
    }
}

public class SimpleTime
{
    private int hour;
    private int minute;
    private int second;

    public SimpleTime(int hour, int minute, int second)
    {
        this.hour = hour;
        this.minute = minute;
        this.second = second;
    }

    public string BuildString() =>
        $"{this.ToUniversalString(),24}: {this.ToUniversalString()}" +
        $"\n{ToUniversalString(),24}: {ToUniversalString()}";

    public string ToUniversalString() =>
        $"{this.hour.ToString("D2")}: {this.minute.ToString("D2")}: {this.second.ToString("D2")}";
}