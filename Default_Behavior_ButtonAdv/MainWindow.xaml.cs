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

namespace Default_Behavior_ButtonAdv
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.PreviewKeyDown += new KeyEventHandler(CloseOnEscape);
        }

        private void CloseOnEscape(object sender, KeyEventArgs e)
        {
            // on pressing Escape, CancelButton get invoked.
            if (e.Key == Key.Escape)
            {
                CancelButton_Click(sender, e);
            }
          
            //On pressing the Enter, DefaultButton get invoked.
            if (e.Key == Key.Enter)
            {
                DefaultButton_Click(sender, e);
            }
         }

         private void DefaultButton_Click(object sender, RoutedEventArgs e)
         {
             MessageBox.Show("Enter key pressed, Default Button is activated", "Message");
         }
         
         private void CancelButton_Click(object sender, RoutedEventArgs e)
         {
             MessageBox.Show("Esc key pressed, Cancel Button is activated", "Message");
         }

   }
}
