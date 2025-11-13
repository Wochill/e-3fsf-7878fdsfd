using KSEEG_Fversion_Lib;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Windows.Devices.Bluetooth;
using static KSEEG_Fversion_Lib.BleManager;

namespace eegsdk_demo
{
    public partial class Form1 : Form
    {
        private BleManager bleManager = BleManager.Instance;
        private BluetoothLEDevice selectDevice;
        private List<BluetoothLEDevice> deviceList = new List<BluetoothLEDevice>();
        private bool curConnState = false; //当前设备连接状态

        private ChartAdd chartAdd1;
        private ChartAdd chartAdd2;


        public Form1()
        {
            InitializeComponent();

            byte[] set = new byte[] { (byte)0b11100011, (byte)0b00000000 };
            bleManager.init(set);

            bleManager.onDeviceFound += deviceFound;
            bleManager.onDisConnectSuccess += disConnectSuccess;
            bleManager.onConnectFailure += connectFailure;
            bleManager.onServiceDiscoverySucceed += serviceDiscoverySucceed;

            bleManager.onReceiveData += receiveData;
            bleManager.onReceiveFrequency += receiveFrequency;
            bleManager.onReceiveFeature += receiveFeature;
            bleManager.onReceiveMPU += receiveMPU;
            bleManager.onReceivePPG += receivePPG;
            bleManager.onReceiveBlink += receiveBlink;
            bleManager.onReceiveGnash += receiveGnash;
            bleManager.onReceiveEmotion += receiveEmotion;


            chartAdd1 = new ChartAdd(chart1, 2);
            chartAdd2 = new ChartAdd(chart2, 5);
        }

        private async void receiveData(JObject data)
        {
            JArray channel_1 = (JArray)data["channel_1"];
            JArray channel_2 = (JArray)data["channel_2"];
            JArray blink = (JArray)data["blink"];
            JArray gnash = (JArray)data["gnash"];

            /*string jsonString = JsonConvert.SerializeObject(channel_2);
            Debug.WriteLine("rawdata:    "+jsonString);*/

            /*ThreadPool.QueueUserWorkItem(state => chartAdd1.addPoints(channel_1, channel_2));*/

            chartAdd1.addPoints(channel_1, channel_2);
        }

        private async void receiveFrequency(JObject data)
        {
            double delta = (double)data["delta"];
            double theta = (double)data["theta"];
            double alpha = (double)data["alpha"];
            double beta = (double)data["beta"];
            double gamma = (double)data["gamma"];


            /*Debug.WriteLine("Frequency:  " + delta + "," + theta + "," + alpha + "," + beta + "," + gamma);*/

            /*ThreadPool.QueueUserWorkItem(state => chartAdd2.addPoint(delta, theta, alpha, beta, gamma));*/
            chartAdd2.addPoint(delta, theta, alpha, beta, gamma);
            /*chartAdd3.addPoint(att, relax, meditation, tired);*/

        }

        private void receiveFeature(JObject data)
        {
            double att = (double)data["attention"];
            double relax = (double)data["relax"];
            double meditation = (double)data["meditation"];
            double tired = (double)data["tired"];

            textBox1.Invoke((MethodInvoker)delegate
            {
                textBox1.Text = "   att:" + att + "  relax:" + relax + "  meditation:" + meditation + "  tired:" + tired;
            });

        }

        private void receiveMPU(JObject data)
        {
            JArray acc_x = (JArray)data["acc_x"];
            JArray acc_y = (JArray)data["acc_y"];
            JArray acc_z = (JArray)data["acc_z"];
            JArray gyro_x = (JArray)data["gyro_x"];
            JArray gyro_y = (JArray)data["gyro_y"];
            JArray gyro_z = (JArray)data["gyro_z"];

            textBox2.Invoke((MethodInvoker)delegate
            {
                textBox2.Text = "acc_x:" + acc_x + "   acc_y:" + acc_y + "   acc_z:" + acc_z;
            });


            /*string jsonString = JsonConvert.SerializeObject(acc_x);
            Debug.WriteLine("acc:    " + jsonString);*/
        }

