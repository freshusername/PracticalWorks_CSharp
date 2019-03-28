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
            bool ishot = false, isnearwindow = false;
            if (chBxHot.IsChecked == true)
            {
                ishot = true;
            }
            if (chBxNearWindow.IsChecked == true)
            {
                isnearwindow = true;
            }

            if (txtTypeTicket.Text != "" )
            {
               
                if (txtTypeTicket.Text == econom.Content.ToString())
                {
                    Ticket ticket = new Ticket(txtTypeTicket.Text, isnearwindow, ishot, new EconomClassPrice());
                    //ticket.priceStrategy();
                    ListBoxItem itm = new ListBoxItem();
                    itm.Content = ticket.GetName() + ticket.SetPrice();
                    LstBxUSers.Items.Insert(0, itm);

                }
                else if (txtTypeTicket.Text == biznes.Content.ToString())
                {
                    Ticket ticket = new Ticket(txtTypeTicket.Text, isnearwindow, ishot, new BusinessClassPrice());
                    //ticket.priceStrategy();
                    ListBoxItem itm = new ListBoxItem();
                    itm.Content = ticket.GetName() + ticket.SetPrice();
                    LstBxUSers.Items.Insert(0, itm);
                }
                else if (txtTypeTicket.Text == pershui.Content.ToString())
                {
                    Ticket ticket = new Ticket(txtTypeTicket.Text, isnearwindow, ishot, new PershuiClassPrice());
                    //ticket.priceStrategy();
                    ListBoxItem itm = new ListBoxItem();
                    itm.Content = ticket.GetName() + ticket.SetPrice();
                    LstBxUSers.Items.Insert(0, itm);
                }
                else { MessageBox.Show("Choose type of ticket!"); }
            }
            else { MessageBox.Show("Wrong Data!"); }


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
