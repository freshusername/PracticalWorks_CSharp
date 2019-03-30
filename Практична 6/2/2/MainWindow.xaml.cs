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
using System.Windows.Threading;

namespace _2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string s1, s2, s3;
        
        DispatcherTimer timer = null;

        public MainWindow()
        {
            
            InitializeComponent();
            s1 = txtDays.Text;
            s2 = txtTypeOfHotelRoom.Text;
            s3 = txtTypeOfVehicle.Text;

        }



        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            if (txtDays.Text != s1 && txtTypeOfHotelRoom.Text != s2 && txtTypeOfVehicle.Text != s3)
            {
                AbstractTravel travel;
                if (txtTypeOfHotelRoom.Text == lowCost.Content.ToString())
                {
                    travel = new LowCostHotel();

                    //тип дныв
                    if (txtDays.Text == Days14.Content.ToString())
                    {
                        travel = new Days14Decorator(travel);
                    }
                    if (txtDays.Text == Days7.Content.ToString()) 
                    {
                        travel = new Days7Decorator(travel);
                    }
                    if (txtDays.Text == Days21.Content.ToString())
                    {
                        travel = new Days21Decorator(travel);
                    }

                    //Тип транспорта
                    if (txtTypeOfVehicle.Text == Car.Content.ToString())
                    {
                        travel = new CarDecorator(travel);
                    }
                    if (txtTypeOfVehicle.Text == Train.Content.ToString())
                    {
                        travel = new TrainDecorator(travel);
                    }
                    if (txtTypeOfVehicle.Text == Plain.Content.ToString())
                    {
                        travel = new PlainDecorator(travel);
                    }

                    



                    if (chBxHasExcurcions.IsChecked == true)
                    {
                        travel = new ExcurcionsDecorator(travel);
                    }
                    ListBoxItem itm = new ListBoxItem();
                    itm.Content = ShowInfo(travel);
                    LstBxTravels.Items.Insert(0, itm);
                    NotificationWindow popup = new NotificationWindow();
                    popup.Show();
                    timer = new DispatcherTimer();
                    timer.Interval = TimeSpan.FromMilliseconds(1000);
                    //timer.Tick += new EventHandler(timer_Tick);
                    timer.Start();
                    //popup.Hide();
                    //popup.Close();

                }
                else if (txtTypeOfHotelRoom.Text == normalCost.Content.ToString())
                {
                    travel = new NormalCostHotel();
                    //тип дныв
                    if (txtDays.Text == Days14.Content.ToString())
                    {
                        travel = new Days14Decorator(travel);
                    }
                    if (txtDays.Text == Days7.Content.ToString())
                    {
                        travel = new Days7Decorator(travel);
                    }
                    if (txtDays.Text == Days21.Content.ToString())
                    {
                        travel = new Days21Decorator(travel);
                    }

                    //Тип транспорта
                    if (txtTypeOfVehicle.Text == Car.Content.ToString())
                    {
                        travel = new CarDecorator(travel);
                    }
                    else if (txtTypeOfVehicle.Text == Train.Content.ToString())
                    {
                        travel = new TrainDecorator(travel);
                    }
                    else if (txtTypeOfVehicle.Text == Plain.Content.ToString())
                    {
                        travel = new PlainDecorator(travel);
                    }

                    if (chBxHasExcurcions.IsChecked == true)
                    {
                        travel = new ExcurcionsDecorator(travel);
                    }
                    ListBoxItem itm = new ListBoxItem();
                    itm.Content = ShowInfo(travel);
                    LstBxTravels.Items.Insert(0, itm);
                    NotificationWindow popup = new NotificationWindow();
                    popup.Show();
                    timer = new DispatcherTimer();
                    timer.Interval = TimeSpan.FromMilliseconds(1000);
                    //timer.Tick += new EventHandler(timer_Tick);
                    timer.Start();
                    //popup.Hide();
                    //popup.Close();

                }
                else if (txtTypeOfHotelRoom.Text == eliteCost.Content.ToString())
                {
                    travel = new EliteCostHotel();

                    //тип дныв
                    if (txtDays.Text == Days14.Content.ToString())
                    {
                        travel = new Days14Decorator(travel);
                    }
                    if (txtDays.Text == Days7.Content.ToString())
                    {
                        travel = new Days7Decorator(travel);
                    }
                    if (txtDays.Text == Days21.Content.ToString())
                    {
                        travel = new Days21Decorator(travel);
                    }

                    //Тип транспорта
                    if (txtTypeOfVehicle.Text == Car.Content.ToString())
                    {
                        travel = new CarDecorator(travel);
                    }
                    else if (txtTypeOfVehicle.Text == Train.Content.ToString())
                    {
                        travel = new TrainDecorator(travel);
                    }
                    else if (txtTypeOfVehicle.Text == Plain.Content.ToString())
                    {
                        travel = new PlainDecorator(travel);
                    }

                    if (chBxHasExcurcions.IsChecked == true)
                    {
                        travel = new ExcurcionsDecorator(travel);
                    }
                    ListBoxItem itm = new ListBoxItem();
                    itm.Content = ShowInfo(travel);
                    LstBxTravels.Items.Insert(0, itm);
                    NotificationWindow popup = new NotificationWindow();
                    popup.Show();
                    timer = new DispatcherTimer();
                    timer.Interval = TimeSpan.FromMilliseconds(1000);
                    //timer.Tick += new EventHandler(timer_Tick);
                    timer.Start();
                    //popup.Hide();
                    //popup.Close();

                }
            }
            else { MessageBox.Show("Wrong Data!"); }
        }
        

        public string ShowInfo(AbstractTravel parcel)
        {
            return $"Type of travel: {parcel.Name}\nPrice of travel: {parcel.GetCost()} UAH\nDays:{txtDays.Text}\nVehicle: {txtTypeOfVehicle.Text}\n type: {txtTypeOfHotelRoom.Text}";
        }

        private void Car_Click(object sender, RoutedEventArgs e)
        {
            txtTypeOfVehicle.Text = Car.Content.ToString();
        }

        private void Train_Click(object sender, RoutedEventArgs e)
        {
            txtTypeOfVehicle.Text = Train.Content.ToString();
        }

        private void Plain_Click(object sender, RoutedEventArgs e)
        {
            txtTypeOfVehicle.Text = Plain.Content.ToString();
        }

        private void Days7_Click(object sender, RoutedEventArgs e)
        {
            txtDays.Text = Days7.Content.ToString();
        }

        private void Days14_Click(object sender, RoutedEventArgs e)
        {
            txtDays.Text = Days14.Content.ToString();
        }

        private void Days21_Click(object sender, RoutedEventArgs e)
        {
            txtDays.Text = Days21.Content.ToString();
        }

        private void lowCost_Click(object sender, RoutedEventArgs e)
        {
            txtTypeOfHotelRoom.Text = lowCost.Content.ToString();
        }

        private void normalCost_Click(object sender, RoutedEventArgs e)
        {
            txtTypeOfHotelRoom.Text = normalCost.Content.ToString();
        }

        private void eliteCost_Click(object sender, RoutedEventArgs e)
        {
            txtTypeOfHotelRoom.Text = eliteCost.Content.ToString();
        }
    }
}
