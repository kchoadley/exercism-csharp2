using System;

public static class ResistorColor
{
    private static string[] ColorMap =
    {
        "black",
        "brown",
        "red",
        "orange",
        "yellow",
        "green",
        "blue",
        "violet",
        "grey",
        "white"
    };
    public static int ColorCode(string color) => Array.IndexOf(ColorMap, color);

    public static string[] Colors() => ColorMap;
}