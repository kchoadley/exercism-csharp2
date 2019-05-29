using System;

public static class Leap
{
    public static bool IsLeapYear(int year) =>
        year.IsDivisibleBy(4) && (!year.IsDivisibleBy(100) || year.IsDivisibleBy(400));
    private static bool IsDivisibleBy(this int number, int divisor) => number % divisor == 0;

}