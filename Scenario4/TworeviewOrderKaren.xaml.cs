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
    public partial class TwoReviewOrderKaren : Window
    {
        DispatcherTimer _timer1;
        TimeSpan _time1;
        public TwoReviewOrderKaren()
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

                    SalmonShrimpList.Background = new SolidColorBrush(Color.FromArgb(100, 101, 101, 116));
                    SalmonShrimpList.Opacity = 0.5;

                    SalmonShrimpCounter.Text = "0";
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

        private void CallWaiter(object sender, RoutedEventArgs e)
        {
            var CallStaff = new WaiterNotification()
            {
                Top = this.Top + 150,
                Left = this.Left + 266.5
            };
            CallStaff.Show();
        }

    }
}
