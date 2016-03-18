// static members

using System;

namespace ClassesAndObjects
{
    class baseclass
    {
        private int privatefield;
        protected int protectedfield;
        public int publicField;
        int afield;

        private void privateMethod()
        {
            Console.WriteLine("Private : can only be callled from methods in my own class");
        }

        protected void protectedMethod()
        {
            Console.WriteLine("protecte : can only be callled from methods in my own class AND DERIVED classes");
        }

        public void publicMethod()
        {
            Console.WriteLine("public : can be called form any class");
        }

        public void aMethod()
        {
			//this class can ALWAYS access all its own stuff
            privatefield = 0;
            protectedfield = 0;
            publicField = 0;
            privateMethod();
            protectedMethod();
            publicMethod();

            this.privatefield = 0;  //**NB**  this :  refers to this object
            this.publicMethod();
        }
    }

    class derivedClass : baseclass
    {
        public void someMethod()
        {
            //privatefield = 9;  //derived class cannot access Base classes private stuff
            protectedfield = 9;  //derived class CAN access Base classes protected stuff
            publicField = 9;     //Everyone can access public stuff

            //privateMethod();  //derived class cannot access Base classes private stuff
            protectedMethod();
            publicMethod();

            base.protectedMethod();
            //afield = 0;
        }
    }

    class TestClass                                     // a test class
    {
        private static void Main()
        {
            /*---- base class object -------*/
            baseclass bObj = new baseclass();
            //b.privatefield = 9;         //From outside the class, we can't access private stuff
            //b.protectedfield = 9;       //From outside the class, we can't access protected stuff
            bObj.publicField = 9;

            //b.privateMethod();
            //b.protectedMethod();
            bObj.publicMethod();


            /*---- Derived class object -------*/
            derivedClass dObj = new derivedClass();
            //d.privatefield = 9;       //From outside the class, we can't access private stuff
            //d.protectedfield = 9;     //From outside the class, we can't access protected stuff
            dObj.publicField = 9;          //Everyone can access public stuff

            //d.privateMethod();         //From outside the class, we can't access private stuff
            //d.protectedMethod();        //From outside the class, we can't access protected stuff
            dObj.publicMethod();            //Everyone can access public stuff


           
        }
    }
}
