// ref and out paramters

using System;

/*
ref  versus  out?
- ref tells the compiler that the object is initialized before entering the function (value is already set, 
method can read it and can modify it.)
- out tells the compiler that the object will be initialized inside the function (out means that value isn't 
set and method must set it before return and couldn't read before setting value)

So while ref is two-ways, out is out-only
*/

class Geometry
{
    public static void swap1(int x, int y)				        // value, no swap
    {
        int temp = x;
        x = y;
        y = temp;
    }

    public static void swap2(ref int x, ref int y)			    // ref, swap works
    {
        int temp = x;
        x = y;
        y = temp;
    }

    public static void add(int x, int y, out int answer)		// output parameter
    {
        answer = x + y;
    }

}

// test class
class Test
{
    public static void Main()
    {
        int x, y;

        x = 10;
        y = 20;
        Geometry.swap1(x, y);
        Console.WriteLine(x + " " + y);		// 10,20

        x = 10;
        y = 20;
        Geometry.swap2(ref x, ref y);
        Console.WriteLine(x + " " + y);		// 20,10

        int z;  
        x = 10;
        y = 20;
        Geometry.add(x, y, out z);    //notice Z is not initalized to anything, its values will be initialized in the add method and passed out
        Console.WriteLine(z);			    // 30
    }
}