// demo of interfaces - part 2

using System;

// 2 interfaces

public interface IDrawable                  
{
    void Draw();					        
}

public interface IHasColor
{
    String Color {get; set;}
}


// Shape has a type and (x, y) coordinates, a color, and can be drawn
class ColoredShape : Object, IHasColor, IDrawable 				    
{
    public String Type { get; set; }		        // shape type e.g cirle, square etc.

    public int XCoord { get; set; }                 // x coordinate in 2D space
    public int YCoord { get; set; }                 // y coordinate in 2D space

    // constructor
    public ColoredShape(String shapeType, int xCoord, int yCoord, String color)
    {
        Type = shapeType;
        XCoord = xCoord;
        YCoord = yCoord;
        Color = color;
    }

    // implement Color property because of IDraw
    public void Draw()
    {
        Console.WriteLine("Drawing a " + Color + " " + Type + " at (" + XCoord + ", " + YCoord + ")");
    }

    // implement Color property because of IHasColor, auto property will suffice for now
    public String Color 
    { 
        get; 
        set; 
    }
}

// test class
class Test
{
    public static void Main()
    {
        // polymorphic reference of interface type
        IDrawable i = new ColoredShape("Cirle", 10, 20, "Red");
        i.Draw();                                               // can't call Color on i   
       
        // polymorphic reference of interface type
        IHasColor c = new ColoredShape("Square", 5, 5, "Blue");
        Console.WriteLine(c.Color);                             // can't call Draw on c

        // multiple polymorphism
    }
}