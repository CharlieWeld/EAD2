// demo of inheritance

using System;

namespace Human
{
   
   /* In this example i first define a Person Class.
      I then define a  Musician class which will inherit from the Person class 
	  - The person class will be the super class (or base class)
	  - The musician class will be the derived class. It inherits all the functionality of the 
	    person class => a musician 'is a ' person class. 
		
		A musician can use the public (and protected) properties and methods of the person class
		A musician can override (essentially redefine) any virtual methods contained in the person class
		A musician can also define its own properties and methods
   */
    public class Person : Object
    {
        //private means it is only visible to this person class.. will not be visible outside of the person class
        private String name;                        // person's name
        private String gender;                      // male or female

        //protected means it will be only visible to this class AND to any derived classes (e.g lecturer & Musician classes below)
        protected string phonenumber;                    

        // constructor
        public Person(String name, String gender = "Male")   // : base()   //calls base() constructor by default
        {
            this.name = name;				        
            this.gender = gender;
            this.phonenumber = "";
        }

        // virtual means this can be overriden in sublcass
        public virtual String GetHumanType()        
        {
            return "a Person";
        }

        // override member inherited from System.Object, defined as virtual in superclass
        public override String ToString()
        {
            return "Name: " + name + " Gender: " + gender;
        }		
    }
	
	
    public class Musician : Person					// a Musician "isa" Person
    {
        private String favouriteInstrument;

        // name and gender not inherited since private in superclass 
        // can inherit properties also
        // public and protected members inherited (except for constructors)
        // private members not inherited

        // constructor
        public Musician(String name, String gender, string phonenumber,  String favouriteInstrument)
            : base(name, gender)         // call base class constructor
        {
            this.phonenumber = phonenumber;    //I can access the protected memebr of my base class
            this.favouriteInstrument = favouriteInstrument;
        }

        // override inherited member, access modifier must match
        public override String GetHumanType()               // override is implicity virtual and can be overridden in subclass
        {
            return "a Musician";
        }

        // override member inherited from Person, call base class method and append instrument name
        public override String ToString()
        {
            return base.ToString()
                //+ "name : " + name                   // cant access name here because it is private to person
                + "phonenumber : " + phonenumber       // CAN access phonenumber because it is protected in person class
                + " Favourite Instrument: " + favouriteInstrument;
        }

    }

    // test class
    public class Test
    {
        public static void Main()
        {
            Person p1 = new Person("John");
            Console.WriteLine(p1.GetHumanType() + ", " + p1);
           

            Musician p2 = new Musician("Ringo", "Male", "08711122", "Drums");
            Console.WriteLine(p2.GetHumanType() + ", " + p2);
            
        }
    }
}


/*  Notes  

//----Properties and inherintance   -------------------
The get and set portions of a property are called accessors.
By default these accessors have the same visibility, or access level: that of the property to which they belong. 
However, it is sometimes useful to restrict access to one of these accessors. Typically, this involves restricting the accessibility of the set accessor, while keeping the get accessor publicly accessible. For example:

private string name = "Hello";

public string Name
{
    get
    {
        return name;
    }
    protected set   //only derived classes have access to set name
    {
        name = value;
    }
}


//----Access Modifiers   -------------------
public	:  Access is not restricted. Public access is the most permissive access level. There are no restrictions on accessing public members or classes.
protected: Access is limited to the containing class or types derived from the containing class.
internal :	Access is limited to the current assembly.
protected internal :	Access is limited to the current assembly or types derived from the containing class.
private	:  Most restrictive access. Access is limited to the containing type.
  

classes by defaul are internal i.e if you declare class with no access modifier it will be internal to asssembly
class person      
{ 
  ....
}

 
Derived classes cannot have greater accessibility than their base types. 
In other words, you cannot have a public class B that derives from an internal class A. 
If this were allowed, it would have the effect of making A public, because all protected or internal members of A are accessible from the derived class.
  
 

*/



