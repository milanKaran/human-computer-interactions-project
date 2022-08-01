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
    public partial class MainScreenThomas : Window
    {
        public MainScreenThomas()
        {
            InitializeComponent();
        }


        private void RemoveOverlay(object sender, RoutedEventArgs e)
        {
            overlay1.Visibility = Visibility.Hidden;
            overlay2.Visibility = Visibility.Hidden;
            overlay3.Visibility = Visibility.Hidden;
            overlay4.Visibility = Visibility.Hidden;
            ArrowWaiter.Visibility = Visibility.Hidden;
            ArrowReviewOrder.Visibility = Visibility.Hidden;
            ArrowRemove.Visibility = Visibility.Hidden;
            ArrowAdd.Visibility = Visibility.Hidden;
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            donairCounter.Text = "1";
            priceTotal.Text = "5.95";
        }

        private void ReviewOrderPartial_Click(object sender, RoutedEventArgs e)
        {
            var newForm = new ReviewOrderThomas();
            newForm.tabController.SelectedIndex = 1;
            newForm.Top = this.Top;
            newForm.Left = this.Left;
            //mainsTab.Visibility = Visibility.Visible;
            newForm.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var CallStaff = new WaiterNotificationThomas()
            {
                Top = this.Top + 150,
                Left = this.Left + 266.5
            };
            CallStaff.Show();
        }
    }
}
