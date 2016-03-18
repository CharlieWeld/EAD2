// demo of polymorphic references and polymorphic collections

using System;

namespace AnimalKingdom
{
    /*
    An abstract class is a class you cannot instantiate i.e. you cant create new objects
	from this class for example you cant do => Mammal m = new Mammal()
	Therefore to avail of this classes functionality you must derive classes from it and use them instead
    eg. must use dog object instead of mamal
	*/
	
    public abstract class Mammal : Object    //abstract so you cannot do => Mammal m = new Mammal() 
    {
        // auto-implemented property
        public String Name
        {
            get;
            set;
        }

        // constructor
        public Mammal(String name)
        {
            this.Name = name;				        // set the name
        }

        virtual public void move()      //virtual function can (but doesn't have to) be overridden in derived clas
        {
            Console.WriteLine("mamal is moving");
        }

        // abstract method - no body, class must be abstract
        abstract public void MakeSound();	// virtual is implied	
                                           // abstract method HAS to be ovverridden in derived class
    }


    //--------------------------------
    // a Dog isa Mammal
    //--------------------------------
    public class Dog : Mammal
    {
        // Name property inherited, MakeSound method inherited

        // constructor
        public Dog(String name)
            : base(name)   
        {
        }


        // override inherited abstract method
        public override void move()
        {
            Console.WriteLine("mamal is moving");
        }

        // override inherited abstract method
        public override void MakeSound()
        {
            Console.WriteLine(this.Name + " says " + this.Bark());
        }

        // new member
        public String Bark()
        {
            return "bow wow";
        }  
    }


    //--------------------------------
    // a Cat isa Mammal
    //--------------------------------
    public sealed class Cat : Mammal		    // can't subclass			
    {
        // constructor
        public Cat(String name)
            : base(name)
        {
        }

        // override inherited abstract method
        public override void MakeSound()
        {
            Console.WriteLine(this.Name + " says meow");
        }
    }

	
    //--------------------------------
    // test class
	//--------------------------------
    public class AnimalTest
    {
        public static void Main()
        {
            Mammal m1 = new Dog("Snoop");       // polymorphic reference, normallly Dog d = new Dog("Snoop")
            m1.MakeSound();					    // polymorphic method call - at run-time determine actual object type

            m1.move();

            if (m1 is Dog)                      // a Dog or any subclass of Dog?
            {
                Console.WriteLine(m1.Name + " isa Dog");
                Dog d = (Dog)m1;               // cast, or Dog d = m1 as Dog
                Console.WriteLine(d.Bark());    // Bark can only be called on Dog references
            }

            // polymorphic collection of mammals
            Mammal[] mammals = { new Dog("Pluto"), new Cat("Kitty") };
            foreach (Mammal m in mammals)
            {
                m.MakeSound();
            }
        }
    }

}