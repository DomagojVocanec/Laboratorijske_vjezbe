using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV2
{
    class Die
    {
        private int numberOfSides;
        private RandomGenerator random;
        /*private Random randomGenerator;*/

        /*public Die(int numberOfSides, Random random)
        {
            this.numberOfSides = numberOfSides;
            this.randomGenerator = random;
        }*/
        public Die(int numberOfSides)
        {
            this.numberOfSides = numberOfSides;
            /*this.randomGenerator = new Random();*/
            this.random = RandomGenerator.GetInstance();
        }
        public int Roll()
        {
            /*int rolledNumber = randomGenerator.Next(1, numberOfSides + 1);*/
            int rolledNumber = random.NextInt(1, numberOfSides + 1);
            return rolledNumber;
        }
    }
}
