using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Runtime.CompilerServices;
using System.ComponentModel;

namespace WPF1
{
    /// <summary>
    /// TestListView.xaml 的交互逻辑
    /// </summary>
    public partial class TestListView : Window
    {
        class Student 
        {
            public Student(int num,string n)
            {
                number = num;
                name = n;
                score = 0;
            }
            public int number { set; get; }
            public string name { set; get; }
            public int score  { set; get; }

        }

        ObservableCollection<Student> bindingData = 
            new ObservableCollection<Student>();

        Dictionary<int, Student> map = new Dictionary<int, Student>();

        public TestListView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bindingData[0].number = 5;
            listview.ItemsSource = null;
            listview.ItemsSource = bindingData;
            // 日，原来刷新列表这么简单，先设置null，然后再回复。
            // 可以，这很午时。

            var collection = GridView.GetColumnCollection(listview);


            Student stu = new Student(77, "233小明");
            map[77] = stu;
            bindingData.Add(stu);
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Student stu = new Student(1, "小明");
            map[1] = stu;
            bindingData.Add(stu);

            stu = new Student(2, "张华");
            bindingData.Add(stu);
            map[2] = stu;

            stu = new Student(3, "王鹏");
            bindingData.Add(stu);
            map[3] = stu;

            listview.ItemsSource = bindingData;
            
        }
    }
}
