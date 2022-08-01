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
    public partial class TwoWelcomeScreenKaren : Window
    {
        public TwoWelcomeScreenKaren()
        {
            InitializeComponent();

        }


        private void Begin(object sender, RoutedEventArgs e)
        {
 
                var newForm = new TwoMainScreenKaren();    //create your new form.
                newForm.Top = this.Top;
                newForm.Left = this.Left;
                newForm.Show();                     //show the new form.
                this.Close();                       //only if you want to close the current form.
    
        }

       
    }
}
