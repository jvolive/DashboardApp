using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace DashboardApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double percentOperante = 0.86; // 86%
        private double percentInoperante = 0.14; // 14%
        public MainWindow()
        {
            InitializeComponent();

            DSeriesCollection = new SeriesCollection
        {
            new PieSeries
            {
                Title = "Operante",
                Values = new ChartValues<ObservableValue> { new ObservableValue(percentOperante) },
                DataLabels = true,
                Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#15C51D")), // Cor vermelha para "Inoperante"
                LabelPoint = point => string.Format("{0:P0}", point.Y)

            },
            new PieSeries
            {
                Title = "Inoperante",
                Values = new ChartValues<ObservableValue> { new ObservableValue(percentInoperante) },
                DataLabels = true,
                Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#e74c3c")),
                LabelPoint = point => string.Format("{0:P0}", point.Y)
            }
        };

            DataContext = this;
        }

        public SeriesCollection DSeriesCollection { get; set; }


        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }
    }



}