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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Part1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double weight = Double.Parse(weightText.Text);
            double height = Double.Parse(heightText.Text);

            double bodyMassIndex = (weight * 720) / Math.Pow(height, 2);

            if (bodyMassIndex < 15)
            {
                healthyText.Background = Brushes.Blue;
                healthyText.Text = "Below healthy range.";
            }
            else if (bodyMassIndex > 26)
            {
                healthyText.Background = Brushes.Yellow;
                healthyText.Text = "Above healthy range.";
            } else
            {
                healthyText.Background = Brushes.Green;
                healthyText.Text = "Within healthy range.";
            }
            
        }
    }
}
