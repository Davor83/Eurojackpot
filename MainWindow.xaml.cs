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

namespace Eurojackpot
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

        private void btnGenerate_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            ValueTuple<List<int>, List<int>> rezultat = (new List<int>(), new List<int>());

            var (mainNumbers, extraNumbers) = (new List<int>(), new List<int>());


            while(mainNumbers.Count <5)
            {
                int number = random.Next(1, 51);
                if (!mainNumbers.Contains(number))
                    mainNumbers.Add(number);

            }

            while (extraNumbers.Count < 2)
            {
                int number = random.Next(1, 13);
                if (!extraNumbers.Contains(number))
                    extraNumbers.Add(number);
            }

            mainNumbers.Sort();
            txtMainNumbers.FontSize = 20;
            txtMainNumbers.FontFamily = new FontFamily("Times New Roman");
            txtMainNumbers.Text = String.Join("  ", mainNumbers);

            extraNumbers.Sort();
            txtExtraNumbers.FontSize = 20;
            txtExtraNumbers.FontFamily = new FontFamily("Times New Roman");
            txtExtraNumbers.Text = String.Join("  ", extraNumbers);

        }
    }
}