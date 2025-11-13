using System;

namespace EEG2DVisualizer
{
    public class SignalProcessor
    {
        // 坐标映射参数
        public double XMin { get; set; } = -1000;
        public double XMax { get; set; } = 1000;
        public double YMin { get; set; } = -1000;
        public double YMax { get; set; } = 1000;
        public int PlaneWidth { get; set; } = 800;
        public int PlaneHeight { get; set; } = 600;

        // 平滑系数，使点的运动更平滑
        public double SmoothFactor { get; set; } = 0.2;

        private double _lastX;
        private double _lastY;
        private bool _isFirstPoint = true;

        /// <summary>
        /// 将两个通道的脑电幅值转换为2D平面坐标
        /// </summary>
        public (double X, double Y) ConvertToCoordinates(double channel1, double channel2)
        {
            // 限制输入信号范围
            double clampedX = Clamp(channel1, XMin, XMax);
            double clampedY = Clamp(channel2, YMin, YMax);

            // 归一化到0-1范围
            double normalizedX = (clampedX - XMin) / (XMax - XMin);
            double normalizedY = (clampedY - YMin) / (YMax - YMin);

            // 转换为平面坐标
            double x = normalizedX * PlaneWidth;
            double y = normalizedY * PlaneHeight;

            // 平滑处理
            if (_isFirstPoint)
            {
                _lastX = x;
                _lastY = y;
                _isFirstPoint = false;
            }
            else
            {
                x = _lastX * (1 - SmoothFactor) + x * SmoothFactor;
                y = _lastY * (1 - SmoothFactor) + y * SmoothFactor;
                _lastX = x;
                _lastY = y;
            }

            return (x, y);
        }

        // 添加Clamp方法以兼容旧版.NET
        private static double Clamp(double value, double min, double max)
        {
            if (value < min) return min;
            if (value > max) return max;
            return value;
        }
    }
}