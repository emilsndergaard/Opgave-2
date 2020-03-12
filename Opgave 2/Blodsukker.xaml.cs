using System;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Func<double, string> Formatter { get; set; }
        public Func<double, string> Formatter1 { get; set; }

        private Logic LogicData;

        public SeriesCollection MySeriesCollection { get; set; }
        public List<String> Labels { get; set; }
        public Window1()
        {
            InitializeComponent();

            LogicData = new Logic();

            Labels = new List<String>();

            MySeriesCollection = new SeriesCollection();

            LineSeries blodsukker = new LineSeries();
            blodsukker.Title = "Blodsukker";
            //LineSeries diastole = new LineSeries();
            //diastole.Title = "Diastolt blodtryk";
            blodsukker.Values = new ChartValues<double>();
            //diastole.Values = new ChartValues<int>();


            Formatter = value => (new DateTime((long)value).Hour + " hour");
            Formatter1 = value => (new DateTime((long)value).Day) + "." + new DateTime((long)value).Month + "." + new DateTime((long)value).Year;

            //DateTime now = new DateTime(2020, 03, 02);


            foreach (DTO.DTO_BSugar bSugar in LogicData.getBSugarData("ID"))
            {

                blodsukker.Values.Add(bSugar.BloodSugar_);

                //diastole.Values.Add(bPressure.Diastolic_);

                Labels.Add(Convert.ToString(bSugar.Date_));
            }


            MySeriesCollection.Add(blodsukker);
            //MySeriesCollection.Add(diastole);

            DataContext = this;



        }




        private void Window_Closed(object sender, EventArgs e)
        {

            Application.Current.MainWindow.Show();
            this.Close();

        }

        private void CartesianChart_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
