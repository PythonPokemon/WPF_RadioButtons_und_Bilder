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

namespace WPF_RadioButtons_und_Bilder
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

        private void Ja_RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Danke das du mich magst :-)");
        }

        private void Nein_RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Schade ;-(");
        }

        private void soWhat_RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("was nun? ;-/");
        }
    }
}