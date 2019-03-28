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
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void econom_Click(object sender, RoutedEventArgs e)
        {
            txtTypeTicket.Text = econom.Content.ToString();
        }

        private void bizness_Click(object sender, RoutedEventArgs e)
        {
            txtTypeTicket.Text = biznes.Content.ToString();
        }

        private void pershui_Click(object sender, RoutedEventArgs e)
        {
            txtTypeTicket.Text = pershui.Content.ToString();
        }
    }
}
