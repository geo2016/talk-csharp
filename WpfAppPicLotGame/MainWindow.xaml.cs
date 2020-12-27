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

namespace WpfAppPicLotGame
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
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
            // 定义一个图案的字符串列表
            List<string> pics = new List<string>()
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

            // 随机显示到格子
            Random r1 = new Random();
            foreach (TextBlock tb1 in grid1.Children.OfType<TextBlock>())
            {
                int picIndex = r1.Next(pics.Count);

                tb1.Text = pics[picIndex];
            }
        }
    }
}
