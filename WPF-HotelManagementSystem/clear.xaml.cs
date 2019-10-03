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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// clear.xaml 的交互逻辑
    /// </summary>
    public partial class clear : Window
    {
        public clear()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }
        MainWindow main_window = new MainWindow();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            main_window.UpdateRoomStatus(cbClearStatus.Text,Convert.ToInt32(tbClearNum.Text));
            tbClearNum.Clear();
            cbClearStatus.SelectedIndex = 0;
        }
    }
}
