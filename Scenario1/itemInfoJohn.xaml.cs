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
    /// Interaction logic for itemInfo.xaml
    /// </summary>
    public partial class ItemInfoJohn : Window
    {
        public ItemInfoJohn()
        {
            InitializeComponent();
            Arrow1.Visibility = Visibility.Visible;
            Arrow2.Visibility = Visibility.Visible;
            Arrow3.Visibility = Visibility.Visible;
            Arrow4.Visibility = Visibility.Visible;
            Arrow5.Visibility = Visibility.Visible;
            Arrow6.Visibility = Visibility.Visible;
        }

        private void RemoveOverlay(object sender, RoutedEventArgs e)
        {
            TextOverlay1.Visibility = Visibility.Hidden;
            TextOverlay2.Visibility = Visibility.Hidden;
            TextOverlay3.Visibility = Visibility.Hidden;
            TextOverlay4.Visibility = Visibility.Hidden;
            TextOverlay5.Visibility = Visibility.Hidden;
            TextOverlay6.Visibility = Visibility.Hidden;
            Arrow1.Visibility = Visibility.Hidden;
            Arrow2.Visibility = Visibility.Hidden;
            Arrow3.Visibility = Visibility.Hidden;
            Arrow4.Visibility = Visibility.Hidden;
            Arrow5.Visibility = Visibility.Hidden;
            Arrow6.Visibility = Visibility.Hidden;
            OverlayButton.Visibility = Visibility.Hidden;
        }

        public void AddShrimpMilkshake(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
