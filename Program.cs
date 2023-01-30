using System;
using System.Collections.Generic;

namespace VoteProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> voteTopics = new Dictionary<string, int>();

            while (true)
            {
                Console.WriteLine("1. Create a vote topic");
                Console.WriteLine("2. Vote");
                Console.WriteLine("3. Show results");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter the vote topic: ");
                        string topic = Console.ReadLine();
                        Console.Write("Enter the options, separated by comma: ");
                        string[] options = Console.ReadLine().Split(',');

                        foreach (var option in options)
                        {
                            voteTopics[option.Trim()] = 0;
                        }
                        break;

                    case 2:
                        Console.Write("Enter the topic to vote for: ");
                        string voteTopic = Console.ReadLine();

                        if (voteTopics.ContainsKey(voteTopic))
                        {
                            voteTopics[voteTopic]++;
                            Console.WriteLine("Your vote has been recorded");
                        }
                        else
                        {
                            Console.WriteLine("Invalid topic");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Results:");
                        foreach (var top in voteTopics)
                        {
                            Console.WriteLine(top.Key + ": " + top.Value);
                        }
                        break;

                    case 4:
                        return;
                }
            }
        }
    }
}