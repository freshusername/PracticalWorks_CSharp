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

namespace ObserverPattern_DAIposts
{
    /// <summary>
    /// Логика взаимодействия для PolicePostWindow.xaml
    /// </summary>
    public partial class PolicePostWindow : Window
    {
        public PolicePostWindow(string str)
        {
            InitializeComponent();
            this.txtToFill.Text = str;
        }
    }
}
