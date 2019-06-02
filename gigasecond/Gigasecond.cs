using System;

public static class Gigasecond
{
    // Timespan is measured in ticks of 100 Nano seconds.
    // Gigasecond (10^9) converted to 100 Nanoseconds (10^-7) is 10^16
    public static DateTime Add(DateTime moment) => moment.Add(new TimeSpan(10_000_000_000_000_000));
}