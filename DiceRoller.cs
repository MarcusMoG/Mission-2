using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2
{
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

}
