namespace ScopeExample
{
    partial class 示波器
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.DataBox = new System.Windows.Forms.RichTextBox();
            this.SendDataBox = new System.Windows.Forms.RichTextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.UsartBox = new System.Windows.Forms.ComboBox();
            this.串口开关 = new System.Windows.Forms.Button();
            this.串口选择 = new System.Windows.Forms.Label();
            this.波特率 = new System.Windows.Forms.Label();
            this.波特率box = new System.Windows.Forms.ComboBox();
            this.停止位 = new System.Windows.Forms.Label();
            this.停止位box = new System.Windows.Forms.ComboBox();
            this.数据位 = new System.Windows.Forms.Label();
            this.数据位box = new System.Windows.Forms.ComboBox();
            this.奇偶校验 = new System.Windows.Forms.Label();
            this.奇偶校验box = new System.Windows.Forms.ComboBox();
            this.清除接收 = new System.Windows.Forms.Button();
            this.曲线条数 = new System.Windows.Forms.Label();
            this.曲线条数box = new System.Windows.Forms.ComboBox();
            this.TimeReadCom = new System.Windows.Forms.Timer(this.components);
            this.帮助 = new System.Windows.Forms.Button();
            this.scope = new System.Windows.Forms.Integration.ElementHost();
            this.scopeShow1 = new ScopeExample.ScopeShow();
            this.SuspendLayout();
            // 
            // elementHost1
            // 
            this.elementHost1.Location = new System.Drawing.Point(0, 1);
            this.elementHost1.Margin = new System.Windows.Forms.Padding(2);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(504, 511);
            this.elementHost1.TabIndex = 0;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = null;
            // 
            // DataBox
            // 
            this.DataBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.DataBox.ForeColor = System.Drawing.Color.FloralWhite;
            this.DataBox.Location = new System.Drawing.Point(608, 0);
            this.DataBox.Name = "DataBox";
            this.DataBox.Size = new System.Drawing.Size(424, 352);
            this.DataBox.TabIndex = 5;
            this.DataBox.Text = "";
            this.DataBox.TextChanged += new System.EventHandler(this.DataBox_TextChanged);
            // 
            // SendDataBox
            // 
            this.SendDataBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SendDataBox.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.SendDataBox.Location = new System.Drawing.Point(608, 384);
            this.SendDataBox.Name = "SendDataBox";
            this.SendDataBox.Size = new System.Drawing.Size(424, 72);
            this.SendDataBox.TabIndex = 6;
            this.SendDataBox.Text = "";
            // 
            // SendButton
            // 
            this.SendButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SendButton.Location = new System.Drawing.Point(936, 464);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(88, 32);
            this.SendButton.TabIndex = 7;
            this.SendButton.Text = "发送";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // UsartBox
            // 
            this.UsartBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UsartBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UsartBox.FormattingEnabled = true;
            this.UsartBox.Location = new System.Drawing.Point(520, 40);
            this.UsartBox.Name = "UsartBox";
            this.UsartBox.Size = new System.Drawing.Size(72, 20);
            this.UsartBox.TabIndex = 16;
            this.UsartBox.DropDown += new System.EventHandler(this.UsartBox_DropDown);
            // 
            // 串口开关
            // 
            this.串口开关.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.串口开关.Location = new System.Drawing.Point(520, 368);
            this.串口开关.Name = "串口开关";
            this.串口开关.Size = new System.Drawing.Size(75, 23);
            this.串口开关.TabIndex = 17;
            this.串口开关.Text = "打开串口";
            this.串口开关.UseVisualStyleBackColor = true;
            this.串口开关.Click += new System.EventHandler(this.串口开关_Click);
            // 
            // 串口选择
            // 
            this.串口选择.AutoSize = true;
            this.串口选择.Location = new System.Drawing.Point(512, 16);
            this.串口选择.Name = "串口选择";
            this.串口选择.Size = new System.Drawing.Size(65, 12);
            this.串口选择.TabIndex = 18;
            this.串口选择.Text = "串口选择：";
            // 
            // 波特率
            // 
            this.波特率.AutoSize = true;
            this.波特率.Location = new System.Drawing.Point(512, 72);
            this.波特率.Name = "波特率";
            this.波特率.Size = new System.Drawing.Size(53, 12);
            this.波特率.TabIndex = 19;
            this.波特率.Text = "波特率：";
            // 
            // 波特率box
            // 
            this.波特率box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.波特率box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.波特率box.FormattingEnabled = true;
            this.波特率box.Items.AddRange(new object[] {
            "1382400",
            "921600",
            "460800",
            "256000",
            "230400",
            "128000",
            "115200",
            "76800",
            "57600",
            "43000",
            "38400",
            "19200",
            "14400",
            "9600",
            "4800",
            "2400",
            "1200"});
            this.波特率box.Location = new System.Drawing.Point(520, 96);
            this.波特率box.Name = "波特率box";
            this.波特率box.Size = new System.Drawing.Size(72, 20);
            this.波特率box.TabIndex = 20;
            // 
            // 停止位
            // 
            this.停止位.AutoSize = true;
            this.停止位.Location = new System.Drawing.Point(512, 128);
            this.停止位.Name = "停止位";
            this.停止位.Size = new System.Drawing.Size(53, 12);
            this.停止位.TabIndex = 21;
            this.停止位.Text = "停止位：";
            // 
            // 停止位box
            // 
            this.停止位box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.停止位box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.停止位box.FormattingEnabled = true;
            this.停止位box.Items.AddRange(new object[] {
            "2",
            "1.5",
            "1"});
            this.停止位box.Location = new System.Drawing.Point(520, 152);
            this.停止位box.Name = "停止位box";
            this.停止位box.Size = new System.Drawing.Size(72, 20);
            this.停止位box.TabIndex = 22;
            // 
            // 数据位
            // 
            this.数据位.AutoSize = true;
            this.数据位.Location = new System.Drawing.Point(512, 184);
            this.数据位.Name = "数据位";
            this.数据位.Size = new System.Drawing.Size(53, 12);
            this.数据位.TabIndex = 23;
            this.数据位.Text = "数据位：";
            // 
            // 数据位box
            // 
            this.数据位box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.数据位box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.数据位box.FormattingEnabled = true;
            this.数据位box.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.数据位box.Location = new System.Drawing.Point(520, 208);
            this.数据位box.Name = "数据位box";
            this.数据位box.Size = new System.Drawing.Size(72, 20);
            this.数据位box.TabIndex = 24;
            // 
            // 奇偶校验
            // 
            this.奇偶校验.AutoSize = true;
            this.奇偶校验.Location = new System.Drawing.Point(512, 240);
            this.奇偶校验.Name = "奇偶校验";
            this.奇偶校验.Size = new System.Drawing.Size(65, 12);
            this.奇偶校验.TabIndex = 25;
            this.奇偶校验.Text = "奇偶校验：";
            // 
            // 奇偶校验box
            // 
            this.奇偶校验box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.奇偶校验box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.奇偶校验box.FormattingEnabled = true;
            this.奇偶校验box.Items.AddRange(new object[] {
            "无",
            "奇校验",
            "偶校验"});
            this.奇偶校验box.Location = new System.Drawing.Point(520, 264);
            this.奇偶校验box.Name = "奇偶校验box";
            this.奇偶校验box.Size = new System.Drawing.Size(72, 20);
            this.奇偶校验box.TabIndex = 26;
            // 
            // 清除接收
            // 
            this.清除接收.Location = new System.Drawing.Point(616, 464);
            this.清除接收.Name = "清除接收";
            this.清除接收.Size = new System.Drawing.Size(80, 31);
            this.清除接收.TabIndex = 27;
            this.清除接收.Text = "清除接收";
            this.清除接收.UseVisualStyleBackColor = true;
            this.清除接收.Click += new System.EventHandler(this.清除接收_Click);
            // 
            // 曲线条数
            // 
            this.曲线条数.AutoSize = true;
            this.曲线条数.Location = new System.Drawing.Point(512, 296);
            this.曲线条数.Name = "曲线条数";
            this.曲线条数.Size = new System.Drawing.Size(65, 12);
            this.曲线条数.TabIndex = 29;
            this.曲线条数.Text = "曲线条数：";
            // 
            // 曲线条数box
            // 
            this.曲线条数box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.曲线条数box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.曲线条数box.FormattingEnabled = true;
            this.曲线条数box.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.曲线条数box.Location = new System.Drawing.Point(520, 320);
            this.曲线条数box.Name = "曲线条数box";
            this.曲线条数box.Size = new System.Drawing.Size(72, 20);
            this.曲线条数box.TabIndex = 30;
            // 
            // TimeReadCom
            // 
            this.TimeReadCom.Enabled = true;
            this.TimeReadCom.Interval = 10;
            this.TimeReadCom.Tick += new System.EventHandler(this.TimeReadCom_Tick);
            // 
            // 帮助
            // 
            this.帮助.Location = new System.Drawing.Point(520, 432);
            this.帮助.Name = "帮助";
            this.帮助.Size = new System.Drawing.Size(75, 23);
            this.帮助.TabIndex = 31;
            this.帮助.Text = "帮助";
            this.帮助.UseVisualStyleBackColor = true;
            this.帮助.Click += new System.EventHandler(this.帮助_Click);
            // 
            // scope
            // 
            this.scope.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scope.Location = new System.Drawing.Point(0, 1);
            this.scope.Margin = new System.Windows.Forms.Padding(2);
            this.scope.Name = "scope";
            this.scope.Size = new System.Drawing.Size(504, 503);
            this.scope.TabIndex = 1;
            this.scope.Text = "elementHost2";
            this.scope.Child = this.scopeShow1;
            // 
            // 示波器
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1037, 505);
            this.Controls.Add(this.帮助);
            this.Controls.Add(this.曲线条数box);
            this.Controls.Add(this.曲线条数);
            this.Controls.Add(this.清除接收);
            this.Controls.Add(this.奇偶校验box);
            this.Controls.Add(this.奇偶校验);
            this.Controls.Add(this.数据位box);
            this.Controls.Add(this.数据位);
            this.Controls.Add(this.停止位box);
            this.Controls.Add(this.停止位);
            this.Controls.Add(this.波特率box);
            this.Controls.Add(this.波特率);
            this.Controls.Add(this.串口选择);
            this.Controls.Add(this.串口开关);
            this.Controls.Add(this.UsartBox);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.SendDataBox);
            this.Controls.Add(this.DataBox);
            this.Controls.Add(this.scope);
            this.Controls.Add(this.elementHost1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "示波器";
            this.Text = "XP示波器&串口调试助手";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private System.Windows.Forms.Integration.ElementHost scope;
        private ScopeShow scopeShow1;
        private System.Windows.Forms.RichTextBox DataBox;
        private System.Windows.Forms.RichTextBox SendDataBox;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.ComboBox UsartBox;
        private System.Windows.Forms.Button 串口开关;
        private System.Windows.Forms.Label 串口选择;
        private System.Windows.Forms.Label 波特率;
        private System.Windows.Forms.ComboBox 波特率box;
        private System.Windows.Forms.Label 停止位;
        private System.Windows.Forms.ComboBox 停止位box;
        private System.Windows.Forms.Label 数据位;
        private System.Windows.Forms.ComboBox 数据位box;
        private System.Windows.Forms.Label 奇偶校验;
        private System.Windows.Forms.ComboBox 奇偶校验box;
        private System.Windows.Forms.Button 清除接收;
        private System.Windows.Forms.Label 曲线条数;
        private System.Windows.Forms.ComboBox 曲线条数box;
        public System.Windows.Forms.Timer TimeReadCom;
        private System.Windows.Forms.Button 帮助;
    }
}

