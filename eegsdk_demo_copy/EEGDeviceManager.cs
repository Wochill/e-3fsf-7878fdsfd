using KSEEG_Fversion_Lib;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using Windows.Devices.Bluetooth;

namespace EEG2DVisualizer
{
    public class EEGDeviceManager
    {
        private readonly BleManager _bleManager;
        private BluetoothLEDevice _selectedDevice;
        private List<BluetoothLEDevice> _deviceList = new List<BluetoothLEDevice>();

        // 事件定义
        public event Action<BluetoothLEDevice> DeviceFound;
        public event Action ConnectionStateChanged;
        public event Action<double, double> ChannelDataReceived;
        public event Action<string> ErrorOccurred;

        public bool IsConnected => _bleManager != null && _bleManager.IsConnected;
        public IReadOnlyList<BluetoothLEDevice> Devices => _deviceList.AsReadOnly();

        public EEGDeviceManager()
        {
            try
            {
                _bleManager = BleManager.Instance;
                byte[] set = new byte[] { (byte)0b11100011, (byte)0b00000000 };
                _bleManager.init(set);

                // 注册事件
                _bleManager.onDeviceFound += OnDeviceFound;
                _bleManager.onDisConnectSuccess += OnDisconnected;
                _bleManager.onConnectFailure += OnConnectFailed;
                _bleManager.onServiceDiscoverySucceed += OnConnected;
                _bleManager.onReceiveData += OnDataReceived;
            }
            catch (Exception ex)
            {
                ErrorOccurred?.Invoke($"初始化设备管理器失败: {ex.Message}");
            }
        }

        private void OnDataReceived(JObject data)
        {
            try
            {
                if (data["channel_1"] is JArray channel1 &&
                    data["channel_2"] is JArray channel2)
                {
                    // 取最新的一个数据点
                    double value1 = (double)channel1[channel1.Count - 1];
                    double value2 = (double)channel2[channel2.Count - 1];

                    ChannelDataReceived?.Invoke(value1, value2);
                }
            }
            catch (Exception ex)
            {
                ErrorOccurred?.Invoke($"处理数据失败: {ex.Message}");
            }
        }

        private void OnDeviceFound(BluetoothLEDevice device)
        {
            if (!_deviceList.Exists(d => d.BluetoothAddress == device.BluetoothAddress))
            {
                _deviceList.Add(device);
                DeviceFound?.Invoke(device);
            }
        }

        private void OnConnected()
        {
            ConnectionStateChanged?.Invoke();
        }

        private void OnDisconnected()
        {
            ConnectionStateChanged?.Invoke();
        }

        private void OnConnectFailed()
        {
            ErrorOccurred?.Invoke("连接设备失败");
            ConnectionStateChanged?.Invoke();
        }

        // 公共方法
        public void StartScanning()
        {
            _deviceList.Clear();
            _bleManager.scanDevice();
        }

        public void StopScanning()
        {
            _bleManager.scanStop();
        }

        public void ConnectToDevice(int index)
        {
            if (index >= 0 && index < _deviceList.Count)
            {
                _selectedDevice = _deviceList[index];
                _bleManager.scanStop();
                _bleManager.connectDevice(_selectedDevice);
            }
        }

        public void Disconnect()
        {
            if (_selectedDevice != null)
            {
                _deviceList.Remove(_selectedDevice);
                _selectedDevice.Dispose();
                _selectedDevice = null;
            }
            _bleManager.disconnectDevice();
        }

        public void SetMagnification(int level)
        {
            _bleManager.setMagnify(level);
        }

        public void SetLight(int level)
        {
            _bleManager.setLight(level);
        }
    }
}