namespace SimpleDemo
{
    using OxyPlot;
    using OxyPlot.Axes;
    using OxyPlot.Series;
    using System.Collections.Generic;
    using System.ComponentModel;

    public class MainViewModel : INotifyPropertyChanged
    {
        public MainViewModel()
        {
            var model = new PlotModel { Title = "Hello Universal Windows" };
            model.Axes.Add(new LinearAxis { Position = AxisPosition.Bottom });
            model.Axes.Add(new LinearAxis { Position = AxisPosition.Left });
            LineSeries lineSeries = new LineSeries { Title = "LineSeries", MarkerType = MarkerType.Circle };
            lineSeries.Points.Add(new DataPoint(0, 0));
            lineSeries.Points.Add(new DataPoint(10, 18));
            lineSeries.Points.Add(new DataPoint(20, 12));
            lineSeries.Points.Add(new DataPoint(30, 8));
            lineSeries.Points.Add(new DataPoint(40, 15));

            model.Series.Add(lineSeries);
            model.InvalidatePlot(true);
            this.Model = model;
        }

        private PlotModel _model;

        public event PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }

        public PlotModel Model
        {
            get => _model;
            private set
            {
                if (!object.ReferenceEquals(_model, value))
                {
                    _model = value;
                    OnPropertyChanged("Model");
                }
            }
        }
    }
}