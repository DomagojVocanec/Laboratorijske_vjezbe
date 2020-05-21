using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LV2
{
    class Program
    {
        static void Main(string[] args)
        {
            int dices = 20;

            DiceRoller roller = new DiceRoller();
            for (int i = 0; i < dices; i++)
                roller.InsertDie(new Die(8));

            roller.RollAllDice();
            
            roller.GetRollingResults();
            for (int i = 0; i < roller.GetRollingResults().Count; i++)
                Console.WriteLine(roller.GetRollingResults().ElementAt(i));
        }
    }
}
