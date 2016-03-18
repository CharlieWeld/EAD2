// demo of interfaces - part 1

using System;

/*
An interface is similar to a class, but it provides a specification rather than an implementation for its members. 

Think of a interface as a contract. IT specifies what implmenting class will do, (i.e it sepcifies the contract that classes promise to implement)

An interface declaration is like a class declaration, but it provides no implementation for its members, as all its members are implicitly abstract.

Interface members are all implicitly abstract. In contrast, a class can provide both abstract members and concrete members with implementations.
Structs can implement interfaces. In contrast, a struct cannot inherit from a class.



The interface members will be implemented by the classes and structs that implement the interface. An interface can contain only methods, properties, events, and indexers, which noncoincidentally are precisely the members of a class that can be abstract.

*/


public interface IDrawable                          // interface names usually contain verbs
{
    void Draw();					                // implicitly public and abstract method
													// note interface can't contain any implementation
}


// Shape has a type and (x, y) coordinates and can be drawn
class Shape : IDrawable 				            // implements an interface, but inherits from Object
{
    public String Type { get; set; }		        // shape type e.g cirle, square etc.

    public int XCoord { get; set; }                 // x coordinate in 2D space
    public int YCoord { get; set; }                 // y coordinate in 2D space

    // constructor
    public Shape(String shapeType, int xCoord, int yCoord)
    {
        Type = shapeType;
        XCoord = xCoord;
        YCoord = yCoord;
    }

    public void Draw()   						//NB: shape Has to implement ALL methods in IDrawable
    {
        Console.WriteLine("Drawing a " + Type + " at (" + XCoord + ", " + YCoord + ")");
    }
}

// test class
class Test
{
    public static void Main()
    {
        Shape s = new Shape("Cirle", 10, 20);
        s.Draw();
    }
}