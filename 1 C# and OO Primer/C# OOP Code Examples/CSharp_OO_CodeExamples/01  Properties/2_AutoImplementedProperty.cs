//-====================================
// DEMO OF AUTOMATIC PROPERTIES
//======================================

using System;

public class Person
{
    // ---auto-implemented properties = PROPERTIES THAT ARE AUTOMATICALLY IMPLEMENTATED BNY THE COMPILER
    // no explicit fields defined,  the compiler creates a private, anonymous backing field that can only 
	//be accessed through the property's get and set accessors.

    // auto-implemented property, must be read-write
    public string Name
    {
        get; 				// default get generated by compiler using backing field _name, must be get; no body allowed
        set;				// default set generated by compiler using backing field _name, must be set; no body allowed
    }

    public int Age			// could be virtual, and overriden in subclass, must be read-write
    {
        get;
        set;
    }

    // use if no significant behaviour required from properties i.e. where they just encapsulate fields
    // and in future they may have specific behaviours defined

    // default constructor
    public Person()
    {
    }

    public override String ToString()
    {
        return this.Name + " " + this.Age; 		// gets
    }
    
    // an abstract class can contain abstract properties

}

public class Test
{
    static void Main()
    {
        // example of an object initialiser
        Person p1 = new Person { Name = "John Walsh", Age = 21 };			// default constructor called first, then setters

        Console.Write(p1.Name + " ");	// get
        Console.WriteLine(p1.Age);	// get

        p1.Age++;
        Console.WriteLine(p1.ToString());
    }
}