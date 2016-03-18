// demo of indexers, access an object like an array

using System;
using System.Collections;
using System.Collections.Generic;

/*
Indexers provide a natural syntax for accessing elements in a class or struct that cotains a 'list of values'. 
Indexers are similar to properties, but are accessed via an index argument rather than a property name. 

For example, the string class has an indexer that lets you access each of its char values via an int index:

	string s = "hello";
	Console.WriteLine (s[0]); // 'h'
	Console.WriteLine (s[3]); // 'l'
*/


// a simple blog
class Blog
{
    private String[] words;				    // an array of words - better to use List<String> cf generics
    private const int Max = 1000;           // space for 1000 words in the blog
    
    private int next;                       // next free slot in array

    // default constructor

    public Blog()
    {
        words = new String[Max];            // fixed size, 0 .. Max -1
        next = 0;							//initialize next to be start of array
    }
    public String Author                    // auto property
    {
        get;
        set;
    }

    // read-only property
    public int Length
    {
        get
        {
            return next;                    // current number of items in words array
        }
    }

    // an indexer is a property called "this"
    // indexer, read/write
    public String this[int i]
    {
        get
        {
            if ((i >= 0) && (i < next))
            {
                return words[i];
            }
            else
            {
                throw new ArgumentException("index is out of bounds: " + i);
            }
        }
        set
        {
            // no gaps allowed, index i must be in bounds
            if (i >= 0)
            {
                if (i < next)
                {
                    words[i] = value;               // change existing word
                }
                else if (i == next)                 // add word on end if space
                {
                    if (next < Max)
                    {
                        words[i] = value;
                        next++;
                    }
                    else
                    {
                         throw new ArgumentException("blog is full");
                    }
                }
                else
                {
                    throw new ArgumentException("index is out of bounds: " + i);
                }
            }
            else
            {
                throw new ArgumentException("index is out of bounds: " + i);
            }

        }

    }

    // can overload indexers - each with different index types
    // can put indexers in interfaces
}

// test class
class Test
{
    public static void Main()
    {
        Blog blog = new Blog();

        // set the author
        blog.Author = "GC";

        // indexer sets, treat a blog object like it was an array
        blog[0] = "Welcome";				// 0 is 1st
        blog[1] = "2";
        blog[1] = "to";
        blog[2] = "my";
        blog[3] = "blog";
      

        for (int i = 0; i < blog.Length; i++)
        {
            Console.Write(blog[i] + " ");	// indexer gets
        }

        Console.WriteLine();
    }


    // indexer could be public char this[int i, int j]	// 2D collection

    // index doesn't have to be an int e.g.
    //		public Customer this[string name]			// in CustomerList class
    //		Customer c = CustomerList["john doe"]   
}