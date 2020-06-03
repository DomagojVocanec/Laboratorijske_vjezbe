using System;
using System.Collections.Generic;
using System.Text;

namespace LV5
{
    class DataConsolePrinter
    {
        public void printData(IDataset dataset)
        {
            if (dataset.GetData() == null)
            {
                Console.WriteLine("Ne možete pristupiti podacima!");
                return;
            }
            StringBuilder stringBuilder = new StringBuilder();
            foreach(List<string> row in dataset.GetData())
            {
                foreach(string word in row)
                {
                    stringBuilder.Append(word).Append(' ');
                }
                stringBuilder.Append('\n');
            }
            Console.WriteLine(stringBuilder.ToString());
        }

    }
}
