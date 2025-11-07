using System;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;

namespace EEG2DVisualizer
{
    public class ChartVisualizer
    {
        private readonly Chart _chart;
        private Series _pointSeries;
        private Series _trailSeries;
        private int _maxTrailPoints = 50; // 轨迹点数量

        public ChartVisualizer(Chart chart)
        {
            _chart = chart;
            InitializeChart();
        }

        private void InitializeChart()
        {
            // 清除现有系列
            _chart.Series.Clear();
            _chart.ChartAreas.Clear();

            // 创建图表区域
            var chartArea = new ChartArea("2DPlane");
            chartArea.AxisX.Minimum = 0;
            chartArea.AxisX.Maximum = 800;
            chartArea.AxisY.Minimum = 0;
            chartArea.AxisY.Maximum = 600;
            chartArea.AxisX.Title = "通道1幅值";
            chartArea.AxisY.Title = "通道2幅值";
            _chart.ChartAreas.Add(chartArea);

            // 创建点系列
            _pointSeries = new Series("CurrentPoint");
            _pointSeries.ChartType = SeriesChartType.Point;
            _pointSeries.MarkerSize = 10;
            _pointSeries.MarkerStyle = MarkerStyle.Circle;
            _pointSeries.Color = System.Drawing.Color.Red;
            _chart.Series.Add(_pointSeries);

            // 创建轨迹系列
            _trailSeries = new Series("Trail");
            _trailSeries.ChartType = SeriesChartType.Line;
            _trailSeries.Color = System.Drawing.Color.LightGray;
            _trailSeries.BorderWidth = 1;
            _chart.Series.Add(_trailSeries);

            _chart.Titles.Add("脑电信号2D映射");
        }

        /// <summary>
        /// 更新2D平面上的点位置
        /// </summary>
        public void UpdatePoint(double x, double y)
        {
            if (_chart.InvokeRequired)
            {
                _chart.Invoke(new Action<double, double>(UpdatePoint), x, y);
                return;
            }

            // 更新当前点
            _pointSeries.Points.Clear();
            _pointSeries.Points.Add(new DataPoint(x, y));

            // 更新轨迹
            _trailSeries.Points.Add(new DataPoint(x, y));
            if (_trailSeries.Points.Count > _maxTrailPoints)
            {
                _trailSeries.Points.RemoveAt(0);
            }
        }

        /// <summary>
        /// 设置平面大小
        /// </summary>
        public void SetPlaneSize(int width, int height)
        {
            _chart.ChartAreas["2DPlane"].AxisX.Maximum = width;
            _chart.ChartAreas["2DPlane"].AxisY.Maximum = height;
        }

        /// <summary>
        /// 清除轨迹
        /// </summary>
        public void ClearTrail()
        {
            _trailSeries.Points.Clear();
        }
    }
}