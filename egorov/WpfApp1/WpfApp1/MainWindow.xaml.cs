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

namespace WpfApp1
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

     

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();

            // Открываем новое окно

            window1.Show();

            // Закрываем текущее окно, если нужно

            this.Close(); 
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Window2 window2 = new Window2();

            // Открываем новое окно

            window2.Show();

            // Закрываем текущее окно, если нужно

             this.Close(); 
        }
    }
}
