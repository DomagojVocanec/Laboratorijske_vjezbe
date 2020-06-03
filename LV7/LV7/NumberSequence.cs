using System;
using System.Collections.Generic;
using System.Text;

namespace LV7
{
    class NumberSequence
    {
        private double[] sequence;
        private int sequenceSize;
        private SortStrategy sortStrategy;
        private ISearch searchStrategy;
        public NumberSequence(int sequenceSize)
        {
            this.sequenceSize = sequenceSize;
            this.sequence = new double[sequenceSize];
        }
        public NumberSequence(double[] array) : this(array.Length)
        {
            array.CopyTo(this.sequence, 0);
        }
        public void InsertAt(int index, double value)
        {
            this.sequence[index] = value;
        }
        public void SetSortStrategy(SortStrategy strategy)
        {
            this.sortStrategy = strategy;
        }
        public void SetSearchStrategy(ISearch strategy)
        {
            this.searchStrategy = strategy;
        }
        public void Sort() { this.sortStrategy.Sort(this.sequence); }
        public bool Search(double element) 
        { 
            return this.searchStrategy.Search(this.sequence, element); 
        }
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            foreach (double element in this.sequence)
            {
                builder.Append(element).Append(Environment.NewLine);
            }
            return builder.ToString();
        }
    }
}
