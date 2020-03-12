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

namespace Opgave_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LogInd LogInd = new LogInd();
            this.Hide();
            LogInd.ShowDialog();


        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            
            
        }

        private void B_blodsukker_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Window1 BS = new Window1();
            BS.ShowDialog();

            
        }

        private void B_blodtryk_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Blodpressure BP = new Blodpressure();
            BP.ShowDialog();
            
        }
     

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            

            MessageBoxResult result = MessageBox.Show("Are you sure?", "Warning", MessageBoxButton.YesNo);
            if (result != MessageBoxResult.Yes)
            {
                e.Cancel = true;
            }
           
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            
        }

        private void B_Vægt_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Weight WT = new Weight();
            WT.ShowDialog();


        }

        private void B_send_Click(object sender, RoutedEventArgs e)
        {
            if(RB_1uge.IsChecked==true)
            MessageBox.Show("Din indsamlet data for 1 uge, er sendt korrekt");
            if(RB_2uger.IsChecked==true)
            MessageBox.Show("Din indsamlet data for 2 uger, er sendt korrekt");
            if(RB_4uger.IsChecked==true)
            MessageBox.Show("Din indsamlet data for 4 uger, er sendt korrekt");
            if(RB_4uger.IsChecked == false && RB_2uger.IsChecked == false && RB_1uge.IsChecked == false)
            MessageBox.Show("Fejl - Din data blev ikke sendt, vælg venligst hvilken periode du vil indsende");
        }
    }
}
