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

namespace pract8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        Bus _bus1 = new Bus("", 0);
        Bus _bus2 = new Bus("", 0);

        private void выход_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void FillInformation(Bus something)
        {
            if (InName.Text != string.Empty)
            {
                something.Name = InName.Text;
            }
            if(Int32.TryParse(InCapacity.Text, out int capacity))
            {
                if (capacity < 0)
                {
                    MessageBox.Show("Введите целое положительное число в поле 'Вместимость'");
                }
                else
                {
                    something.BusCapacity = capacity;
                }
            }
            else
            {
                MessageBox.Show("Введите целое положительное число в поле 'Вместимость'");
            }
        }

        private void справка_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("ИСП-31\nПеревезенцева Полина\n\nСоздать интерфейсы - автомобиль, пассажирский транспорт. Создать класс автобус. Класс должен включать конструктор, функцию для формирования строки информации об автобусе. Сравнение производить по вместимости пассажиров.");
        }

        private void transport1_Checked(object sender, RoutedEventArgs e)
        {
            InCapacity.Text = "";
            InName.Text = "";
        }

        private void transport2_Checked(object sender, RoutedEventArgs e)
        {
            InCapacity.Text = "";
            InName.Text = "";
        }
        
       
        private void сравнить_Click(object sender, RoutedEventArgs e)
        {
            switch (_bus1.CompareTo(_bus2))
            {
                case 1: MessageBox.Show("Вместимость первого транспорта больше вместимости второго транспорта"); break;
                case -1: MessageBox.Show("Вместимость второго транспорта больше вместимости первого транспорта"); break;
                case 0: MessageBox.Show("Вместимость первого транспорта равна вместимости второго транспорта"); break;
            }
        }

        private void ChangeParameters_Click(object sender, RoutedEventArgs e)
        {
            if (transport1.IsChecked == true)
            {
                FillInformation(_bus1);
            }

            if (transport2.IsChecked == true)
            {
                FillInformation(_bus2);
            }
            TextBox.Text = _bus1.ShowInformation() + "\n\n" + _bus2.ShowInformation();
        }

        private void Out_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text = _bus1.ShowInformation() + "\n\n" + _bus2.ShowInformation();
        }

        private void копировать_Click(object sender, RoutedEventArgs e)
        {
            _bus2 = _bus1.ShallowClone();
            TextBox.Text = _bus1.ShowInformation() + "\n\n" + _bus2.ShowInformation();
        }
    }
}
