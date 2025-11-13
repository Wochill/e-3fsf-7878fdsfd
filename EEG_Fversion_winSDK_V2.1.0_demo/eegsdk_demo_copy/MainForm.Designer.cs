namespace EEG2DVisualizer
{
    partial class MainForm
    {
        /// <summary>
        /// 设计器所需的变量
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有使用的资源
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容
        /// </summary>
        /// 
        private void InitializeComponent()
        {
            this.chart2DPlane = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxConnection = new System.Windows.Forms.GroupBox();
            this.buttonScan = new System.Windows.Forms.Button();
            this.comboBoxDevices = new System.Windows.Forms.ComboBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.labelConnectionStatus = new System.Windows.Forms.Label();
            this.groupBoxParameters = new System.Windows.Forms.GroupBox();
            this.labelXMin = new System.Windows.Forms.Label();
            this.numericXMin = new System.Windows.Forms.NumericUpDown();
            this.labelXMax = new System.Windows.Forms.Label();
            this.numericXMax = new System.Windows.Forms.NumericUpDown();
            this.labelYMin = new System.Windows.Forms.Label();
            this.numericYMin = new System.Windows.Forms.NumericUpDown();
            this.labelYMax = new System.Windows.Forms.Label();
            this.numericYMax = new System.Windows.Forms.NumericUpDown();
            this.labelPlaneWidth = new System.Windows.Forms.Label();
            this.numericPlaneWidth = new System.Windows.Forms.NumericUpDown();
            this.labelPlaneHeight = new System.Windows.Forms.Label();
            this.numericPlaneHeight = new System.Windows.Forms.NumericUpDown();
            this.labelSmooth = new System.Windows.Forms.Label();
            this.trackBarSmooth = new System.Windows.Forms.TrackBar();
            this.buttonApplyParameters = new System.Windows.Forms.Button();
            this.buttonClearTrail = new System.Windows.Forms.Button();
            this.labelChannel1 = new System.Windows.Forms.Label();
            this.labelChannel2 = new System.Windows.Forms.Label();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart2DPlane)).BeginInit();
            this.groupBoxConnection.SuspendLayout();
            this.groupBoxParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericXMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericXMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericYMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericYMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPlaneWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPlaneHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSmooth)).BeginInit();
            this.SuspendLayout();
            // 
            // chart2DPlane
            // 
            this.chart2DPlane.Location = new System.Drawing.Point(20, 280);
            this.chart2DPlane.Name = "chart2DPlane";
            this.chart2DPlane.Size = new System.Drawing.Size(940, 400);
            this.chart2DPlane.TabIndex = 0;
            this.chart2DPlane.Text = "2D 可视化图表";
            this.chart2DPlane.Click += new System.EventHandler(this.chart2DPlane_Click);
            // 
            // groupBoxConnection
            // 
            this.groupBoxConnection.Controls.Add(this.buttonScan);
            this.groupBoxConnection.Controls.Add(this.comboBoxDevices);
            this.groupBoxConnection.Controls.Add(this.buttonConnect);
            this.groupBoxConnection.Controls.Add(this.buttonDisconnect);
            this.groupBoxConnection.Controls.Add(this.labelConnectionStatus);
            this.groupBoxConnection.Location = new System.Drawing.Point(20, 20);
            this.groupBoxConnection.Name = "groupBoxConnection";
            this.groupBoxConnection.Size = new System.Drawing.Size(940, 100);
            this.groupBoxConnection.TabIndex = 0;
            this.groupBoxConnection.TabStop = false;
            this.groupBoxConnection.Text = "设备连接";
            // 
            // buttonScan
            // 
            this.buttonScan.Location = new System.Drawing.Point(20, 30);
            this.buttonScan.Name = "buttonScan";
            this.buttonScan.Size = new System.Drawing.Size(100, 30);
            this.buttonScan.TabIndex = 0;
            this.buttonScan.Text = "扫描设备";
            this.buttonScan.UseVisualStyleBackColor = true;
            this.buttonScan.Click += new System.EventHandler(this.buttonScan_Click);
            // 
            // comboBoxDevices
            // 
            this.comboBoxDevices.Location = new System.Drawing.Point(140, 30);
            this.comboBoxDevices.Name = "comboBoxDevices";
            this.comboBoxDevices.Size = new System.Drawing.Size(300, 23);
            this.comboBoxDevices.TabIndex = 0;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(460, 30);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(80, 30);
            this.buttonConnect.TabIndex = 0;
            this.buttonConnect.Text = "连接";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Location = new System.Drawing.Point(560, 30);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(80, 30);
            this.buttonDisconnect.TabIndex = 0;
            this.buttonDisconnect.Text = "断开";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // labelConnectionStatus
            // 
            this.labelConnectionStatus.ForeColor = System.Drawing.Color.Red;
            this.labelConnectionStatus.Location = new System.Drawing.Point(660, 35);
            this.labelConnectionStatus.Name = "labelConnectionStatus";
            this.labelConnectionStatus.Size = new System.Drawing.Size(200, 20);
            this.labelConnectionStatus.TabIndex = 0;
            this.labelConnectionStatus.Text = "未连接";
            // 
            // groupBoxParameters
            // 
            this.groupBoxParameters.Controls.Add(this.labelXMin);
            this.groupBoxParameters.Controls.Add(this.numericXMin);
            this.groupBoxParameters.Controls.Add(this.labelXMax);
            this.groupBoxParameters.Controls.Add(this.numericXMax);
            this.groupBoxParameters.Controls.Add(this.labelYMin);
            this.groupBoxParameters.Controls.Add(this.numericYMin);
            this.groupBoxParameters.Controls.Add(this.labelYMax);
            this.groupBoxParameters.Controls.Add(this.numericYMax);
            this.groupBoxParameters.Controls.Add(this.labelPlaneWidth);
            this.groupBoxParameters.Controls.Add(this.numericPlaneWidth);
            this.groupBoxParameters.Controls.Add(this.labelPlaneHeight);
            this.groupBoxParameters.Controls.Add(this.numericPlaneHeight);
            this.groupBoxParameters.Controls.Add(this.labelSmooth);
            this.groupBoxParameters.Controls.Add(this.trackBarSmooth);
            this.groupBoxParameters.Controls.Add(this.buttonApplyParameters);
            this.groupBoxParameters.Controls.Add(this.buttonClearTrail);
            this.groupBoxParameters.Controls.Add(this.labelChannel1);
            this.groupBoxParameters.Controls.Add(this.labelChannel2);
            this.groupBoxParameters.Location = new System.Drawing.Point(20, 140);
            this.groupBoxParameters.Name = "groupBoxParameters";
            this.groupBoxParameters.Size = new System.Drawing.Size(940, 130);
            this.groupBoxParameters.TabIndex = 0;
            this.groupBoxParameters.TabStop = false;
            this.groupBoxParameters.Text = "参数设置";
            // 
            // labelXMin
            // 
            this.labelXMin.Location = new System.Drawing.Point(240, 10);
            this.labelXMin.Name = "labelXMin";
            this.labelXMin.Size = new System.Drawing.Size(100, 20);
            this.labelXMin.TabIndex = 0;
            this.labelXMin.Text = "X最小值:";
            // 
            // numericXMin
            // 
            this.numericXMin.Location = new System.Drawing.Point(240, 30);
            this.numericXMin.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericXMin.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            -2147483648});
            this.numericXMin.Name = "numericXMin";
            this.numericXMin.Size = new System.Drawing.Size(100, 25);
            this.numericXMin.TabIndex = 0;
            this.numericXMin.Value = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            // 
            // labelXMax
            // 
            this.labelXMax.Location = new System.Drawing.Point(240, 40);
            this.labelXMax.Name = "labelXMax";
            this.labelXMax.Size = new System.Drawing.Size(100, 20);
            this.labelXMax.TabIndex = 0;
            this.labelXMax.Text = "X最大值:";
            // 
            // numericXMax
            // 
            this.numericXMax.Location = new System.Drawing.Point(240, 60);
            this.numericXMax.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericXMax.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            -2147483648});
            this.numericXMax.Name = "numericXMax";
            this.numericXMax.Size = new System.Drawing.Size(100, 25);
            this.numericXMax.TabIndex = 0;
            this.numericXMax.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // labelYMin
            // 
            this.labelYMin.Location = new System.Drawing.Point(380, 10);
            this.labelYMin.Name = "labelYMin";
            this.labelYMin.Size = new System.Drawing.Size(100, 20);
            this.labelYMin.TabIndex = 0;
            this.labelYMin.Text = "Y最小值:";
            // 
            // numericYMin
            // 
            this.numericYMin.Location = new System.Drawing.Point(380, 30);
            this.numericYMin.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericYMin.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            -2147483648});
            this.numericYMin.Name = "numericYMin";
            this.numericYMin.Size = new System.Drawing.Size(100, 25);
            this.numericYMin.TabIndex = 0;
            this.numericYMin.Value = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            // 
            // labelYMax
            // 
            this.labelYMax.Location = new System.Drawing.Point(380, 40);
            this.labelYMax.Name = "labelYMax";
            this.labelYMax.Size = new System.Drawing.Size(100, 20);
            this.labelYMax.TabIndex = 0;
            this.labelYMax.Text = "Y最大值:";
            // 
            // numericYMax
            // 
            this.numericYMax.Location = new System.Drawing.Point(380, 60);
            this.numericYMax.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericYMax.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            -2147483648});
            this.numericYMax.Name = "numericYMax";
            this.numericYMax.Size = new System.Drawing.Size(100, 25);
            this.numericYMax.TabIndex = 0;
            this.numericYMax.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // labelPlaneWidth
            // 
            this.labelPlaneWidth.Location = new System.Drawing.Point(520, 10);
            this.labelPlaneWidth.Name = "labelPlaneWidth";
            this.labelPlaneWidth.Size = new System.Drawing.Size(100, 20);
            this.labelPlaneWidth.TabIndex = 0;
            this.labelPlaneWidth.Text = "平面宽度:";
            // 
            // numericPlaneWidth
            // 
            this.numericPlaneWidth.Location = new System.Drawing.Point(520, 30);
            this.numericPlaneWidth.Name = "numericPlaneWidth";
            this.numericPlaneWidth.Size = new System.Drawing.Size(100, 25);
            this.numericPlaneWidth.TabIndex = 0;
            this.numericPlaneWidth.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // labelPlaneHeight
            // 
            this.labelPlaneHeight.Location = new System.Drawing.Point(520, 40);
            this.labelPlaneHeight.Name = "labelPlaneHeight";
            this.labelPlaneHeight.Size = new System.Drawing.Size(100, 20);
            this.labelPlaneHeight.TabIndex = 0;
            this.labelPlaneHeight.Text = "平面高度:";
            // 
            // numericPlaneHeight
            // 
            this.numericPlaneHeight.Location = new System.Drawing.Point(520, 60);
            this.numericPlaneHeight.Name = "numericPlaneHeight";
            this.numericPlaneHeight.Size = new System.Drawing.Size(100, 25);
            this.numericPlaneHeight.TabIndex = 0;
            this.numericPlaneHeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // labelSmooth
            // 
            this.labelSmooth.Location = new System.Drawing.Point(650, 10);
            this.labelSmooth.Name = "labelSmooth";
            this.labelSmooth.Size = new System.Drawing.Size(100, 20);
            this.labelSmooth.TabIndex = 0;
            this.labelSmooth.Text = "平滑系数:";
            // 
            // trackBarSmooth
            // 
            this.trackBarSmooth.Location = new System.Drawing.Point(650, 30);
            this.trackBarSmooth.Maximum = 100;
            this.trackBarSmooth.Name = "trackBarSmooth";
            this.trackBarSmooth.Size = new System.Drawing.Size(120, 56);
            this.trackBarSmooth.TabIndex = 0;
            this.trackBarSmooth.TickFrequency = 5;
            this.trackBarSmooth.Value = 20;
            // 
            // buttonApplyParameters
            // 
            this.buttonApplyParameters.Location = new System.Drawing.Point(800, 30);
            this.buttonApplyParameters.Name = "buttonApplyParameters";
            this.buttonApplyParameters.Size = new System.Drawing.Size(100, 30);
            this.buttonApplyParameters.TabIndex = 0;
            this.buttonApplyParameters.Text = "应用参数";
            this.buttonApplyParameters.UseVisualStyleBackColor = true;
            this.buttonApplyParameters.Click += new System.EventHandler(this.buttonApplyParameters_Click);
            // 
            // buttonClearTrail
            // 
            this.buttonClearTrail.Location = new System.Drawing.Point(800, 70);
            this.buttonClearTrail.Name = "buttonClearTrail";
            this.buttonClearTrail.Size = new System.Drawing.Size(100, 30);
            this.buttonClearTrail.TabIndex = 0;
            this.buttonClearTrail.Text = "清除轨迹";
            this.buttonClearTrail.UseVisualStyleBackColor = true;
            this.buttonClearTrail.Click += new System.EventHandler(this.buttonClearTrail_Click);
            // 
            // labelChannel1
            // 
            this.labelChannel1.Location = new System.Drawing.Point(20, 60);
            this.labelChannel1.Name = "labelChannel1";
            this.labelChannel1.Size = new System.Drawing.Size(200, 23);
            this.labelChannel1.TabIndex = 0;
            this.labelChannel1.Text = "通道1数据: --";
            // 
            // labelChannel2
            // 
            this.labelChannel2.Location = new System.Drawing.Point(20, 90);
            this.labelChannel2.Name = "labelChannel2";
            this.labelChannel2.Size = new System.Drawing.Size(200, 23);
            this.labelChannel2.TabIndex = 0;
            this.labelChannel2.Text = "通道2数据: --";
            // 
            // textBoxLog
            // 
            this.textBoxLog.Location = new System.Drawing.Point(20, 700);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLog.Size = new System.Drawing.Size(940, 60);
            this.textBoxLog.TabIndex = 0;
            this.textBoxLog.Text = "日志信息将显示在这里...";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(984, 781);
            this.Controls.Add(this.groupBoxConnection);
            this.Controls.Add(this.groupBoxParameters);
            this.Controls.Add(this.chart2DPlane);
            this.Controls.Add(this.textBoxLog);
            this.Name = "MainForm";
            this.Text = "EEG 2D 可视化工具";
            ((System.ComponentModel.ISupportInitialize)(this.chart2DPlane)).EndInit();
            this.groupBoxConnection.ResumeLayout(false);
            this.groupBoxParameters.ResumeLayout(false);
            this.groupBoxParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericXMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericXMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericYMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericYMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPlaneWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPlaneHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSmooth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // 控件声明
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2DPlane;
        private System.Windows.Forms.GroupBox groupBoxConnection;
        private System.Windows.Forms.Button buttonScan;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.ComboBox comboBoxDevices;
        private System.Windows.Forms.Label labelConnectionStatus;
        private System.Windows.Forms.GroupBox groupBoxParameters;
        private System.Windows.Forms.Button buttonApplyParameters;
        private System.Windows.Forms.TrackBar trackBarSmooth;
        private System.Windows.Forms.NumericUpDown numericPlaneHeight;
        private System.Windows.Forms.NumericUpDown numericPlaneWidth;
        private System.Windows.Forms.NumericUpDown numericYMax;
        private System.Windows.Forms.NumericUpDown numericYMin;
        private System.Windows.Forms.NumericUpDown numericXMax;
        private System.Windows.Forms.NumericUpDown numericXMin;
        private System.Windows.Forms.Label labelChannel1;
        private System.Windows.Forms.Label labelChannel2;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.Button buttonClearTrail;
        private System.Windows.Forms.Label labelXMin;
        private System.Windows.Forms.Label labelXMax;
        private System.Windows.Forms.Label labelYMin;
        private System.Windows.Forms.Label labelYMax;
        private System.Windows.Forms.Label labelPlaneWidth;
        private System.Windows.Forms.Label labelPlaneHeight;
        private System.Windows.Forms.Label labelSmooth;
    }
}