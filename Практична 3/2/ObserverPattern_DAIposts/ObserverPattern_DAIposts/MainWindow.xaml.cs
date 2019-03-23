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

namespace ObserverPattern_DAIposts
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string str, str1, str2, str3, str4;

        public MainWindow()
        {
            InitializeComponent();


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            txtSpeed.Text = rnd.Next(20, 100).ToString();
            if (int.Parse(txtSpeed.Text) < 50)
            {
                btnNotify.IsEnabled = false;
            }
            else { btnNotify.IsEnabled = true; }
            
        }

        private void btnNotify_Click(object sender, RoutedEventArgs e)
        {

            if (chBxPost1.IsChecked == true && chBxPost2.IsChecked == true && chBxPost3.IsChecked == true && chBxPost4.IsChecked == true)
            {

                Subject_MainPolicePost subject_MainPolicePost = new Subject_MainPolicePost();

                IObserver observer1 = new Observer_DAI_post("Post 1");
                subject_MainPolicePost.AddObserver(observer1);
                IObserver observer2 = new Observer_DAI_post("Post 2");
                subject_MainPolicePost.AddObserver(observer2);
                IObserver observer3 = new Observer_DAI_post("Post 3");
                subject_MainPolicePost.AddObserver(observer3);
                IObserver observer4 = new Observer_DAI_post("Post 4");
                subject_MainPolicePost.AddObserver(observer4);

                subject_MainPolicePost.Offender_speed = int.Parse(txtSpeed.Text);

                str = observer1.NotifyAboutOffender() + "\n" + observer2.NotifyAboutOffender() + "\n" + observer3.NotifyAboutOffender() + "\n" + observer4.NotifyAboutOffender();
                str1 = observer1.NotifyAboutOffender();
                str2 =  observer2.NotifyAboutOffender();
                str3 =  observer3.NotifyAboutOffender();
                str4 =  observer4.NotifyAboutOffender();
                MessageBox.Show(str);

            }
        }
       

        private void btnShowPost1_Click(object sender, RoutedEventArgs e)
        {
            PolicePostWindow post1 = new PolicePostWindow(str1);
            post1.Show();
        }

        private void btnShowPost2_Click(object sender, RoutedEventArgs e)
        {
            PolicePostWindow post2 = new PolicePostWindow(str2);
            post2.Show();

        }

        private void btnShowPost3_Click(object sender, RoutedEventArgs e)
        {
            PolicePostWindow post3 = new PolicePostWindow(str3);
            post3.Show();

        }

        private void btnShowPost4_Click(object sender, RoutedEventArgs e)
        {
            PolicePostWindow post4 = new PolicePostWindow(str4);
            post4.Show();

        }
    }
}
