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
using Microsoft.Win32;
using System.Drawing;
using System.IO;

namespace TRPO_WPF_4
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

        private void ButWind1_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.ShowDialog();
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        
        private void ButLoad_Click(object sender, RoutedEventArgs e)
        {
            
            OpenFileDialog OpDial = new OpenFileDialog();
            OpDial.Filter = "Images (*.jpg)|*.JPG";
            if (OpDial.ShowDialog() == true)
            {
                
                string fileName = OpDial.FileName;
                BitmapImage bmp = new BitmapImage(new Uri(fileName));
                imgbox.Source = bmp;
            }
        }
    }
}
