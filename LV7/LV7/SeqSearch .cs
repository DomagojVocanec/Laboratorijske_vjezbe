using System;
using System.Collections.Generic;
using System.Text;

namespace LV7
{
    class SeqSearch : ISearch
    {
        public bool Search(double[] array, double element)
        {
            for (int i = 0; i < array.Length; i++)
                if (array[i] != element)
                    return false;
                return true;
        }
    }
}
