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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (CheckBoxUI.IsChecked == false)
            {
                

                //this.txtHelp.Text = UsaClient.ViewHelp();
                //lbl1.Content = UsaClient.ViewHelp();


            }
            else
            {
                //AbstractUIFactory usaFactory = new AmericanFactory();
                //Client UsaClient = new Client(usaFactory);

                //Img1.Source = new BitmapImage(new Uri("D:/course 2/c#/Практичні/Практична 1/3/pics/0.jpg"));
                //Img2.Source = new BitmapImage(new Uri("D:/course 2/c#/Практичні/Практична 1/3/pics/2.jpg"));
                //Img3.Source = new BitmapImage(new Uri("D:/course 2/c#/Практичні/Практична 1/3/pics/2.gif"));
                //Img4.Source = new BitmapImage(new Uri("D:/course 2/c#/Практичні/Практична 1/3/pics/3.jpg"));
                //Img5.Source = new BitmapImage(new Uri("D:/course 2/c#/Практичні/Практична 1/3/pics/4.jpg"));
                //this.txtLocale.Text = UsaClient.ViewLocal();

            }
        }

        private void CheckBoxUI_Click(object sender, RoutedEventArgs e)
        {
            //AbstractUIFactory ukrFactory = new UkrainianFactory();
            //Client UkrClient = new Client(ukrFactory);

            //Img1.Source = new BitmapImage(new Uri("D:/course 2/c#/Практичні/Практична 1/3/pics/00.jpg"));
            //Img2.Source = new BitmapImage(new Uri("D:/course 2/c#/Практичні/Практична 1/3/pics/11.jpg"));
            //Img3.Source = new BitmapImage(new Uri("D:/course 2/c#/Практичні/Практична 1/3/pics/22.jpg"));
            //Img4.Source = new BitmapImage(new Uri("D:/course 2/c#/Практичні/Практична 1/3/pics/00.jpg"));
            //Img5.Source = new BitmapImage(new Uri("D:/course 2/c#/Практичні/Практична 1/3/pics/44.jpg"));
            //txtLocale.Text = string.Empty;
            //txtLocale.Text = UkrClient.ViewLocal();
            //lbl1.Content = "  df   ";
            //this.txtLocale.Text = UkrClient.ViewLocal();
        }

        public void usa()
        {
            AbstractUIFactory usaFactory = new AmericanFactory();
            Client UsaClient = new Client(usaFactory);

            Img1.Source = new BitmapImage(new Uri("D:/course 2/c#/Практичні/Практична 1/3/pics/0.jpg"));
            Img2.Source = new BitmapImage(new Uri("D:/course 2/c#/Практичні/Практична 1/3/pics/2.jpg"));
            Img3.Source = new BitmapImage(new Uri("D:/course 2/c#/Практичні/Практична 1/3/pics/2.gif"));
            Img4.Source = new BitmapImage(new Uri("D:/course 2/c#/Практичні/Практична 1/3/pics/3.jpg"));
            Img5.Source = new BitmapImage(new Uri("D:/course 2/c#/Практичні/Практична 1/3/pics/4.jpg"));

            this.txtLocale.Text = UsaClient.ViewLocal();
            lbl1.Content = UsaClient.ViewHelp();
        }

        public void ua()
        {
            AbstractUIFactory ukrFactory = new UkrainianFactory();
            Client UkrClient = new Client(ukrFactory);

            Img1.Source = new BitmapImage(new Uri("D:/course 2/c#/Практичні/Практична 1/3/pics/00.jpg"));
            Img2.Source = new BitmapImage(new Uri("D:/course 2/c#/Практичні/Практична 1/3/pics/11.jpg"));
            Img3.Source = new BitmapImage(new Uri("D:/course 2/c#/Практичні/Практична 1/3/pics/22.jpg"));
            Img4.Source = new BitmapImage(new Uri("D:/course 2/c#/Практичні/Практична 1/3/pics/00.jpg"));
            Img5.Source = new BitmapImage(new Uri("D:/course 2/c#/Практичні/Практична 1/3/pics/44.jpg"));
            //.TextWrapping = "Wrap";
            txtLocale.Text = UkrClient.ViewLocal();
            lbl1.Content = UkrClient.ViewHelp(); ;
        }

        private void CheckBoxUI_Unchecked(object sender, RoutedEventArgs e)
        {
            lbl1.Content = null;
            txtLocale.Text = " ";
            usa();
        }

        private void CheckBoxUI_Checked(object sender, RoutedEventArgs e)
        {
            lbl1.Content = null;
            txtLocale.Text = " ";
            ua();
        }
    }
}
