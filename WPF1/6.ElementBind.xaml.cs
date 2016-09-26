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
    /// _6.xaml 的交互逻辑
    /// </summary>
    public partial class ElementBind : Window
    {
        public ElementBind()
        {
            InitializeComponent();
        }
        // 用这个顺便联系一下布局容器

        private void cmd_SetSmall(object sender, RoutedEventArgs e)
        {
            // 在元素绑定之后，不应该用下面这种形式
            // 应直接修改数据源，而不应该修改绑定的元素
            // 可见，源本身的修改并不受限制，改动后会自动通知所有绑定它的元素
            //lblSampleText.FontSize = xxx
            sliderFontSize.Value = (sliderFontSize.Minimum+sliderFontSize.Maximum)/5;
        }

        private void cmd_SetNormal(object sender, RoutedEventArgs e)
        {
            sliderFontSize.Value = (sliderFontSize.Minimum + sliderFontSize.Maximum) / 2;
        }

        private void cmd_SetLarge(object sender, RoutedEventArgs e)
        {
            sliderFontSize.Value = (sliderFontSize.Minimum + sliderFontSize.Maximum) / 5 * 4;
        }

    }
}
