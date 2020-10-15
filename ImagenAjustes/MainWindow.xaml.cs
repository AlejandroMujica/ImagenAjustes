
using System.Windows;
using System.Windows.Media;


namespace ImagenAjustes
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AltaCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            starWarsImage.Opacity = 1;
        }

        private void MediaCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            starWarsImage.Opacity = 0.6;
        }

        private void BajaCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            starWarsImage.Opacity = 0.3;
        }

        private void RellenoCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            starWarsImage.Stretch = Stretch.Fill;
        }

        private void UniformeCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            starWarsImage.Stretch = Stretch.Uniform;
        }

        private void RellenoUniformeCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            starWarsImage.Stretch = Stretch.UniformToFill;
        }

        private void SinAjusteCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            starWarsImage.Stretch = Stretch.None;
        }
    }
}
