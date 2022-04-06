using System.Windows;
using System.Windows.Input;

namespace calculator
{
    public partial class MainWindow : Window
    {
        private int result = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void CloseWindow(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Increment(object sender, RoutedEventArgs e)
        {
            result++;
            resultText.Text = result.ToString();
        }
    }
}
