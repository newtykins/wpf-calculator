using System.Windows;

namespace calculator
{
    public partial class MainWindow : Window
    {
        private int result = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void Increment(object sender, RoutedEventArgs e)
        {
            result++;
            resultText.Text = result.ToString();
        }
    }
}
