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
using System.Collections;

namespace Pract10_Eliseev
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
        List<int> mas = new List<int>();

        private void addClick(object sender, RoutedEventArgs e)
        {
            if (Int32.TryParse(numberText.Text,out int number))
            {
                mas.Add(number);
                listbox1.ItemsSource = null;
                listbox1.ItemsSource = mas;
            }
        }

        private void solutionClick(object sender, RoutedEventArgs e)
        {
            int sum = 0;
            int count = 0;
            foreach (int item in mas)
            {
                if (item < 0) 
                {
                    sum += item;
                    count++;
                }
            }
            MessageBox.Show(" " + sum / count);
        }
    }
}
