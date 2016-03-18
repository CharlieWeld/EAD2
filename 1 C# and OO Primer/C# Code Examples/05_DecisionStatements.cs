// if statement

using System;						

namespace Decision                     
{
    class DecisionStatements          
    {
        private static void Main()          
        {
			//--------------------------------	
			//1.  simple if statement
			//--------------------------------	
            bool isRaining = true;    
            if (isRaining)
                Console.WriteLine("Take an umbrella");
				
			
			//--------------------------------			
			//2.  multiple if..else statements	
			//--------------------------------	
			int examScore;
            examScore = 75;
    
            if(examScore < 35)
                Console.WriteLine("You got an F");
            else if(examScore <= 39)
                Console.WriteLine("You got a D");
            else if(examScore <= 49)
                Console.WriteLine("You got a C");
            else if(examScore <= 54)
                Console.WriteLine("You got a C+");
            else if(examScore <= 59)
                Console.WriteLine("You got a B-");
            else if(examScore <= 69)
                Console.WriteLine("You got a B");
            else if (examScore <= 79)
                Console.WriteLine("You got a B+");
            else
            {
                Console.Write("Congratulations ");
                Console.WriteLine("You got an A");
            }
        
			//--------------------------------			
			//2.  IF Else and corresponding Switch statement
			//--------------------------------	
		    int thrown = 4;

            if (thrown == 1)
                Console.WriteLine("You threw a one");
            else if (thrown == 2)
                Console.WriteLine("You threw a two");
            else if (thrown == 3)
                Console.WriteLine("You threw a three");
            else if (thrown == 4)
                Console.WriteLine("You threw a four");
            else if (thrown == 5)
                Console.WriteLine("You threw a five");
            else if (thrown == 6)
                Console.WriteLine("You threw a six");
            else
                Console.WriteLine("Invalid!");

            // using a switch instead

            switch (thrown)             // not applicable to floats or doubles
            {
                case 1:                 // must be a constant value
                    {
                        Console.WriteLine("You threw a one");
                        break;          // mandatory
                    }
                case 2:
                    {
                        Console.WriteLine("You threw a two");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("You threw a three");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("You threw a four");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("You threw a five");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("You threw a six");
                        break;                          
                    }
                default:       // optional catch all
                    {
                        Console.WriteLine("Invalid!");
                        break;
                    }
            }
			
			
			//--------------------------------			
			//3.  Dangling else problem  and using nested if
			//--------------------------------	
			int x = 6;
            int y = 4;
    
            if (x > 5)
                if (y > 5)
                    Console.WriteLine("x and y are both > 5");
            else
                Console.WriteLine("x is <= 5");
  
            // BE CAREFEL : else always matches previous else so beware            
            // Following if makes it clear which else matches which if
            if (x > 5)
            {
              if (y > 5)
                Console.WriteLine("x and y are both > 5");
            }
            else
              Console.WriteLine("x is <= 5");
            
		
        }  //closing bracket for Main()
    
	}  //closing bracket for DecisionStatements
    
}  //closing bracket for namespace 
	


