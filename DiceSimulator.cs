using System;

class DiceSimulator
{
    static void Main()
    {
        Console.WriteLine("Welcome to the dice throwing simulator!");
        Console.Write("How many dice rolls would you like to simulate? ");

        int numberOfRolls = Convert.ToInt32(Console.ReadLine());

        // Create an instance of the DiceRoller class and simulate dice rolls
        DiceRoller diceRoller = new DiceRoller();
        int[] results = diceRoller.SimulateRolls(numberOfRolls);

        // Display the histogram
        Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine($"Total number of rolls = {numberOfRolls}.\n");

        for (int i = 2; i <= 12; i++)
        {
            int percentage = results[i] * 100 / numberOfRolls;
            string asterisks = new string('*', percentage);
            Console.WriteLine($"{i}: {asterisks}");
        }

        Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
    }
}

class DiceRoller
{
    private Random random = new Random();

    public int[] SimulateRolls(int numberOfRolls)
    {
        int[] results = new int[13]; // Index 0 is not used, results[2] to results[12] represent dice sums 2 to 12

        for (int i = 0; i < numberOfRolls; i++)
        {
            int diceSum = RollDice() + RollDice();
            results[diceSum]++;
        }

        return results;
    }

    private int RollDice()
    {
        return random.Next(1, 7); // Simulate rolling a 6-sided die
    }
}
