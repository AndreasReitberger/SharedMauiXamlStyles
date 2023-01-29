using AndreasReitberger.Shared.Core.Chart;
using Syncfusion.Maui.Charts;
using Syncfusion.Maui.Data;
using System.Collections.ObjectModel;
using System.Globalization;

namespace AndreasReitberger.Shared.Syncfusion.Syncfusion.Converters
{
    public class DictionaryToChartSeriesCollectionConverter : BindableObject, IValueConverter, IMarkupExtension<DictionaryToChartSeriesCollectionConverter>
    {
        #region Fields
        public static readonly BindableProperty SeriesCollectionProperty =
            BindableProperty.Create(nameof(SeriesCollection), typeof(ChartSeriesCollection), typeof(DictionaryToChartSeriesCollectionConverter), new ChartSeriesCollection(), BindingMode.TwoWay, null, null);

        #endregion

        public ChartSeriesCollection SeriesCollection { get; set; } = new();

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is Dictionary<string, List<double>> data)
            {
                data.ForEach(keypair =>
                {
                    List<double> lastValues = keypair.Value.Skip(Math.Max(0, keypair.Value.Count() - 100)).ToList();

                    //ChartSeries series = ChartSeries.FirstOrDefault(s => s.AutomationId == keypair.Key);
                    ChartSeries series = SeriesCollection.FirstOrDefault(s => ((SplineAreaSeries)s).XAxisName == keypair.Key);
                    if (series is SplineAreaSeries splineSeries)
                    {
                        splineSeries.ItemsSource = new ObservableCollection<ChartValueTimeItem>(lastValues.Select((value, index) => new ChartValueTimeItem()
                        {
                            Name = keypair.Key,
                            Value = value,
                            Time = index,
                        }));
                    }
                    else
                    {
                        SplineAreaSeries newSeries = new()
                        {
                            // just used to identify series later...
                            //AutomationId = keypair.Key,
                            XAxisName = keypair.Key,
                            Label = keypair.Key,
                            ItemsSource = new ObservableCollection<ChartValueTimeItem>(lastValues.Select((value, index) => new ChartValueTimeItem()
                            {
                                Name = keypair.Key,
                                Value = value,
                                Time = index,
                            })),
                            XBindingPath = "Time",
                            YBindingPath = "Value",
                            //ListenPropertyChange = true,
                            Opacity = 0.5,
                        };
                        SeriesCollection.Add(newSeries);
                    }
                });
            }
            return SeriesCollection;
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }

        DictionaryToChartSeriesCollectionConverter IMarkupExtension<DictionaryToChartSeriesCollectionConverter>.ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }
    }
}
