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
    /// Interaction logic for welcomeScreen.xaml
    /// </summary>
    public partial class WelcomeScreen : Window
    {
        public static MainscreenJohn ToJohn = new MainscreenJohn();
        public WelcomeScreen()
        {
            InitializeComponent();

        }


        private void Begin(object sender, RoutedEventArgs e)
        {
 
                var newForm = new MainScreen();    //create your new form.
                newForm.Show();                     //show the new form.
                this.Close();                       //only if you want to close the current form.
    
        }

        private void ToScenario1(object sender, RoutedEventArgs e)
        {
            ToJohn.Top = this.Top;
            ToJohn.Left = this.Left;
            ToJohn.Show();
            this.Close();
        }

        private void ToScenario4(object sender, RoutedEventArgs e)
        {
            var newForm = new MainScreenKaren();
            newForm.Top = this.Top;
            newForm.Left = this.Left;
            newForm.Show();                     
            this.Close();                       
        }

        private void ToScenario6(object sender, RoutedEventArgs e)
        {
            var newForm = new MainScreenJack();
            newForm.Top = this.Top;
            newForm.Left = this.Left;
            newForm.Show();
            this.Close();
        }

        private void ToScenario3(object sender, RoutedEventArgs e)
        {
            var newForm = new MainScreenThomas();
            newForm.Top = this.Top;
            newForm.Left = this.Left;
            newForm.Show();
            this.Close();
        }
    }
}
