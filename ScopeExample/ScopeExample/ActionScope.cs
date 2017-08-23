using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using System.IO;
using System.IO.Ports;



namespace ScopeExample
{
    public partial class 示波器 : Form
    {
        s_Line g_line1, g_line2, g_line3;

        //声明串口
        private SerialPort Usart = new SerialPort();


        //form初始化
        public 示波器()
        {
            InitializeComponent();
            
            波特率box.Text = "115200";
            停止位box.Text = "1";
            数据位box.Text = "8";
            奇偶校验box.Text = "无";
            曲线条数box.Text = "0";
            清除接收.Enabled = false;
        }




        //串口号选择下拉框
        private void UsartBox_DropDown(object sender, EventArgs e)
        {
            string[] names = SerialPort.GetPortNames();
            UsartBox.Items.Clear();
            for (int i = 0; i < names.Length; i++)
            {
                UsartBox.Items.Add(names[i]);
            }
        }


        //串口开关按键
        private void 串口开关_Click(object sender, EventArgs e)
        {
            if (串口开关.Text == "打开串口")
            {
                if (UsartBox.Text == "")
                {
                    MessageBox.Show("请选择串口！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                波特率box.Text = "115200";
                停止位box.Text = "1";
                数据位box.Text = "8";
                奇偶校验box.Text = "无";
                //串口参数初始化
                Usart.BaudRate = int.Parse(波特率box.Text);
                Usart.DataBits = int.Parse(数据位box.Text);
                //停止位设置
                if (停止位box.Text == "2")
                {
                    Usart.StopBits = System.IO.Ports.StopBits.Two;
                }
                else if(停止位box.Text == "1.5")
                {
                    Usart.StopBits = System.IO.Ports.StopBits.OnePointFive;
                }
                else if (停止位box.Text == "1")
                {
                    Usart.StopBits = System.IO.Ports.StopBits.One;
                }
                //奇偶校验
                if (奇偶校验box.Text == "无")
                {
                    Usart.Parity = System.IO.Ports.Parity.None;
                }
                else if (奇偶校验box.Text == "奇校验")
                {
                    Usart.Parity = System.IO.Ports.Parity.Odd;
                }
                else if (奇偶校验box.Text == "偶校验")
                {
                    Usart.Parity = System.IO.Ports.Parity.Even;
                }


                //添加直线
                LineAdd();

                清除接收.Enabled = true;

                //串口数据接收区大小
                Usart.ReadBufferSize = 4096;



                Usart.PortName = UsartBox.Text;
                if (Usart.IsOpen == false)
                {
                    Usart.Open();
                }
                //关闭串口选择功能
                UsartBox.Enabled = false;

                串口开关.Text = "关闭串口";
            }
            else if (串口开关.Text == "关闭串口")
            {
                Usart.Close();

                //关闭串口选择功能

                UsartBox.Enabled = true;

                串口开关.Text = "打开串口";
            }
        }


        //定时器串口中断
        private void TimeReadCom_Tick(object sender, EventArgs e)
        {
            if (Usart.IsOpen == false) return;
            try
            {
                //记录缓存数量
                int n = Usart.BytesToRead;

                if (n == 0) return;

                //声明一个临时数组来存储当前来的串口数据
                byte[] buf = new byte[n];



                //读取缓冲数据
                Usart.Read(buf, 0, n);

                //丢弃接受缓冲区数据
                Usart.DiscardInBuffer();

                string tempStr = " ";

                this.Invoke((EventHandler)(delegate
                {

                    //将字节全部转换为字符串！
                    tempStr = (Encoding.ASCII.GetString(buf));

                    if (曲线条数box.Text == "1")
                    {
                        OneLineDraw(tempStr);
                    }
                    else if (曲线条数box.Text == "2")
                    {
                        TwoLineDraw(tempStr);
                    }
                    else if (曲线条数box.Text == "3")
                    {
                        ThreeLineDraw(tempStr);
                    }
                    else
                    {
                        DataBox.Text += tempStr;
                    }

                }));


            }
            catch (Exception ex)
            {
                MessageBox.Show(Usart.BytesToRead.ToString() + "接收串口信息错误：" + ex.Message);
            }
        }



        //添加线条
        private void LineAdd()
        {
            if (曲线条数box.Text == "1")
            {
                g_line1 = scopeShow1.AddLine("line1", System.Windows.Media.Brushes.Red, 0, System.Windows.Media.Brushes.Red, 5);
            }
            else if (曲线条数box.Text == "2")
            {
                g_line1 = scopeShow1.AddLine("line1", System.Windows.Media.Brushes.Red, 0, System.Windows.Media.Brushes.Red, 5);
                g_line2 = scopeShow1.AddLine("line2", System.Windows.Media.Brushes.Green, 0, System.Windows.Media.Brushes.Green, 5);
            }
            else if (曲线条数box.Text == "3")
            {
                g_line1 = scopeShow1.AddLine("line1", System.Windows.Media.Brushes.Red, 0, System.Windows.Media.Brushes.Red, 5);
                g_line2 = scopeShow1.AddLine("line2", System.Windows.Media.Brushes.Green, 0, System.Windows.Media.Brushes.Green, 5);
                g_line3 = scopeShow1.AddLine("line3", System.Windows.Media.Brushes.Blue, 0, System.Windows.Media.Brushes.Blue, 5);
            }
        }



        //减少线条
        private void LineDecrese()
        {
            if (曲线条数box.Text == "1")
            {
                scopeShow1.ClearLine(g_line1);
            }
            else if (曲线条数box.Text == "2")
            {
                scopeShow1.ClearLine(g_line1);
                scopeShow1.ClearLine(g_line2);
            }
            else if (曲线条数box.Text == "3")
            {
                scopeShow1.ClearLine(g_line1);
                scopeShow1.ClearLine(g_line2);
                scopeShow1.ClearLine(g_line3);
            }

        }






        private void OneLineDraw(string tempStr)
        {
            try
            {

                DataBox.Text += tempStr;

                string[] sArray = tempStr.Split('\n');

                int count = 0;
                
                for (int i = 0; i < sArray.Length - 1; i++)
                {
                    string[] tempArray = sArray[i].Split('\t');

                    

                    //如果不是两个数据那么结束函数
                    if (tempArray.Count() != 2) return;
                    count++;
                 }

                System.Windows.Point[] pnts = new System.Windows.Point[count];

                count =  0;
                for (int i = 0; i < sArray.Length - 1; i++)
                {
                    string[] tempArray = sArray[i].Split('\t');

                    

                    //如果不是两个数据那么结束函数
                    if (tempArray.Count() != 2) return;

                    pnts[count].X = int.Parse(tempArray[0]);
                    pnts[count].Y = int.Parse(tempArray[1]);
 
                    count++;
                 }
                    scopeShow1.PutPoints(g_line1,pnts);
                

            }
            catch
            {
                return;
            }
        }

        private void TwoLineDraw(string tempStr)
        {
            try
            {

                DataBox.Text += tempStr;

                string[] sArray = tempStr.Split('\n');

                int count = 0;

                for (int i = 0; i < sArray.Length - 1; i++)
                {
                    string[] tempArray = sArray[i].Split('\t');



                    //如果不是两个数据那么结束函数
                    if (tempArray.Count() != 3) return;
                    count++;
                }

                System.Windows.Point[] pnts1 = new System.Windows.Point[count];
                System.Windows.Point[] pnts2 = new System.Windows.Point[count];

                count = 0;
                for (int i = 0; i < sArray.Length - 1; i++)
                {
                    string[] tempArray = sArray[i].Split('\t');



                    //如果不是两个数据那么结束函数
                    if (tempArray.Count() != 3) return;

                    pnts1[count].X = pnts2[count].X = int.Parse(tempArray[0]);
                    pnts1[count].Y = int.Parse(tempArray[1]);
                    pnts2[count].Y = int.Parse(tempArray[2]);

                    count++;
                }
                scopeShow1.PutPoints(g_line1, pnts1);
                scopeShow1.PutPoints(g_line2, pnts2);


            }
            catch
            {
                return;
            }
        }

        private void ThreeLineDraw(string tempStr)
        {
            try
            {

                DataBox.Text += tempStr;

                string[] sArray = tempStr.Split('\n');

                int count = 0;

                for (int i = 0; i < sArray.Length - 1; i++)
                {
                    string[] tempArray = sArray[i].Split('\t');



                    //如果不是两个数据那么结束函数
                    if (tempArray.Count() != 4) return;
                    count++;
                }

                System.Windows.Point[] pnts1 = new System.Windows.Point[count];
                System.Windows.Point[] pnts2 = new System.Windows.Point[count];
                System.Windows.Point[] pnts3 = new System.Windows.Point[count];

                count = 0;
                for (int i = 0; i < sArray.Length - 1; i++)
                {
                    string[] tempArray = sArray[i].Split('\t');



                    //如果不是两个数据那么结束函数
                    if (tempArray.Count() != 4) return;

                    pnts3[count].X = pnts1[count].X = pnts2[count].X = int.Parse(tempArray[0]);
                    pnts1[count].Y = int.Parse(tempArray[1]);
                    pnts2[count].Y = int.Parse(tempArray[2]);
                    pnts2[count].Y = int.Parse(tempArray[3]);

                    count++;
                }
                scopeShow1.PutPoints(g_line1, pnts1);
                scopeShow1.PutPoints(g_line2, pnts2);
                scopeShow1.PutPoints(g_line3, pnts3);

            }
            catch
            {
                return;
            }
        }




        //用于实时显示串口数据，richTxtBox
        private void DataBox_TextChanged(object sender, EventArgs e)
        {
            DataBox.SelectionStart = DataBox.Text.Length;
            DataBox.ScrollToCaret();
        }

        private void 清除接收_Click(object sender, EventArgs e)
        {
            LineDecrese();
            DataBox.Text = "";
            清除接收.Enabled = false;
            Usart.Close();

            //关闭串口选择功能

            UsartBox.Enabled = true;

            串口开关.Text = "打开串口";
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            if (Usart.IsOpen == false)
            {
                MessageBox.Show("请开启串口！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Usart.Write(SendDataBox.Text);
            //延时100ms
            Delay(100);
        }


        //延时函数
        public static void Delay(int milliSecond)
        {
            int start = Environment.TickCount;
            while (Math.Abs(Environment.TickCount - start) < milliSecond)
            {
                Application.DoEvents();
            }
        }

        private void 帮助_Click(object sender, EventArgs e)
        {
            DataBox.Text = "该串口助手支持三个数据通道：\r\n发送格式:\r\n一条曲线:USART_OUT(%d\\t%d\\r\\n,x,y);\r\n两条曲线:USART_OUT(%d\\t%d\\t%d\\r\\n,x,y1,y2);\r\n两条曲线:USART_OUT(%d\\t%d\\t%d\\t%d\\r\\n,x,y1,y2,y3);";
            DataBox.Text += "\r\n\r\n注意发送时需要选择曲线条数，如果发送格式不对应只有右侧tetBox会显示.";
            DataBox.Text += "\r\n\r\n右侧图形显示框有强大功能,在页面中间滚动鼠标滑轮会放大缩小,在横坐标处滚动滑轮，横坐标会放大缩小，同理，纵坐标亦是如此。另外右击显示页面可以有保存页面等功能。";
        }


    }
}
