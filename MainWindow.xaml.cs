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


        /// <summary>
        /// Handles the "Generate" button click.
        /// Generates 5 unique main numbers (1–50) and 2 unique extra numbers (1–12),
        /// sorts them, and displays them in the corresponding TextBoxes.
        /// </summary>
        private void btnGenerate_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();

            // Unused tuple — can be removed unless needed for future refactoring
            ValueTuple<List<int>, List<int>> rezultat = (new List<int>(), new List<int>());

            // Destructuring tuple for main and extra numbers
            var (mainNumbers, extraNumbers) = (new List<int>(), new List<int>());

            // Generate 5 unique main numbers between 1 and 50
            while (mainNumbers.Count <5)
            {
                int number = random.Next(1, 51);
                if (!mainNumbers.Contains(number))
                    mainNumbers.Add(number);

            }

            // Generate 2 unique extra numbers between 1 and 12
            while (extraNumbers.Count < 2)
            {
                int number = random.Next(1, 13);
                if (!extraNumbers.Contains(number))
                    extraNumbers.Add(number);
            }

            // Sort and display main numbers
            mainNumbers.Sort();
            txtMainNumbers.FontSize = 20;
            txtMainNumbers.FontFamily = new FontFamily("Times New Roman");
            txtMainNumbers.Text = String.Join("  ", mainNumbers);

            // Sort and display extra numbers
            extraNumbers.Sort();
            txtExtraNumbers.FontSize = 20;
            txtExtraNumbers.FontFamily = new FontFamily("Times New Roman");
            txtExtraNumbers.Text = String.Join("  ", extraNumbers);

        }
    }
}