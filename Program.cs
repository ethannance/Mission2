using System;

class DiceRollSimulator
{
    // Method to simulate dice rolls and return an array of roll counts
    public static int[] SimulateDiceRolls(int numberOfRollsInteger)
    {
        Random random = new Random();
        int[] rollCounts = new int[13]; // Array to store counts of each dice roll total (2-12); index 0 and 1 are unused. Setting the size of the array

        // Loop through the specified number of dice rolls
        for (int iCount = 0; iCount < numberOfRollsInteger; iCount++)
        {
            // Simulate rolling two six-sided dice and sum their values
            int roll = random.Next(1, 7) + random.Next(1, 7);
            rollCounts[roll]++; // Increment the count for this roll total. Adds 1 to what the value was, keeps track how many times each combinatino is rolled
        }

        return rollCounts; // Return the array containing the counts of each roll total
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Welcome message and prompt for user input
        //Writeline just displays, write asks for an input
        Console.WriteLine("Welcome to the dice throwing simulator!");
        Console.Write("How many dice rolls would you like to simulate? ");

        // Read the number of dice rolls from the user and convert it to an integer
        //User input will be a string, we need to convert it to an int
        int numberOfRolls = int.Parse(Console.ReadLine());

        // Call the dice roll simulation method and store the result
        int[] rollCounts = DiceRollSimulator.SimulateDiceRolls(numberOfRolls);

        // Print the results header
        Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine($"Total number of rolls = {numberOfRolls}.");

        // Loop through each possible dice roll total (2-12) 
        for (int i = 2; i <= 12; i++)
        {
            Console.Write($"{i}: ");
            // Calculate and print the percentage of this roll total as asterisks
            int percentage = (int)((double)rollCounts[i] / numberOfRolls * 100);
            Console.WriteLine(new String('*', percentage)); 
        }

        // End message
        Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
    }
}
