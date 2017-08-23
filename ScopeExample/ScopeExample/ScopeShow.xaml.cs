using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.Data.OleDb;
using System.Data;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;

using System.Windows.Threading;
using Microsoft.Research.DynamicDataDisplay;
using Microsoft.Research.DynamicDataDisplay.DataSources;
using Microsoft.Research.DynamicDataDisplay.PointMarkers;
using Microsoft.Research.DynamicDataDisplay.Charts.Navigation;
using System.Diagnostics;


namespace ScopeExample
{
    /// <summary>
    /// ScopeShow.xaml 的交互逻辑
    /// </summary>
    public partial class ScopeShow : UserControl
    {

        public ScopeShow()
        {
            InitializeComponent();
            Plot.Children.Add(new CursorCoordinateGraph());
        }




        /// <summary>
        /// 放入点与集合，并显示
        /// </summary>
        /// <param name="line"></param>
        /// <param name="pnt"></param>
        public void PutPoints(s_Line line,Point[] pnt)
        {
            line.source.AppendMany(pnt);
            
            Plot.FitToView();

        }

        public void PutPoint(s_Line line, Point pnt)
        {
            line.source.AppendAsync(base.Dispatcher, pnt);

            Plot.FitToView();

        }

        /// <summary>
        /// 清楚直线。之后使用需要另外创建
        /// </summary>
        /// <param name="line"></param>
        public void ClearLine(s_Line line)
        {
            //清除线条
            Plot.Children.Remove(line.chart.LineGraph);
            //清除点
            Plot.Children.Remove(line.chart.MarkerGraph);
            
        }


        
        /// <summary>
        /// 创建直线源
        /// </summary>
        /// <param name="name"></param>线条标示
        /// <param name="lineColor"></param>线条颜色 eg: Brushs.red
        /// <param name="lineWidth"></param>线条宽度 
        /// <param name="pointColor"></param>关键点颜色
        /// <param name="pointSize"></param>关键点大小
        /// <returns></returns>
        public s_Line AddLine(string name, SolidColorBrush lineColor, uint lineWidth, SolidColorBrush pointColor, uint pointSize)
        {
           s_Line line = new s_Line(); 

           ObservableDataSource<Point> dataSource = new ObservableDataSource<Point>();

           LineAndMarker<ElementMarkerPointsGraph> chart = new LineAndMarker<ElementMarkerPointsGraph>();
            

           chart = Plot.AddLineGraph(dataSource,
           new Pen(lineColor, lineWidth),
           new CircleElementPointMarker
           {
               Size = pointSize,
               Brush = pointColor,
               Fill = pointColor
           },
           new PenDescription(name));


            line.chart = chart;
            line.source = dataSource;

            return line;
        }

        private void Plot_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }


    }

    public struct s_Line
    {
        public LineAndMarker<ElementMarkerPointsGraph> chart;
        public ObservableDataSource<Point> source;
    }
}
