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
        public MainWindow()
        {
            InitializeComponent();

            // Valores para Operante e Inoperante
            double percentOperante1 = 0.86; // 86%
            double percentInoperante1 = 0.14; // 14%

            double percentOperante2 = 0.75; // 75%
            double percentInoperante2 = 0.25; // 25%

            double percentOperante3 = 0.50; // 50%
            double percentInoperante3 = 0.50; // 50%

            double percentOperante4 = 0.75; // 43%
            double percentInoperante4 = 0.25; // 57%

            // Coleção de séries para o primeiro gráfico
            DSeriesCollection1 = new SeriesCollection
        {
            new PieSeries
            {
                Title = "Operante",
                Values = new ChartValues<ObservableValue> { new ObservableValue(percentOperante1) },
                DataLabels = true,
                Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#15C51D")),
                LabelPoint = point => string.Format("{0:P0}", point.Y)
            },
            new PieSeries
            {
                Title = "Inoperante",
                Values = new ChartValues<ObservableValue> { new ObservableValue(percentInoperante1) },
                DataLabels = true,
                Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#e74c3c")),
                LabelPoint = point => string.Format("{0:P0}", point.Y)
            }
        };

            // Coleção de séries para o segundo gráfico
            DSeriesCollection2 = new SeriesCollection
        {
            new PieSeries
            {
                Title = "Operante",
                Values = new ChartValues<ObservableValue> { new ObservableValue(percentOperante2) },
                DataLabels = true,
                Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#15C51D")),
                LabelPoint = point => string.Format("{0:P0}", point.Y)
            },
            new PieSeries
            {
                Title = "Inoperante",
                Values = new ChartValues<ObservableValue> { new ObservableValue(percentInoperante2) },
                DataLabels = true,
                Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#e74c3c")),
                LabelPoint = point => string.Format("{0:P0}", point.Y)
            }
        };
            DSeriesCollection3 = new SeriesCollection
        {
            new PieSeries
            {
                Title = "Operante",
                Values = new ChartValues<ObservableValue> { new ObservableValue(percentOperante3) },
                DataLabels = true,
                Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#15C51D")),
                LabelPoint = point => string.Format("{0:P0}", point.Y)
            },
            new PieSeries
            {
                Title = "Inoperante",
                Values = new ChartValues<ObservableValue> { new ObservableValue(percentInoperante3) },
                DataLabels = true,
                Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#e74c3c")),
                LabelPoint = point => string.Format("{0:P0}", point.Y)
            }
        };
            DSeriesCollection4 = new SeriesCollection
        {
            new PieSeries
            {
                Title = "Operante",
                Values = new ChartValues<ObservableValue> { new ObservableValue(percentOperante4) },
                DataLabels = true,
                Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#15C51D")),
                LabelPoint = point => string.Format("{0:P0}", point.Y)
            },
            new PieSeries
            {
                Title = "Inoperante",
                Values = new ChartValues<ObservableValue> { new ObservableValue(percentInoperante4) },
                DataLabels = true,
                Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#e74c3c")),
                LabelPoint = point => string.Format("{0:P0}", point.Y)
            }
        };



            DataContext = this;
        }

        public SeriesCollection DSeriesCollection1 { get; set; }
        public SeriesCollection DSeriesCollection2 { get; set; }
        public SeriesCollection DSeriesCollection3 { get; set; }
        public SeriesCollection DSeriesCollection4 { get; set; }
        // DSeriesCollection3, DSeriesCollection4, etc.

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }
    }
}