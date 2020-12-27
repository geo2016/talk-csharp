using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;


namespace WpfAppPicLotGame
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer _timer1 = new DispatcherTimer();
        // 定义一个图案的字符串列表
        List<string> _pics = new List<string>()
            {
                "🚑","🚒",
                "🚚","🚛",
                "🚝","🚊",
                "🚔","🚡",
                "🚂","🚙",
                "🛴","🚎",
                "🚗","🚒",
                "🚑","🚲"
            };

        public MainWindow()
        {
            InitializeComponent();

            SetupGame();
        }

        /// <summary>
        /// 创建游戏
        /// </summary>
        private void SetupGame()
        {
            // 随机显示到格子
            DisplayLot();

            // 设定定时器属性
            _timer1.Interval = TimeSpan.FromSeconds(.2);
            _timer1.Tick += timer1_Tick;

            //_timer1.Start();
        }

        private void DisplayLot()
        {
            Random r1 = new Random();
            foreach (TextBlock tb1 in grid1.Children.OfType<TextBlock>())
            {
                int picIndex = r1.Next(_pics.Count);

                tb1.Text = _pics[picIndex];
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DisplayLot();
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            _timer1.IsEnabled = !_timer1.IsEnabled;

            btnStart.Content = _timer1.IsEnabled ? "停止" : "开始";
        }
    }
}
