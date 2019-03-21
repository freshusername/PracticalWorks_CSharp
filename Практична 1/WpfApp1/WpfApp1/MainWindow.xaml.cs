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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            txtHeight.Text = string.Empty;
            txtWidth.Text = string.Empty;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //Window1 window1 = new Window1();
            Client client = null;

            client = new Client(new ButtonFactory());
            client.Run(txtWidth.Text, txtHeight.Text);

            System.Windows.Controls.Button newBtn = new Button();
            newBtn.Content = "Button1";
            newBtn.Name = "Button1";// + i.ToString();
            newBtn.Width = Convert.ToDouble(txtWidth.Text);
            newBtn.Height = Convert.ToDouble(txtHeight.Text);

            this.sp1.Children.Add(newBtn);

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
        }
    }
}
