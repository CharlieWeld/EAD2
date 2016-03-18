// demo of properties
//see  http://msdn.microsoft.com/en-us/library/x9fsa0sw(v=vs.100).aspx   for info on properties

using System;

public class Person                     // : Object
{
    /* -------- private fields  ---------- */
	private string name;		
	private int age;
    private DateTime dob;    			
	
  
	/* -------- 2 public properties  -------- */
	//(1) property name doesn't have to correspond to field name
	public string Name			    // read-write property for name (get and set => read and write)
	{		
		get                         // no params allowed  : get allows me to set the vlaue of private name field
		{
			return name;
		}
		
		set                         // no params allowed
		{
			name = value;		    // implicit parameter called "value"
		}

        // max 1 get block, max 1 set block
	}

	//(2) Set can be used for validartion
    public int Age
    {
	   //The get and set portions of a property are called accessors
        get
        {
            return age;
        }

        set                         // can restrict get or set e.g. private set
        {
            if ( (value >=0) && (value <=110) )
            {
			    age = value;		// implicit parameter called "value"
            }
            else
            {
                throw new ArgumentException("Age must be between 0 and 110");
            }
        }
    }	

    //
    //Note not going to expose the DOB field - keep it private to class
    //
	
	/* --------- 4 Constructors ------------ */
	
	// default constructor
	public Person() : this("", 0)
	{
	}

    // constructor
    public Person(String name) : this(name, 0)
    {
    }

	// constructor
	public Person(string name, int age)
	{
        Name = name;			// set called
		Age = age;              // set called
	}


    // constructor
    public Person(string name, DateTime dob)
    {
        Name = name;			// set called
        this.dob = dob;        //this refers to 'this' instance of the class
                               //If i want to explicitly reference something in this class use this
        Age = DateTime.Now.Year - dob.Year;
    }

	
}

public class Test
{
	static void Main()		// private
	{
		Person p1 = new Person("John Walsh", 21);

        Console.WriteLine(p1.Name);	// get called
        Console.WriteLine(p1.Age);	// get called

        p1.Age++;		            // set called
        Console.WriteLine(p1.Age);	// get called  

        // object initialiser "syntactic sugar":
        Person p2 = new Person{ Name = "Bugs Bunny", Age = 75 };			// default constructor called first, then setters
        Console.WriteLine(p2.Name);

        // object initialiser using non-default constructor first
        Person p3 = new Person("Sponge Bob") { Age = 12 };
        Console.WriteLine(p3.Name + " " + p3.Age);


        // object initialiser using non-default constructor first
        Person p4 = new Person("Kermit Frog", new DateTime(1955,5,5) );
        Console.WriteLine(p4.Name + " " + p3.Age);
    }
}

