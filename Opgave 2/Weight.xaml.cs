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
    /// Interaction logic for Weight.xaml
    /// </summary>
    public partial class Weight : Window
    {
        public Func<double, string> Formatter { get; set; }
        public Func<double, string> Formatter1 { get; set; }

        private Logic LogicData;

        public SeriesCollection MySeriesCollection { get; set; }
        public SeriesCollection MySeriesCollection2 { get; set; }
        public List<String> Labels { get; set; }


        public Weight()
        {
            InitializeComponent();

            LogicData = new Logic();

            Labels = new List<String>();

            MySeriesCollection = new SeriesCollection();
            MySeriesCollection2 = new SeriesCollection();

            LineSeries weight = new LineSeries();
            weight.Title = "Weight";
            LineSeries bmi = new LineSeries();
            bmi.Title = "Body Mass Index";
            weight.Values = new ChartValues<int>();
            bmi.Values = new ChartValues<int>();


            //Formatter = value => (new DateTime((long)value).Hour + " hour");
            //Formatter1 = value => (new DateTime((long)value).Day) + "." + new DateTime((long)value).Month + "." + new DateTime((long)value).Year;

            //DateTime now = new DateTime(2020, 03, 02);


            foreach (DTO.DTO_Weight Weight in LogicData.getWeightAndBMIData("ID"))
            {
                weight.Values.Add(Convert.ToInt32(Weight.Weight_));

                bmi.Values.Add(Weight.BMI_);

                Labels.Add(Convert.ToString(Weight.Date_.Day+" / "+Weight.Date_.Month+" - "+Weight.Date_.TimeOfDay));
            }


            MySeriesCollection.Add(weight);
            MySeriesCollection2.Add(bmi);

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
