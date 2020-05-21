using System;
using System.Collections.Generic;
using System.Text;

namespace LV3
{
    class Dataset : Prototype
    {
        private List<List<string>> data;

        public Dataset()
        {
            this.data = new List<List<string>>();
        }

        public Dataset(string filePath) : this()
        {
            this.LoadDataFromCSV(filePath);
        }

        public void LoadDataFromCSV(string filePath)
        {
            using (System.IO.StreamReader reader = new System.IO.StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    List<string> row = new List<string>();
                    string[] items = line.Split(',');
                    foreach (string item in items)
                    {
                        row.Add(item);
                    }
                    this.data.Add(row);
                }
            }
        }

        public IList<List<string>> GetData()
        {
            return new System.Collections.ObjectModel.ReadOnlyCollection<List<string>>(data);
        }

        public void ClearData()
        {
            this.data.Clear();
        }

        public Prototype Clone()
        {
            List<List<string>> ClonedList = new List<List<string>>();

            foreach (List<string> list in this.data)
            {
                ClonedList.Add(new List<string>());
                foreach (string c in list)
                {
                    ClonedList[ClonedList.Count - 1].Add(c);
                }
            }
            Dataset NewData = new Dataset();
            NewData.data = ClonedList;

            return (Prototype)NewData;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            foreach (List<string> list in this.data)
            {
                foreach (string c in list)
                {
                    stringBuilder.Append(c);
                }
                stringBuilder.Append("\n");
            }
            return stringBuilder.ToString();
        }
    }
}
