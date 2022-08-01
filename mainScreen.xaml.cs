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
using System.Windows.Shapes;

namespace _481Project
{
    /// <summary>
    /// Interaction logic for mainScreen.xaml
    /// </summary>
    public partial class MainScreen : Window
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void RemoveOverlay(object sender, RoutedEventArgs e)
        {
            overlay1.Visibility = Visibility.Hidden;
            overlay2.Visibility = Visibility.Hidden;
            overlay3.Visibility = Visibility.Hidden;
            overlay4.Visibility = Visibility.Hidden;
            overlaySplash.Visibility = Visibility.Hidden;
        }

        private void ShowOverlay(object sender, RoutedEventArgs e)
        {
            overlay1.Visibility = Visibility.Visible;
            overlay2.Visibility = Visibility.Visible;
            overlay3.Visibility = Visibility.Visible;
            overlay4.Visibility = Visibility.Visible;
            overlaySplash.Visibility = Visibility.Visible;
        }
    }
}
