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
using System.Collections.Specialized;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace _2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    ///

    // by implementing the INotifyPropertyChanged, changes to properties
    // will update the listbox on-the-fly
    //public class MyObject : INotifyPropertyChanged
    //{
    //    private string _title;
        
    //    //a property
    //    public string Title
    //    {
    //        get { return _title; }
    //        set
    //        {
    //            if (_title != value)
    //            {
    //                _title = value;
    //                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Title)));
    //            }
    //        }
    //    }
    //    public event PropertyChangedEventHandler PropertyChanged;
    //}
    //public class MyCollection : ObservableCollection<MyObject>
    //{
    //    public void Add(string title)
    //    {
    //        this.Add(new MyObject { Title = title });
    //    }
    //}
    public partial class MainWindow : Window
    {
        //public MyCollection myObjects { get; } = new MyCollection();

        public MainWindow()
        {
            this.DataContext = this;
            InitializeComponent();
        }


        private void btn_AddRobot_Click(object sender, RoutedEventArgs e)
        {
           // //myObjects.Add("Hi there!");

           // //Створюємо директор який керуватиме побудовою
            Director director = new Director();
           // //Створюємо екземпляр абстрактного Білдера(підготовлюємо)
           AbstractBuilder abstractBuilder = null;


            // //Створюємо (Будуємо) перший компютер
            //abstractBuilder = new Computer1Builder();
            //director.Construct(abstractBuilder);
            // ListBoxItem itm = new ListBoxItem();
            // //itm.Content = string.Format($"{abstractBuilder.Computer_Product}");
            // itm.Content = abstractBuilder.computerProduct.ToString();
            // lstBx1.Items.Insert(0, itm);


            if (rbtn_Intel.IsChecked == true && rbtn_Samsung.IsChecked == true && rbtn_None.IsChecked == true)
            {
                //Створюємо (Будуємо) перший компютер
                abstractBuilder = new Computer1Builder();
                director.Construct(abstractBuilder);

                ListBoxItem itm = new ListBoxItem();
                itm.Content = abstractBuilder.computerProduct.ToString();
                lstBx1.Items.Insert(0, itm);

            }
            else if (rbtn_AMD.IsChecked == true && rbtn_LG.IsChecked == true && rbtn_Stereo.IsChecked == true)
            {
                abstractBuilder = new Computer1Builder();
                director.Construct(abstractBuilder);

                ListBoxItem itm = new ListBoxItem();
                itm.Content = abstractBuilder.computerProduct.ToString();
                lstBx2.Items.Insert(0, itm);
            }
            else /*(rbtn_AMD.IsChecked == true && rbtn_Samsung.IsChecked == true && rbtn_Surround.IsChecked == true)*/
            {
                abstractBuilder = new Computer1Builder();
                director.Construct(abstractBuilder);

                ListBoxItem itm = new ListBoxItem();
                itm.Content = abstractBuilder.computerProduct.ToString();
                lstBx3.Items.Insert(0, itm);
            }

        }

        private void btn_StartAssembling1_Click(object sender, RoutedEventArgs e)
        {
            

            //Створюємо директор який керуватиме побудовою
            //Director director = new Director();
            //Створюємо екземпляр абстрактного Білдера(підготовлюємо)
            //AbstractBuilder abstractBuilder = null;

            //Створюємо(Будуємо) перший компютер
            //abstractBuilder = new Computer1Builder();
            //director.Construct(abstractBuilder);
            //ListBoxItem itm = new ListBoxItem();
            //itm.Content = string.Format($"{abstractBuilder.Computer_Product}");
            //itm.Content = abstractBuilder.computerProduct.ToString();
            //lstBx1.Items.Insert(0, itm);

        }
    }
}
