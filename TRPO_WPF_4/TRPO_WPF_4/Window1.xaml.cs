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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            string[] images = { "Изображение 1", "Изображение 2" };
            list.ItemsSource = images;
            
        }

        private void list_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            BitmapImage bit = new BitmapImage();
            switch (list.SelectedIndex)
            {
                case 0:
                    bit = new BitmapImage(new Uri("/Resources/1.png", UriKind.Relative));
                    ImgBox.Source = bit;
                    break;
                case 1:
                    bit = new BitmapImage(new Uri("/Resources/2.png", UriKind.Relative));
                    ImgBox.Source = bit;
                    break;
            }
            
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            PngBitmapEncoder bit = new PngBitmapEncoder();
            bit.Frames.Add(BitmapFrame.Create((BitmapSource)ImgBox.Source));
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "Image";
            sfd.DefaultExt = ".jpg";
            if(sfd.ShowDialog() == true)
            {
                FileStream stream = new FileStream(sfd.FileName, FileMode.Create);
                bit.Save(stream);
            }
            
        }
    }
}
