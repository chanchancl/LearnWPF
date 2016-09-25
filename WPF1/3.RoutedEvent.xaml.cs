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

namespace WPF1
{
    /// <summary>
    /// 3.RoutedEvent.xaml 的交互逻辑
    /// </summary>
    public partial class RoutedEvent : Window
    {
        public RoutedEvent()
        {
            InitializeComponent();
        }

        private void cmdClear_Click(object sender, RoutedEventArgs e)
        {
            lstMessage.Items.Clear();
            eventCount = 0;
        }

        protected int eventCount = 0;
        private void SomethingClicked(object sender, MouseButtonEventArgs e)
        {
            eventCount++;
            string message = "#" + eventCount.ToString() + ":\r\n" +
                " Sender: " + sender.ToString() + "\r\n" +
                " Source: " + e.Source + "\r\n" +
                " Original Source: " + e.OriginalSource;
            lstMessage.Items.Add(message);
            e.Handled = (bool)chkHandle.IsChecked;
        }
    }
}
