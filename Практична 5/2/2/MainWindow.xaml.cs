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

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {

            if (txtPrinter.Text == lazer.Content.ToString() && txtPages.Text != "" || txtPrinter.Text == led.Content.ToString() && txtPages.Text != "" || txtPrinter.Text == inkjet.Content.ToString() && txtPages.Text != "")
            {
                if (txtPrinter.Text == lazer.Content.ToString()) {
                    Context context = new Context(new LazerPrinter());
                    ListBoxItem itm = new ListBoxItem();
                    itm.Content = context.ExcecuteAlgoritm() + txtPages.Text;
                    LstBxUSers.Items.Insert(0, itm);
                }
                else if (txtPrinter.Text == inkjet.Content.ToString()) {
                    Context context = new Context(new InkJetPrinter());
                    ListBoxItem itm = new ListBoxItem();
                    itm.Content = context.ExcecuteAlgoritm() + txtPages.Text;
                    LstBxUSers.Items.Insert(0, itm);
                }
                else
                {
                    Context context = new Context(new LedPrinter());
                    ListBoxItem itm = new ListBoxItem();
                    itm.Content = context.ExcecuteAlgoritm() + txtPages.Text;
                    LstBxUSers.Items.Insert(0, itm);
                }



            }
            else { MessageBox.Show("Wrong Data!"); }
        }

        private void lazer_Click(object sender, RoutedEventArgs e)
        {
            txtPrinter.Text = lazer.Content.ToString();
        }

        private void inkjet_Click(object sender, RoutedEventArgs e)
        {
            txtPrinter.Text = inkjet.Content.ToString();
        }

        private void led_Click(object sender, RoutedEventArgs e)
        {
            txtPrinter.Text = led.Content.ToString();
        }
    }
}
