﻿using System;
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

namespace _1
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

        private void Kyiv_Click(object sender, RoutedEventArgs e)
        {
            txtFromCity.Text = Kyiv.Content.ToString();
        }

        private void Vynnitsia_Click(object sender, RoutedEventArgs e)
        {
            txtFromCity.Text = Vynnitsia.Content.ToString();
        }

        private void Chernivtsi_Click(object sender, RoutedEventArgs e)
        {
            txtFromCity.Text = Chernivtsi.Content.ToString();
        }

        private void Odessa_Click(object sender, RoutedEventArgs e)
        {
            txtToCity.Text = Odessa.Content.ToString();
        }

        private void Zhytomir_Click(object sender, RoutedEventArgs e)
        {
            txtToCity.Text = Zhytomir.Content.ToString();
        }

        private void Khmelnytskyi_Click(object sender, RoutedEventArgs e)
        {
            txtToCity.Text = Khmelnytskyi.Content.ToString();
        }

        private void extra_Click(object sender, RoutedEventArgs e)
        {
            txtTypeOfParcel.Text = extra.Content.ToString();
        }

        private void elite_Click(object sender, RoutedEventArgs e)
        {
            txtTypeOfParcel.Text = elite.Content.ToString();
        }

        private void normal_Click_1(object sender, RoutedEventArgs e)
        {
            txtTypeOfParcel.Text = normal.Content.ToString();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            if (txtFromCity.Text != "" && txtToCity.Text != "" && txtTypeOfParcel.Text != "" && txtPrice.Text != "")
            {
                if (txtTypeOfParcel.Text == "Extra Class")
                {
                    AbstractParcel parcel1 = new ExtraParcel();
                    parcel1 = new InsuranceParcelDecorator(parcel1);//посилка зы страховкою

                    ListBoxItem itm = new ListBoxItem();
                    itm.Content = ShowInfo(parcel1);
                    LstBxParcels.Items.Insert(0, itm);
                }
            }
            else { MessageBox.Show("Wrong Data!"); }
        }
        public string ShowInfo(AbstractParcel parcel)
        {
            return $"Type of parcel: {parcel.Name}\nPrice of parcel: {parcel.GetCost()} UAH\nFrom:{txtFromCity.Text} => To: {txtToCity.Text}";
        }

    }
}
