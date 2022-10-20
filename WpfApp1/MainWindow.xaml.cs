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
using System.IO;
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

            ComboImages.ItemsSource = new List<string>()
            {
                "bmw1.jpg",
                "bmw2.jpg",
                "honda1.jpg",
                "honda2.jpg",
                "jag1.jpg",
                "mustang1.jpg",
                "mustang2.jpg"
            };

        }

        private void ButtonShowImage_Click(object sender, RoutedEventArgs e)
        {
            UpdateImage((string)ComboImages.SelectedItem);
        }

        private void ComboImages_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        //Updating the Ui with an image
        private void UpdateImage(string imagePath) 
        {
            Uri uri = new Uri($"Images/{imagePath}", UriKind.Relative);
            ImagePanel.Source = new BitmapImage(uri);


        }
    }
}
