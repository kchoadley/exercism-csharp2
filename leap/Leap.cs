using System;

public static class Leap
{
    public static bool IsLeapYear(int year) =>
        DivisibleBy4(year) ?
            DivisibleBy100(year) ?
                DivisibleBy400(year) ? true : false
                : true
        : false;
    private static bool DivisibleBy4(int year) => year % 4 == 0;
    private static bool DivisibleBy100(int year) => year % 100 == 0;
    private static bool DivisibleBy400(int year) => year % 400 == 0;

}