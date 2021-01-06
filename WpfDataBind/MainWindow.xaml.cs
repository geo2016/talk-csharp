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
using System.Data;

namespace WpfDataBind
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Animal _animal;

        DataTable _dt1;
        Random _r1;

        public MainWindow()
        {
            InitializeComponent();

            _animal = Resources["animal"] as Animal;

            // 初始化数据
            _dt1 = new DataTable();
            DataColumn[] arrCols =
            {
                new DataColumn("disp"),
                new DataColumn("count"),
            };
            _dt1.Columns.AddRange(arrCols);


            // fill data
            _r1 = new Random();
            int loop = 0;
            while (loop<10)
            {
                RecordAdd();

                loop++;
            }

            // 绑定控件
            listView1.DataContext = _dt1;
            listView1.SetBinding(ListView.ItemsSourceProperty, new Binding());
        }

        private void RecordAdd()
        {
            DataRow dr1 = _dt1.NewRow();
            dr1[0] = $"Dog {_r1.Next(1, 100)}";
            dr1[1] = _r1.Next(1, 10);
            _dt1.Rows.Add(dr1);
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            //tb1.Text = "ddd";

            _animal.Disp = "Dog";

            // 更改列表值
            //_dt1.Rows[1][0] = "Elephont";

            // 新增一条记录
            RecordAdd();
        }
    }
}
