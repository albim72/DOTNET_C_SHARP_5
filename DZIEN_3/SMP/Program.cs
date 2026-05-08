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

namespace SimpleWPF
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

        private void btnPolicz_Click(object sender, RoutedEventArgs e)

        {
            int wa;
            int wb;
            bool infowa = int.TryParse(txta.Text,out wa);
            bool infowb = int.TryParse(txtb.Text,out wb);

            if (!infowa && !infowb) { 
                MessageBox.Show("Nie można przetworzyć danych z obu pól. Muszą byc liczbami!");
                return;
            }

            int wynik = wa * wb;

            tbWynik.Text = wynik.ToString();


        }
    }
}
