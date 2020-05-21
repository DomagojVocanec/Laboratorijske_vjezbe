using System;
using System.Collections.Generic;
using System.Text;

namespace LV3
{
    class MatrixGenerator
    {
        private static MatrixGenerator instance;
        private Random generator;
        private MatrixGenerator()
        {
            this.generator = new Random();
        }
        public static MatrixGenerator GetInstance()
        {
            if (instance == null)
            {
                instance = new MatrixGenerator();
            }
            return instance;
        }
        public int NextInt()
        {
            return this.generator.Next();
        }
        public int NextInt(int upperBound)
        {
            return this.generator.Next(upperBound);
        }
        public int NextInt(int lowerBound, int upperBound)
        {
            return this.generator.Next(lowerBound, upperBound);
        }
        public double NextDouble()
        {
            return this.generator.NextDouble();
        }

        public int[,] GetMatrix(int rows, int columns)
        {
            int[,] matrix = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = this.NextInt();
                }
            }
            return matrix;
        }
    }
}
