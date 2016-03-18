// Exceptions demo - part 4 - throws 

using System;

class Exception4
{
    class Person
    {
        int age;
        
        // propeties
        public String Name { get; set; }           // auto
     
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                // validate age
                if ((value >= 0) && (value <= 120))
                {
                    age = value;
                }
                else
                {
                    throw new ArgumentException("Age must be between 0 and 120");
                }
            }
        }
    }

    class Test
    {
        public static void Main()
        {
            try
            {
                Person p = new Person();
                p.Age = 121;
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}