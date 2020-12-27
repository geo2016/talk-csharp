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
            DisplayLot();

            // 初始化定时器
            _timer1.Interval = TimeSpan.FromSeconds(.2);
            _timer1.Tick += timer1_Tick;
            //_timer1.Start();
        }

        /// <summary>
        /// 显示随机图案到表格
        /// </summary>
        private void DisplayLot()
        {
            Random r1 = new Random();
            foreach (TextBlock tb1 in grid1.Children.OfType<TextBlock>())
            {
                tb1.Text = _pics[r1.Next(_pics.Count)];
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DisplayLot();
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            _timer1.IsEnabled = !_timer1.IsEnabled;

            btnStart.Content = _timer1.IsEnabled ? "停止" : "启动";
        }
    }
}
