using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
    public partial class ReviewOrderJohn : Window
    {
        DispatcherTimer _timer1, _timer2;
        TimeSpan _time1, _time2;
        public static MainscreenJohn fromMainScreen = new MainscreenJohn();
        public static ItemInfoJohn ShrimpMilkshakeInfo = new ItemInfoJohn();
        public ReviewOrderJohn()
        {
            InitializeComponent();
            HideInitialItems();
            SetPreExistingItems();

        }
        public ReviewOrderJohn(DependencyObject depObject) 
        {
            Owner = Window.GetWindow(depObject);
        }
        private void HideInitialItems() 
        {
            ShrimpMilkshakeList.Visibility = Visibility.Hidden;
            ShrimpIceCreamList.Visibility = Visibility.Hidden;
            ProcessingOrderButton.Visibility = Visibility.Hidden;
            OrderedButton1.Source = new BitmapImage(new Uri("icons/emptyCircle.png", UriKind.RelativeOrAbsolute));
            OrderedButton2.Source = new BitmapImage(new Uri("icons/emptyCircle.png", UriKind.RelativeOrAbsolute));
            OrderedButton3.Source = new BitmapImage(new Uri("icons/emptyCircle.png", UriKind.RelativeOrAbsolute));
            OrderedButton4.Source = new BitmapImage(new Uri("icons/emptyCircle.png", UriKind.RelativeOrAbsolute));
            OrderedButton5.Source = new BitmapImage(new Uri("icons/emptyCircle.png", UriKind.RelativeOrAbsolute));
        }
        public void SetPreExistingItems() 
        {
            NumOfBurgers.Text = fromMainScreen.GetNumberOfShrimpBurgers();
            NumOfButterBuiscuits.Text = fromMainScreen.GetNumberOfButterBuiscuits();
            NumOfPopcornShrimp.Text = fromMainScreen.GetNumberOfPopcornShrimps();
            PriceTotal.Text = fromMainScreen.GetPriceTally();
        }

        private void FirstConfirmOrderClick(object sender, RoutedEventArgs e)
        {
            var ConfirmedPopUp = new PlacedOrderJohn()
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
                    OrderedButton2.Source = new BitmapImage(new Uri("icons/greenCheck.png", UriKind.RelativeOrAbsolute));
                    OrderedButton3.Source = new BitmapImage(new Uri("icons/greenCheck.png", UriKind.RelativeOrAbsolute));
                    OrderedButton4.Source = new BitmapImage(new Uri("icons/greenCheck.png", UriKind.RelativeOrAbsolute));
                    ShrimpBurgerList.Background = new SolidColorBrush(Color.FromArgb(100, 101, 101, 116));
                    ShrimpBurgerList.Opacity = 0.5;
                    PopcornShrimpList.Background = new SolidColorBrush(Color.FromArgb(100, 101, 101, 116));
                    PopcornShrimpList.Opacity = 0.5;
                    ButterBuiscuitList.Background = new SolidColorBrush(Color.FromArgb(100, 101, 101, 116));
                    ButterBuiscuitList.Opacity = 0.5;
                    ShrimpMilkshakeList.Background = new SolidColorBrush(Color.FromArgb(100, 101, 101, 116));
                    ShrimpMilkshakeList.Opacity = 0.5;
                    SubTotalCounter.Text = "0";
                    SubtotalPrice.Text = "$0.00";
                    SecondTimeConfirmedButton.Visibility = Visibility.Visible;
                    
                } 
                _time1 = _time1.Add(TimeSpan.FromSeconds(-1));
            }, Application.Current.Dispatcher);

            _timer1.Start();
            FirstTimeConfirmedButton.Visibility = Visibility.Hidden;
            ProcessingOrderButton.Visibility = Visibility.Visible;
        }
        private void CloseItemInfoJohn(object sender, RoutedEventArgs e)
        {
            ShrimpMilkshakeInfo.Close();
            fromMainScreen.AddToTotalPrice(4.50);
            PriceTotal.Text = fromMainScreen.GetPriceTally();
            currentShrimpMilk.Text = "1";
            SubTotalCounter.Text = "5";
            SubtotalPrice.Text = "$" + fromMainScreen.GetPriceTally();
            ShrimpMilkshakeList.Visibility = Visibility.Visible;
        }

        private void ButtonShrimpMilkshakeInfo(object sender, RoutedEventArgs e)
        {
            ShrimpMilkshakeInfo.Top = this.Top + 25;
            ShrimpMilkshakeInfo.Left = this.Left + 120;
            ShrimpMilkshakeInfo.Show();
            ShrimpMilkshakeInfo.returnButton.Click += CloseItemInfoJohn;
        }

        private void SecondConfirmOrderClick(object sender, RoutedEventArgs e)
        {
            
            var ConfirmedPopUp = new PlacedOrderJohn()
            {
                Top = this.Top + 150,
                Left = this.Left + 266.5
            };
            _time2 = TimeSpan.FromSeconds(3);
            _timer2 = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
            {
                if (_time2 == TimeSpan.Zero) 
                {
                    _timer2.Stop();
                    ProcessingOrderButton.Visibility = Visibility.Hidden;
                    SecondTimeConfirmedButton.Visibility = Visibility.Visible;
                    ConfirmedPopUp.Show();
                    ShrimpIceCreamList.Background = new SolidColorBrush(Color.FromArgb(100, 101, 101, 116));
                    ShrimpIceCreamList.Opacity = 0.5;
                    OrderedButton5.Source = new BitmapImage(new Uri("icons/greenCheck.png", UriKind.RelativeOrAbsolute));
                    SubtotalPrice.Text = "$0.00";
                    SubTotalCounter.Text = "0";
                }
                _time2 = _time2.Add(TimeSpan.FromSeconds(-1));
            }, Application.Current.Dispatcher);
            _timer2.Start();
            SecondTimeConfirmedButton.Visibility = Visibility.Hidden;
            ProcessingOrderButton.Visibility = Visibility.Visible;
            
        }

        private void IceCreamUp(object sender, RoutedEventArgs e)
        {
            IceCreamCounter.Text = "1";
            SubTotalCounter.Text = "1";
            SubtotalPrice.Text = "$2.50";
            ShrimpIceCreamList.Visibility = Visibility.Visible;
            fromMainScreen.AddToTotalPrice(2.50);
            PriceTotal.Text = fromMainScreen.GetPriceTally();
        }
    }

}
