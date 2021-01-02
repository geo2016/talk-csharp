using System;
using System.Collections.Generic;
using System.IO;
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

namespace WpfAppYearLot
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        Lot _lot;
        int _giftCount;

        public MainWindow()
        {
            InitializeComponent();

            // 初始化抽奖对象
            _lot = new Lot();

            // 从程序所在文件夹读取奖品列表
            string pathApp = AppDomain.CurrentDomain.BaseDirectory;
            string fileDataGift = pathApp + "gifts.txt";
            if (File.Exists(fileDataGift))
            {
                string[] arr1 = File.ReadAllLines(fileDataGift);
                _lot.GiftForLot = new List<string>(arr1);
            }

            _giftCount = _lot.GiftForLot.Count;
        }

        private void btnStartLot_Click(object sender, RoutedEventArgs e)
        {
            if(int.TryParse(tbTimesLot.Text,out int iTimesLot))
            {
                if(iTimesLot<1 || iTimesLot > _giftCount)
                {
                    MessageBox.Show("抽奖次数不能小于1或大于奖品数量。");
                    tbTimesLot.Focus();
                    return;
                }

                // 开始抽奖
                listResult.Items.Clear();

                foreach (var item in _lot.LotIt(iTimesLot))
                {
                    listResult.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("抽奖次数输入无效。");
            }
        }
    }
}
