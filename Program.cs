using System;
using System.Collections.Generic;

namespace VotingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dictionary to store voting topics and their respective options
            Dictionary<string, List<string>> votingTopics = new Dictionary<string, List<string>>();

            // Dictionary to store user information and their respective votes
            Dictionary<string, string> userVotes = new Dictionary<string, string>();

            // Flag to indicate if the program should continue running
            bool keepRunning = true;

            while (keepRunning)
            {
                // Display main menu
                Console.WriteLine("1. Create a voting topic");
                Console.WriteLine("2. Vote");
                Console.WriteLine("3. View voting results");
                Console.WriteLine("4. Exit");

                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter voting topic: ");
                        string topic = Console.ReadLine();

                        Console.Write("Enter number of options: ");
                        int numOptions = int.Parse(Console.ReadLine());

                        List<string> options = new List<string>();
                        for (int i = 0; i < numOptions; i++)
                        {
                            Console.Write($"Enter option {i + 1}: ");
                            options.Add(Console.ReadLine());
                        }

                        votingTopics[topic] = options;
                        break;

                    case 2:
                        Console.Write("Enter your first name: ");
                        string firstName = Console.ReadLine();

                        Console.Write("Enter your last name: ");
                        string lastName = Console.ReadLine();

                        Console.Write("Enter your date of birth (DD.MM.YYYY): ");
                        string dateOfBirth = Console.ReadLine();

                        Console.Write("Enter voting topic: ");
                        topic = Console.ReadLine();

                        Console.Write("Enter your vote: ");
                        string vote = Console.ReadLine();

                        userVotes[firstName + " " + lastName + " " + dateOfBirth] = vote;
                        break;

                    case 3:

                        Console.WriteLine("1. View results by user");
                        Console.WriteLine("2. View results by voting topic");

                        Console.Write("Enter your choice: ");
                        int viewChoice = int.Parse(Console.ReadLine());

                        switch (viewChoice)
                        {
                            case 1:

                                foreach (KeyValuePair<string, string> userVote in userVotes)
                                {
                                    Console.WriteLine($"{userVote.Key}: {userVote.Value}");
                                }
                                break;

                            case 2:

                                foreach (KeyValuePair<string, List<string>> votingTopic in votingTopics)
                                {
                                    Console.WriteLine($"Results for {votingTopic.Key}:");
                                }
                                break;

                        }
                        break;
                    case 4:
                        return;
                }
            }
        }
    }
}