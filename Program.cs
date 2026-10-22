/*
* Name: Eleazar Castilleja
* Course: CSCI 1250, Section 001
* Assignment: Lab 06, Three Short Problems
* Date: October 21, 2026
* Description: A menu that keeps running until the user quits, offering three
* independent exercises or all three at once. Each exercise
* practices decisions and one of the four loops.
*/

using System;

namespace lab06_three_problems
{
    class Program
    {
        static Random rng = new Random(4000);

        static void Main(string[] args)
        {
            int choice = 0;

           
            do
            {
            
                choice = 0;

                Console.WriteLine("=== CSCI 1250 Lab 06 ===");
                Console.WriteLine("1. The Grade Checker");
                Console.WriteLine("2. The Dice Table");
                Console.WriteLine("3. The Score Report");
                Console.WriteLine("4. All three");
                Console.WriteLine("5. Quit");

                Console.Write("Choose 1 through 5: ");
                choice = int.Parse(Console.ReadLine());

                
                while (choice < 1 || choice > 5)
                {
                    Console.Write("Choose a number from 1 to 5.\nChoose 1 through 5: ");
                    choice = int.Parse(Console.ReadLine());
                }

                Console.WriteLine(); 

                if (choice == 1 || choice == 4)
                {
                    RunExercise1();
                }

                if (choice == 2 || choice == 4)
                {
                    RunExercise2();
                }

                if (choice == 3 || choice == 4)
                {
                    RunExercise3();
                }

            } while (choice != 5);

            Console.WriteLine("Goodbye.");
        }

        
        // EXERCISE 1: THE GRADE CHECKER
        static void RunExercise1()
        {
            Console.WriteLine("=== Exercise 1: The Grade Checker ===");
            Console.Write("Score: ");
            int score = int.Parse(Console.ReadLine());

            
            while (score < 0 || score > 100)
            {
                Console.WriteLine("A score must be between 0 and 100.");
                Console.Write("Score: ");
                score = int.Parse(Console.ReadLine());
            }

            char grade;
            if (score >= 90)
            {
                grade = 'A';
            }
            else if (score >= 80)
            {
                grade = 'B';
            }
            else if (score >= 70)
            {
                grade = 'C';
            }
            else if (score >= 60)
            {
                grade = 'D';
            }
            else
            {
                grade = 'F';
            }

            Console.WriteLine($"{score} earns a {grade}.\n");
        }


        // EXERCISE 2: THE DICE TABLE
        static void RunExercise2()
        {
            Console.WriteLine("=== Exercise 2: The Dice Table ===");

            int rollsCount = 0;
            int winsCount = 0;
            string rollAgain = "y";

            do
            {
                rollsCount++;

                int die1 = rng.Next(1, 7);
                int die2 = rng.Next(1, 7);
                int total = die1 + die2;

                string status = "";

                if (die1 == 1 && die2 == 1)
                {
                    status = "Snake eyes.";
                }
                else if (die1 == die2)
                {
                    status = "Doubles!";
                }
                else if (total == 7 || total == 11)
                {
                    status = "A winner.";
                    winsCount++;
                }

                if (string.IsNullOrEmpty(status))
                {
                    Console.WriteLine($"Roll {rollsCount}: {die1} and {die2}, total {total}.");
                }
                else
                {
                    Console.WriteLine($"Roll {rollsCount}: {die1} and {die2}, total {total}. {status}");
                }

                Console.Write("Roll again? (y/n): ");
                rollAgain = Console.ReadLine().Trim().ToLower();

            } while (rollAgain == "y");

            Console.WriteLine($"You rolled {rollsCount} times and won {winsCount}.\n");
        }


        // EXERCISE 3: THE SCORE REPORT
        static void RunExercise3()
        {
            Console.WriteLine("=== Exercise 3: The Score Report ===");

            int[] scores = new int[5];

            for (int i = 0; i < scores.Length; i++)
            {
                Console.Write($"Score {i + 1}: ");
                scores[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            int total = 0;
            int highest = scores[0];
            int passingCount = 0;

           
            foreach (int score in scores)
            {
                total += score;

                if (score > highest)
                {
                    highest = score;
                }

                if (score >= 60)
                {
                    passingCount++;
                }
            }

            double average = (double)total / scores.Length;

            Console.WriteLine($"Scores entered: {scores.Length}");
            Console.WriteLine($"Total: {total}");
            Console.WriteLine($"Average: {average:F1}");
            Console.WriteLine($"Highest: {highest}");
            Console.WriteLine($"Passing: {passingCount} of {scores.Length}\n");
        }
    }
}