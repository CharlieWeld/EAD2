// demo of List<T> - generic collection, generic version of ArrayList

using System;
using System.Collections.Generic;

public class Dog
{
    // 2 auto properties
    public String Name { get; set; }
    public String Breed { get; set; }

    public override string ToString()
    {
        return Name + " is a " + Breed;
    }
}

// test class
class Test
{
    public static void Main()
    {
        // use List<T> i.e. stongly typed collection of object of type T
        List<Dog> litter = new List<Dog>();                                     // a collection of Dogs (not Objects)
        
        // add 2 dogs, can only add Dogs (Dogs or instance of subclasses of Dog) to litter
        litter.Add(new Dog() { Name = "Snoop", Breed = "Rottweiler" });
        litter.Add(new Dog() { Name = "Pluto", Breed = "Labrador" });

        foreach (Dog d in litter)                   // List<T> is an enumerable type
        {
            Console.WriteLine(d);
        }

        Console.WriteLine();

        // insert a new dog in middle of litter
        litter.Insert(1, new Dog() { Name = "Scooby", Breed = "Great Dane" });

        // take out last dog
        litter.RemoveAt(litter.Count - 1);                          // Count, not Length

        for (int i = 0; i < litter.Count; i++)
        {
            Dog dog = litter[i];                                    // retieve item using indexer, no cast necessary                      
            Console.WriteLine(dog);                   
        }
        
        // List<T> has an indexer as follows:
        // public T this[int index] { get; set; }

    }
}