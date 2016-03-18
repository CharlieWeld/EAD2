using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            // Except bad input from outside sources
            try
            {

                StreamReader reader = new StreamReader("tex.txt");

                string line = "";

                while (line != null)
                {
                    line = reader.ReadLine();
                    if (line != null)
                    {
                        Console.WriteLine(line);
                    }
                }

                reader.Close();
                
            }

            // Catch the most specific exceptions first and then check for the general ones

            catch(DirectoryNotFoundException e)
            {
                Console.WriteLine("Couldn't find the file are you sure the directory exists?");
            }
            catch(FileNotFoundException e)
            {
                Console.WriteLine("Couldn't find the file are you sure your looking for the correct file?");
            }
            catch(Exception e)
            {
                Console.WriteLine("Something didn't quite work correctly {0}", e.Message);
            }

            finally
            {
                Console.WriteLine("perform cleanups");
            }
            Console.ReadLine();
            }
        }

    
    
}