        private void receivePPG(JObject data)
        {
            JArray red = (JArray)data["red"];
            JArray ired = (JArray)data["ired"];
            /*string jsonString = JsonConvert.SerializeObject(red);
            Debug.WriteLine("red:    " + jsonString);*/

            if (data.ContainsKey("spo2"))
            {
                int spo2 = (int)data["spo2"];
                int hr = (int)data["hr"];
                Debug.WriteLine("hr:    " + hr);

                textBox3.Invoke((MethodInvoker)delegate
                {
                    textBox3.Text = "   spo2:" + spo2 + "  hr:" + hr;
                });


            }
        }

        private void receiveBlink(JObject data)
        {
            JArray blink = (JArray)data["blink"];
            textBox2.Invoke((MethodInvoker)delegate
            {
                textBox2.Text = "blink:" + blink[0] + " " + blink[1] + " " + blink[2];
            });
            /*Debug.WriteLine("blink:    " + blink[0]);*/
        }

        private void receiveGnash(JObject data)
        {
            JArray gnash = (JArray)data["gnash"];
            textBox3.Invoke((MethodInvoker)delegate
            {
                textBox3.Text = "gnash:" + gnash[0] + " " + gnash[1] + " " + gnash[2];
            });
            /*Debug.WriteLine("gnash:    " + gnash[0]);*/
        }



        private void receiveEmotion(JObject data)
        {
            double emotion = (double)data["emotion"];
        }



        /*        private void bleMessage(JObject data)
                {
                    double att = (double)data["attention"];
                    double relax = (double)data["relax"];
                    double tired = (double)data["tired"];
                    double med = (double)data["meditation"];

                    Debug.WriteLine("feature:  " + att + "," + relax + "," + tired + "," + med);
                    *//*ThreadPool.QueueUserWorkItem(state => chartAdd3.addPoint(att, relax, med, tired));*/
        /*chartAdd3.addPoint(att, relax, med, tired);*//*
    }*/

        private void serviceDiscoverySucceed()
        {
            curConnState = true;
        }

        private void connectFailure()
        {
            curConnState = false;
        }

        private void disConnectSuccess()
        {
            curConnState = false;
        }

        private void deviceFound(BluetoothLEDevice bluetoothLEDevice)
        {
            Debug.WriteLine("device:  " + bluetoothLEDevice.Name);
            comboBox1.BeginInvoke(new Action(() =>
            {
                if (!deviceList.Any(d => d.BluetoothAddress == bluetoothLEDevice.BluetoothAddress))
                {
                    deviceList.Add(bluetoothLEDevice);
                    comboBox1.Items.Add(bluetoothLEDevice.Name + "  " + bluetoothLEDevice.BluetoothAddress);
                }
            }));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bleManager.scanDevice();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("连接--》" + selectDevice.Name);
            bleManager.scanStop();
            bleManager.connectDevice(selectDevice);
        }

        private void button3_Click(object sender, EventArgs e)
        {


            if (selectDevice != null)
            {//从列表中移除
                this.deviceList.Remove(selectDevice);
                selectDevice.Dispose();
                /*selectDevice = null;*/
                comboBox1.BeginInvoke(new Action(() =>
                {
                    comboBox1.Items.Clear();
                    comboBox1.Text = null;
                }));
            }

            bleManager.disconnectDevice();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectDevice = deviceList[comboBox1.SelectedIndex];
            Debug.WriteLine(selectDevice.Name + "==>" + selectDevice.BluetoothAddress.ToString());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            bleManager.setMagnify(comboBox2.SelectedIndex + 3);
            Debug.WriteLine(comboBox2.SelectedIndex);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            bleManager.setLight(comboBox3.SelectedIndex);
            Debug.WriteLine(comboBox3.SelectedIndex);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (curConnState)
            {
                bleManager.store();
            }
            else
            {
                Debug.WriteLine("请连接设备");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string res = bleManager.stopStore();
            Debug.WriteLine(res);
        }

        private async void button6_Click(object sender, EventArgs e)
        {
            String version = await bleManager.getVersion();
            /*Debug.WriteLine(version);*/
            textBox4.Invoke((MethodInvoker)delegate
            {
                textBox4.Text = version;
            });
        }
    }
}
