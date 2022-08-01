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
using System.Windows.Threading;

namespace _481Project
{
    /// <summary>
    /// Interaction logic for reviewOrder.xaml
    /// </summary>
    public partial class ReviewOrderKaren : Window
    {
        DispatcherTimer _timer1;
        TimeSpan _time1;
        public static MainScreenKaren MainWindow = new MainScreenKaren();
        public ReviewOrderKaren()
        {
            InitializeComponent();
        }

        private void ConfirmPopUp(object sender, RoutedEventArgs e)
        {
            var ConfirmedPopUp = new PlacedOrderKaren()
            {
                Top = this.Top + 150,
                Left = this.Left + 266.5
            };

            _time1 = TimeSpan.FromSeconds(3);

            _timer1 = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
            {
                if (_time1 == TimeSpan.Zero)
                {
                    _timer1.Stop();
                    ProcessingOrderButton.Visibility = Visibility.Hidden;
                    ConfirmedPopUp.Show();

                    OrderedButton1.Source = new BitmapImage(new Uri("icons/greenCheck.png", UriKind.RelativeOrAbsolute));

                    ShrimpSpaghettiList.Background = new SolidColorBrush(Color.FromArgb(100, 101, 101, 116));
                    ShrimpSpaghettiList.Opacity = 0.5;

                    SpaghettiCounter.Text = "0";
                    SubTotalCounter.Text = "0";
                    SubtotalPrice.Text = "$0.00";
                    returnButton.Visibility = Visibility.Visible;

                }
                _time1 = _time1.Add(TimeSpan.FromSeconds(-1));
            }, Application.Current.Dispatcher);
            _timer1.Start();

            returnButton.Visibility = Visibility.Hidden;
            ProcessingOrderButton.Visibility = Visibility.Visible;
        }


        private void RemoveOverlay(object sender, RoutedEventArgs e)
        {
            overlay1.Visibility = Visibility.Hidden;
            overlay2.Visibility = Visibility.Hidden;
            overlay3.Visibility = Visibility.Hidden;
            overlay4.Visibility = Visibility.Hidden;
            ArrowAdd.Visibility = Visibility.Hidden;
            ArrowRemove.Visibility = Visibility.Hidden;
            ArrowWaiter.Visibility = Visibility.Hidden;
            ArrowReviewOrder.Visibility = Visibility.Hidden;
            overlaySplash.Visibility = Visibility.Hidden;
        }

        private void ShowOverlay(object sender, RoutedEventArgs e)
        {
            overlay1.Visibility = Visibility.Visible;
            overlay2.Visibility = Visibility.Visible;
            overlay3.Visibility = Visibility.Visible;
            overlay4.Visibility = Visibility.Visible;
            ArrowAdd.Visibility = Visibility.Visible;
            ArrowRemove.Visibility = Visibility.Visible;
            ArrowWaiter.Visibility = Visibility.Visible;
            ArrowReviewOrder.Visibility = Visibility.Visible;
            overlaySplash.Visibility = Visibility.Visible;
        }

        private void ResetTablet(object sender, RoutedEventArgs e)
        {
            var reviewOrder = new TwoWelcomeScreenKaren();
            Top = reviewOrder.Top; 
            Left = reviewOrder.Left;
            reviewOrder.Show();
            this.Close();
        }

        private void CallWaiter(object sender, RoutedEventArgs e)
        {
            var CallStaff = new WaiterNotification()
            {
                Top = this.Top + 150,
                Left = this.Left + 266.5
            };
            CallStaff.Show();
        }

        private void ReturnToMain(object sender, RoutedEventArgs e)
        {
            MainWindow.overlay1.Visibility = Visibility.Hidden;
            MainWindow.overlay2.Visibility = Visibility.Hidden;
            MainWindow.overlay3.Visibility = Visibility.Hidden;
            MainWindow.overlay4.Visibility = Visibility.Hidden;
            MainWindow.ArrowAdd.Visibility = Visibility.Hidden;
            MainWindow.ArrowRemove.Visibility = Visibility.Hidden;
            MainWindow.ArrowWaiter.Visibility = Visibility.Hidden;
            MainWindow.ArrowReviewOrder.Visibility = Visibility.Hidden;
            MainWindow.overlaySplash.Visibility = Visibility.Hidden;
            MainWindow.aTabControl.SelectedIndex = 1;
            MainWindow.aTabControl.SelectedItem = mainsTab;
            MainWindow.mainsTab.IsSelected = true;
            MainWindow.priceTotal.Text = "11.95";
            MainWindow.Top = this.Top;
            MainWindow.Left = this.Left;
            MainWindow.Show();
            this.Close();
        }
    }
}
