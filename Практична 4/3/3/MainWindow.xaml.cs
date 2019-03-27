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

namespace _3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            CalendarList list = new CalendarList();
            list.Add(new CalendarMonth() { CurrentDate = DateTime.Parse("1.1.1979") });
            list.Add(new CalendarMonth() { CurrentDate = DateTime.Parse("1.2.1979") });
            list.Add(new CalendarMonth() { CurrentDate = DateTime.Parse("1.3.1979") });

            LstBxUSers.ItemsSource = list;


        }
    }
    public class MyCalendar : Calendar
    {
        public MyCalendar()
        {
            this.ClearValue(DisplayDateProperty);
        }
    }
}
