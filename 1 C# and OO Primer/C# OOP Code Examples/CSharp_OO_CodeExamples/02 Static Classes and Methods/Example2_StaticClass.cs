using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    //Use keyword static to delcare class as static
    //This means you will not be able to create objects from this class!!
    public static class MathsHelper
    {
        //Note : if static class ALL members have to be static
        //       Therefore i use the word static in all properties and emthods below

        public static string Description { get; set; }

        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static int subtract(int x, int y)
        {
            return x - y;
        }
    }

    class TestClass
    {
        static void Main(string[] args)
        {
            //ERROR : Folloiwng line gives error as can't create an instance (object) of a static class
            // MathsHelper m = new MathsHelper();

            MathsHelper.Description = "A maths help class";
            int answer = MathsHelper.Add(2, 5);

            Console.WriteLine(string.Format("2 + 5 = {0}", answer.ToString()));
            Console.ReadKey();
        }
    }
}