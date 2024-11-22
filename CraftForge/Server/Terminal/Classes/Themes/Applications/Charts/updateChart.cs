using System.Windows.Forms.DataVisualization.Charting;

namespace CraftForge.Server.Classes.Themes.Applications.Charts
{
    internal class updateChart
    {
        public static void updateCharts(Chart ramUsageChart, Chart cpuUsageChart)
        {
            cpuUsageChart.Series.Clear();
            var cpuSeries = new Series
            {
                Name = "CPU Usage",
                ChartType = SeriesChartType.Line,
                XValueType = ChartValueType.Int32
            };

            cpuUsageChart.ChartAreas[0].AxisY.Minimum = 0; //Disable negative values (Y axis)
            cpuUsageChart.ChartAreas[0].AxisX.Minimum = 0; //Disable negative values (X axis)
            cpuUsageChart.ChartAreas[0].AxisX.Maximum = 6;

            cpuUsageChart.Series.Add(cpuSeries);
            cpuUsageChart.ChartAreas[0].AxisX.Title = "Time";
            cpuUsageChart.ChartAreas[0].AxisY.Title = "CPU Usage";

            cpuUsageChart.Legends[0].Enabled = false; //Hide the legend
            cpuUsageChart.ChartAreas[0].AxisX.MajorGrid.Enabled = false; //Hide the grid
            cpuUsageChart.ChartAreas[0].AxisX.LabelStyle.Enabled = false; //Hide the label (x)

            ramUsageChart.Series.Clear();
            var ramSeries = new Series
            {
                Name = "Ram Usage",
                ChartType = SeriesChartType.Line,
                XValueType = ChartValueType.Int32
            };

            ramUsageChart.ChartAreas[0].AxisY.Minimum = 0; //Disable negative values (Y axis)
            ramUsageChart.ChartAreas[0].AxisX.Minimum = 0; //Disable negative values (X axis)
            ramUsageChart.ChartAreas[0].AxisX.Maximum = 6;

            ramUsageChart.Series.Add(ramSeries);
            ramUsageChart.ChartAreas[0].AxisX.Title = "Time";
            ramUsageChart.ChartAreas[0].AxisY.Title = "Ram Usage";

            ramUsageChart.Legends[0].Enabled = false; //Hide the legend
            ramUsageChart.ChartAreas[0].AxisX.MajorGrid.Enabled = false; //Hide the grid
            ramUsageChart.ChartAreas[0].AxisX.LabelStyle.Enabled = false; //Hide the label (x)
        }
    }
}
