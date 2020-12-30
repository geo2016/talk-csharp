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

namespace WpfAppUIControls
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //lblResult.Text = tb1.Text;

            //foreach (RadioButton item in cas1.Children.OfType<RadioButton>())
            //{
            //    if ((bool)item.IsChecked)
            //    {
            //        lblResult.Text = item.Content.ToString();
            //        break;
            //    }
            //}

            //lblResult.Text = (list1.SelectedItem as ListBoxItem).Content.ToString();

            //lblResult.Text = cbo1.Text;

            //lblResult.Text = (bool)chk1.IsChecked ? "选中" : "没有选中";

        }

        private void tb1_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            bool isInputInterger = int.TryParse(e.Text, out int result);
            e.Handled = !isInputInterger;
        }
    }
}
