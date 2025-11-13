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
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            // 2D可视化图表
            this.chart2DPlane = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart2DPlane)).BeginInit();

            // 设备连接区域
            this.groupBoxConnection = new System.Windows.Forms.GroupBox();
            this.buttonScan = new System.Windows.Forms.Button();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.comboBoxDevices = new System.Windows.Forms.ComboBox();
            this.labelConnectionStatus = new System.Windows.Forms.Label();

            // 参数设置区域
            this.groupBoxParameters = new System.Windows.Forms.GroupBox();
            this.buttonApplyParameters = new System.Windows.Forms.Button();
            this.trackBarSmooth = new System.Windows.Forms.TrackBar();
            this.numericPlaneHeight = new System.Windows.Forms.NumericUpDown();
            this.numericPlaneWidth = new System.Windows.Forms.NumericUpDown();
            this.numericYMax = new System.Windows.Forms.NumericUpDown();
            this.numericYMin = new System.Windows.Forms.NumericUpDown();
            this.numericXMax = new System.Windows.Forms.NumericUpDown();
            this.numericXMin = new System.Windows.Forms.NumericUpDown();
            this.buttonClearTrail = new System.Windows.Forms.Button();

            // 数据显示区域
            this.labelChannel1 = new System.Windows.Forms.Label();
            this.labelChannel2 = new System.Windows.Forms.Label();
            this.textBoxLog = new System.Windows.Forms.TextBox();

            // 设置控件属性和布局（此处省略的代码需保留原逻辑）
            // ...

            ((System.ComponentModel.ISupportInitialize)(this.chart2DPlane)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSmooth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPlaneHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPlaneWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericYMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericYMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericXMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericXMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        // 控件声明（移至类内部）
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
    }
}