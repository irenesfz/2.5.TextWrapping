using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;


namespace TextWrapping
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

        private void TextoTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            ResultadoTextBlock.Text = TextoTextBox.Text;
        }

        private void NegritaCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if (NegritaCheckBox.IsChecked == true)
                ResultadoTextBlock.FontWeight = FontWeights.Bold;
            else ResultadoTextBlock.FontWeight = FontWeights.Normal;
        }

        private void CursivaCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if (CursivaCheckBox.IsChecked == true)
                ResultadoTextBlock.FontStyle = FontStyles.Italic;
            else ResultadoTextBlock.FontStyle = FontStyles.Normal;
        }

        private void AzulRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            ResultadoTextBlock.Foreground = Brushes.Blue;
        }

        private void RojoRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            ResultadoTextBlock.Foreground = Brushes.Red;
        }

        private void VerdeRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            ResultadoTextBlock.Foreground = Brushes.Green;
        }
    }
}
