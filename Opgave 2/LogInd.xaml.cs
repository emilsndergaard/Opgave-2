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
using System.Threading;

namespace Opgave_2
{
    /// <summary>
    /// Interaction logic for LogInd.xaml
    /// </summary>
    public partial class LogInd : Window
    {
        public LogInd()
        {
            InitializeComponent();
           
        }

       

        private void B_logind_Click(object sender, RoutedEventArgs e)
        {
            Logic logic = new Logic();

            
            if(logic.checkLogin(TB_personnummer.Text, TB_password.Password) ==true)
            {
                //Thread.Sleep(3000);

                //MainWindow MW = new MainWindow();
                //MW.Show();
                this.Close();
                Application.Current.MainWindow.Show();
                
            }
            else
            {
                MessageBox.Show("Forkert ID eller password \n          Prøv igen");
                TB_password.Clear();
                TB_personnummer.Clear();
                TB_personnummer.Focus();

            }
        }

        private void TB_personnummer_TextChanged(object sender, TextChangedEventArgs e)
        {
          if(TB_personnummer.Text.Length==6)
          {
                TB_personnummer.Text += "-";
                TB_personnummer.SelectionStart = TB_personnummer.Text.Length;
                
          }

            if (TB_personnummer.Text.Length == 11)
            {
                TB_password.Focus();
            }





        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TB_personnummer_GotFocus(object sender, RoutedEventArgs e)
        {
            TB_personnummer.Clear();
        }

        private void TB_password_GotFocus(object sender, RoutedEventArgs e)
        {
            //if(e.Key == Key.Return)
            //{

            //}
        }

        private void B_logind_TouchEnter(object sender, TouchEventArgs e)
        {

        }
    }
}
