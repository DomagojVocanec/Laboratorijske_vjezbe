using System;
using System.Collections.Generic;
using System.Text;

namespace LV4
{
    class Adapter : IAnalytics
    {
        private Analyzer3rdParty analyticsService;
        public Adapter(Analyzer3rdParty service)
        {
            this.analyticsService = service;
        }
        private double[][] ConvertData(Dataset dataset)
        {
            IList<List<double>> data = dataset.GetData();
            int rowCount = data.Count;
            int columnCount = 0;

            if (rowCount != 0) 
                columnCount = data[0].Count;

            double[][] newData = new double[rowCount][];
            for (int i = 0; i < rowCount; i++)
                newData[i] = new double[columnCount];
            for (int i = 0; i < rowCount; i++)
                for (int j = 0; j < columnCount; j++)
                    newData[i][j] = data[i][j];
            return newData;
        }
        public double[] CalculateAveragePerColumn(Dataset dataset)
        {
            double[][] data = this.ConvertData(dataset);
            return this.analyticsService.PerColumnAverage(data);
        }
        public double[] CalculateAveragePerRow(Dataset dataset)
        {
            double[][] data = this.ConvertData(dataset);
            return this.analyticsService.PerRowAverage(data);
        }
    }
}
