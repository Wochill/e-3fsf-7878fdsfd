using System;
using System.Windows.Forms;
using Windows.Devices.Bluetooth;

namespace EEG2DVisualizer
{
    public partial class MainForm : Form
    {
        private readonly EEGDeviceManager _deviceManager;
        private readonly SignalProcessor _signalProcessor;
        private readonly ChartVisualizer _chartVisualizer;

        public MainForm()
        {
            InitializeComponent();

            // 初始化组件
            _deviceManager = new EEGDeviceManager();
            _signalProcessor = new SignalProcessor();
            _chartVisualizer = new ChartVisualizer(chart2DPlane);

            // 注册事件
            _deviceManager.DeviceFound += OnDeviceFound;
            _deviceManager.ConnectionStateChanged += OnConnectionStateChanged;
            _deviceManager.ChannelDataReceived += OnChannelDataReceived;
            _deviceManager.ErrorOccurred += OnErrorOccurred;

            // 初始化参数
            numericXMin.Value = (decimal)_signalProcessor.XMin;
            numericXMax.Value = (decimal)_signalProcessor.XMax;
            numericYMin.Value = (decimal)_signalProcessor.YMin;
            numericYMax.Value = (decimal)_signalProcessor.YMax;
            trackBarSmooth.Value = (int)(_signalProcessor.SmoothFactor * 100);
        }

        private void OnDeviceFound(BluetoothLEDevice device)
        {
            if (comboBoxDevices.InvokeRequired)
            {
                // 改用BeginInvoke异步更新，避免阻塞扫描线程
                comboBoxDevices.BeginInvoke(new Action<BluetoothLEDevice>(OnDeviceFound), device);
                return;
            }

            // 处理设备名称为空的情况，添加默认名称
            string deviceName = string.IsNullOrWhiteSpace(device.Name) ? "Unknown Device" : device.Name;
            // 保持与原项目一致的显示格式（空格分隔），避免格式差异导致的识别问题
            comboBoxDevices.Items.Add($"{deviceName}  {device.BluetoothAddress}");
            // 显式刷新下拉列表，确保UI即时更新
            comboBoxDevices.Refresh();
        }

        private void OnConnectionStateChanged()
        {
            UpdateUIState();
        }

        private void OnChannelDataReceived(double channel1, double channel2)
        {
            // 显示原始数据
            UpdateRawDataDisplay(channel1, channel2);

            // 转换为坐标并更新可视化
            var (x, y) = _signalProcessor.ConvertToCoordinates(channel1, channel2);
            _chartVisualizer.UpdatePoint(x, y);
        }

        private void OnErrorOccurred(string message)
        {
            if (textBoxLog.InvokeRequired)
            {
                textBoxLog.Invoke(new Action<string>(OnErrorOccurred), message);
                return;
            }

            textBoxLog.AppendText($"错误: {message}{Environment.NewLine}");
        }

        private void UpdateRawDataDisplay(double channel1, double channel2)
        {
            if (labelChannel1.InvokeRequired)
            {
                labelChannel1.Invoke(new Action<double, double>(UpdateRawDataDisplay), channel1, channel2);
                return;
            }

            labelChannel1.Text = $"通道1: {channel1:F2}";
            labelChannel2.Text = $"通道2: {channel2:F2}";
        }

        private void UpdateUIState()
        {
            if (buttonConnect.InvokeRequired)
            {
                buttonConnect.Invoke(new Action(UpdateUIState));
                return;
            }

            bool isConnected = _deviceManager.IsConnected;
            buttonConnect.Enabled = !isConnected && comboBoxDevices.SelectedIndex >= 0;
            buttonDisconnect.Enabled = isConnected;
            buttonScan.Enabled = !isConnected;
            groupBoxParameters.Enabled = isConnected;

            labelConnectionStatus.Text = isConnected ? "已连接" : "未连接";
            labelConnectionStatus.ForeColor = isConnected ? System.Drawing.Color.Green : System.Drawing.Color.Red;
        }

        #region 控件事件处理

        private void buttonScan_Click(object sender, EventArgs e)
        {
            comboBoxDevices.Items.Clear();
            _deviceManager.StartScanning();
            textBoxLog.AppendText("开始扫描设备...\r\n");
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (comboBoxDevices.SelectedIndex >= 0)
            {
                _deviceManager.ConnectToDevice(comboBoxDevices.SelectedIndex);
                textBoxLog.AppendText("正在连接设备...\r\n");
            }
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            _deviceManager.Disconnect();
            textBoxLog.AppendText("已断开连接\r\n");
            _chartVisualizer.ClearTrail();
        }

        private void buttonApplyParameters_Click(object sender, EventArgs e)
        {
            // 更新信号处理器参数
            _signalProcessor.XMin = (double)numericXMin.Value;
            _signalProcessor.XMax = (double)numericXMax.Value;
            _signalProcessor.YMin = (double)numericYMin.Value;
            _signalProcessor.YMax = (double)numericYMax.Value;
            _signalProcessor.SmoothFactor = trackBarSmooth.Value / 100.0;

            // 更新可视化平面
            _chartVisualizer.SetPlaneSize((int)numericPlaneWidth.Value, (int)numericPlaneHeight.Value);
            _signalProcessor.PlaneWidth = (int)numericPlaneWidth.Value;
            _signalProcessor.PlaneHeight = (int)numericPlaneHeight.Value;

            textBoxLog.AppendText("参数已更新\r\n");
        }

        private void buttonClearTrail_Click(object sender, EventArgs e)
        {
            _chartVisualizer.ClearTrail();
        }

        #endregion

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _deviceManager.Disconnect();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {

        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void label1_Click_1(object sender, EventArgs e)
        {

        }



        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void chart2DPlane_Click(object sender, EventArgs e)
        {

        }

    }
}