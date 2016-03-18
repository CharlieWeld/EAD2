// run an election
 
using System;

class Election
{
    public static void Main()
    {
        const int NoCandidates = 5;
        String[] names = new String[NoCandidates];       // names array 
        int[] votes = new int[NoCandidates];            // votes received array
        
        double totalVotes = 0;
        double[] percentage = new double[NoCandidates]; // percentage of votes array
        
      
        for (int i=0; i < names.Length; i++)             // loop for inputing names, votes, also calculates total votes
        { 
            Console.Write("Please enter candidate's last name: ");
            names[i] = Console.ReadLine();
            Console.Write("Please enter votes recieved for " + names[i] + ": ");
            votes[i] = Int32.Parse(Console.ReadLine());

            totalVotes += votes[i]; 
        }

        Console.WriteLine();

        int maxIndex = 0;

        for (int i = 0; i < names.Length; i++)                                          // loop calculating percentage of votes
        {
            percentage[i] = (votes[i] * 100.0 / totalVotes);
            Console.WriteLine("Candidate: " + names[i] + " Votes Received: " + votes[i] + " % of Total Vote: " + percentage[i]);            // output of name, votes received, and percentage
            
            if (percentage[maxIndex] < percentage[i])                                   // looking for index which received max votes
            {
                maxIndex = i;
            }
        }

       
        Console.Write("Total votes: " + totalVotes); 
        Console.Write("\nThe winner of the election is: " + names[maxIndex]); 
    }
}