using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace LV5
{
    class LoggingProxy : IDataset
    {
        private string filePath;
        private Dataset dataset;
        public LoggingProxy(string filePath)
        {
            this.filePath = filePath;
        }
        public ReadOnlyCollection<List<string>> GetData()
        {
            if (dataset == null)
            {
                dataset = new Dataset(filePath);
            }
            ConsoleLogger.Instance().Log();
            return dataset.GetData();
        }
    }
}
