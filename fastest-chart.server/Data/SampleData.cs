using System.Collections.Concurrent;

namespace fastest_chart.server.Data;

public static class SampleData
{
    public static List<ChartData> GetRandomW1ToW6Data(int range, int hrsMax, int qtyMax)
    {
        var rnd = new Random();
        var chartData = new List<ChartData>();

        for (var i = 1; i <= range; i++)
        {
            chartData.Add(new ChartData()
            {
                Range = $"{i}", HoursRequired = rnd.Next(1, hrsMax), HoursAvailable = rnd.Next(1, hrsMax),
                QtyRequired = rnd.Next(1, qtyMax), QtyAvailable = rnd.Next(1, qtyMax)
            });
        }

        return chartData;
    }
}