using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wpf_ChangeImage
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BitmapImage bmpImgBell;
        BitmapImage bmpImgGiftbox;

        public MainWindow()
        {
            InitializeComponent();
            Uri uriImgBell = new Uri(@"pack://application:,,,/Resources/Bell.png", UriKind.Absolute);
            Uri uriImgGiftbox = new Uri(@"pack://application:,,,/Resources/Giftbox.png", UriKind.Absolute);
            bmpImgBell = GetBitmapImage(uriImgBell);
            bmpImgGiftbox = GetBitmapImage(uriImgGiftbox);
            btnOne.Tag = false;
        }

        BitmapImage GetBitmapImage(Uri uri)
        {
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();
            bitmapImage.UriSource = uri;
            bitmapImage.EndInit();
            return bitmapImage;
        }

        private void btnOne_Click(object sender, RoutedEventArgs e)
        {
            if ((Boolean)btnOne.Tag == false)
            {
                imgBtnOne.Source = bmpImgBell;
                btnOne.Tag = true;
            }
            else if ((Boolean)btnOne.Tag == true)
            {
                imgBtnOne.Source = bmpImgGiftbox;
                btnOne.Tag = false;
            }
        }
    }
}
