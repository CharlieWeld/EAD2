// demo of structures, structs are value types

using System;

/*  ----------------------------------------------------------------
A struct is similar to a class, with the following key differences:
 - A struct is a value type, whereas a class is a reference type.
 - A struct does not support inheritance (other than implicitly deriving from object).
A struct can have all the members a class can, except:
 - A parameterless constructor
 - A finalizer
 - Virtual members

all simple types in C# e.g. int, bool etc. are aliases for Structs e.g. System.Int32, System.Boolean etc.
Structs are value types which directly contain values, allocated on stack
Structs can be for performance enhancement
Structs do not support inheritance (except that they inherit from Object)
Structs can have non default constructors, methods, properties
The compiler always supplies a default (parameterless) constructor for a Struct (values 0, false, null)

------------------------------------------------------------------------------------
*/
namespace StructDemo
{
    // define custom value type
    public struct ClockTime	    // use only for small data structures!!, implictly sealed
    {
        int hours;              // 0 .. 23          24 hour clock format
        int minutes;            // 0 .. 59
        int seconds;            // 0 .. 59

        // default constructor always supplied by compiler!

        // non-default constructor, must initialise all fields
        public ClockTime(int hours, int minutes, int seconds)
        {
            // must initialise all fields else syntax error

            if ((hours >= 0) && (hours <= 23))
            {
                this.hours = hours;
            }
            else
            {
                throw new ArgumentException("Invalid value specified for hour: " + hours);
            }
            if ((minutes >= 0) && (minutes <= 59))
            {
                this.minutes = minutes;
            }
            else
            {
                throw new ArgumentException("Invalid value specified for minute: " + minutes);
            }
            if ((seconds >= 0) && (seconds <= 59))
            {
                this.seconds = seconds;
            }
            else
            {
                throw new ArgumentException("Invalid value specified for seocnd: " + seconds);
            }
        }


        // read only properties

        public int Hours
        {
            get
            {
                return hours;
            }
        }

        public int Minutes
        {
            get
            {
                return minutes;
            }
        }

        public int Seconds
        {
            get
            {
                return seconds;
            }
        }

        // move the time forward by 1 second
        public void Tick()
        {
            if (seconds < 59)
            {
                seconds++;
            }
            else
            {
                seconds = 0;
                if (minutes < 59)
                {
                    minutes++;
                }
                else
                {
                    minutes = 0;
                    if (hours < 23)
                    {
                        hours++;
                    }
                    else
                    {
                        hours = 0;
                    }
                }
            }
        }
        // inherited from System.Object, via System.ValueType (an abstract class)
        public override string ToString()
        {
            return Hours + ":" + Minutes + ":" + Seconds;
        }
    }

    // test class
    class Test
    {
        static void Main()
        {
            ClockTime t1 = new ClockTime(11, 59, 59);               // almost noon
            ClockTime t2 = t1;                                      // copy the whole structure t1 into t2
            t2.Tick();                                              // noon now, t1 unaffected
            Console.WriteLine(t1.ToString());
            Console.WriteLine(t2.ToString());
        }
    }
	
	
	/* -------------------------------------------------
	The following Struct shows some typical compiler errors when declaring structs 
	
	public struct Point
	{
	  int x = 1;         // Illegal, cannot initialize field
	  int y;
	  public Point() {}  // Illegal, cannot have
	                     // parameterless constructor

	  public Point(int x) {this.x = x;}   // illegal, must
	                                      // assign field y
	}
	
	-----------------------------------------------
	*/
}