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

namespace _2
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
            Dispetcher_ObjectStructure dispetcher = new Dispetcher_ObjectStructure();
            dispetcher.AddCustomer(new Customer1(txtName.Text, txtDestination.Text) as CustomerElement);
            dispetcher.Accept(new Taxi1() as AbstractTaxi_Visitor);
            ListBoxItem itm = new ListBoxItem();
            Taxi1 x = new Taxi1();
            itm.Content = new Taxi1().VisitCustomer(new Customer1(txtName.Text, txtDestination.Text) as CustomerElement);
            lstBx1.Items.Insert(0, itm);
        }

        //ListBoxItem itm = new ListBoxItem();
        //itm.Content = abstractBuilder.computerProduct.ToString();
        //lstBx3.Items.Insert(0, itm);
    }
}
