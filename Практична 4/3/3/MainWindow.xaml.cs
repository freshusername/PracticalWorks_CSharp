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
            if (ClndrCalendar.SelectedDate.HasValue && txtName.Text != "" && txtNarada.Text != "")
            {
                //ClndrCalendar.SelectedDate.Value.

                ObjectStructure structure = new ObjectStructure();
                structure.Add(new User1(txtName.Text, txtNarada.Text, txtDate.Text) as AbstractElement);
                structure.Accept(new CalendarVisitor() as AbstractVisitor);
                ListBoxItem itm = new ListBoxItem();
                User1 user1 = new User1(txtName.Text, txtNarada.Text, txtDate.Text);
                
                if (user1.IsTaken == false)
                {
                    itm.Content = new CalendarVisitor().VisitUser1(user1 as AbstractElement);
                    LstBxUSers.Items.Insert(0, itm);
                }
                else
                {
                    MessageBox.Show("This date is taken!");
                }

            }
            else { MessageBox.Show("Fill all textboxes please!"); }
        }

        private void ClndrCalendar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            txtDate.Text = ClndrCalendar.SelectedDate.Value.ToString("dd/MM/yyyy");
        }

        private void usual_Click(object sender, RoutedEventArgs e)
        {
            txtNarada.Text = usual.Content.ToString();
        }
        private void express_Click(object sender, RoutedEventArgs e)
        {
            txtNarada.Text = express.Content.ToString();
        }
        private void normal_Click(object sender, RoutedEventArgs e)
        {
            txtNarada.Text = normal.Content.ToString();
        }
    }
}
