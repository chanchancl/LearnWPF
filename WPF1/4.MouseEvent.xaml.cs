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
    /// _4.xaml 的交互逻辑
    /// </summary>
    public partial class MouseEvent : Window
    {
        public MouseEvent()
        {
            InitializeComponent();
        }

        private void Grid_MouseMove(object sender, MouseEventArgs e)
        {
            Point pt = e.GetPosition(this);
            tbText.Text = string.Format("You are at ({0},{1}) in window coordinates.", pt.X, pt.Y);
        }
    }   
}
