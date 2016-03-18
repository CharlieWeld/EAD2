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
        }

        protected void protectedMethod()
        {
        }

        public void publicMethod()
        {
        }

        public void aMethod()
        {
            privatefield = 0;
            protectedfield = 0;
            publicField = 0;
            privateMethod();
            protectedMethod();
            publicMethod();

            this.privatefield = 0;  //this refers to this object
            this.publicMethod();
        }
    }

    class derivedClass : baseclass
    {
        public void someMethod()
        {
            //privatefield = 9;
            protectedfield = 9;
            publicField = 9;

            //privateMethod();
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

            derivedClass d = new derivedClass();
            //d.privatefield = 9;
            //d.protectedfield = 9;
            d.publicField = 9;

            //d.privateMethod();
            //d.protectedMethod();
            d.publicMethod();


            baseclass b = new baseclass();
            //b.privatefield = 9;
            //b.protectedfield = 9;
            b.publicField = 9;
            
            //b.privateMethod();
            //b.protectedMethod();
            d.publicMethod();

        }
    }
}
