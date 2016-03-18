// demo of enumerations - enums are value types

using System;

// RGB colors
public enum Color				                    // underlying type is int
{
    Red, Green, Blue                                // 0, 1, 2
}

// days of the week
public enum Day : short                             // use short rather than int under the hood
{
    Monday = 1, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday         // 1, 2, 3, 4, 5, 6, 7
}

class Test
{
    public static void Main()
    {
        Color c1 = Color.Red;
        Color c2 = c1;                          // enums are alue types, this is a copy
        c2 = Color.Green;
        Console.WriteLine(c1);                  // still Red
        Console.WriteLine(c2);                  // Green
        Console.WriteLine((int)Color.Blue);     // 2

        Day d1 = Day.Wednesday;
        short dayNo = (short)d1;                 // 3
        Console.WriteLine("Day " + dayNo);
        dayNo++;
        d1 = (Day)dayNo;                        // Thursday is day 4
        Console.WriteLine(d1);
    }
}