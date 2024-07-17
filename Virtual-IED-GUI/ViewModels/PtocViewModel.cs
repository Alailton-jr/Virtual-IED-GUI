using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Wpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Virtual_IED_GUI.Controls;

namespace Virtual_IED_GUI.ViewModels
{
    public class PtocViewModel : ViewModelBase
    {

        private double _pickup;
        public double Pickup
        {
            get => _pickup;
            set
            {
                _pickup = value;
                OnPropertyChanged();
                UpdatePlot();
            }
        }

        private double _timeDial;
        public double TimeDial
        {
            get => _timeDial;
            set
            {
                _timeDial = value;
                OnPropertyChanged();
                UpdatePlot();
            }
        }

        private string _curve;
        public string Curve
        {
            get => _curve;
            set
            {
                _curve = value;
                OnPropertyChanged();
                UpdatePlot();
            }
        }

        private double _minTime;
        public double MinTime
        {
            get => _minTime;
            set
            {
                _minTime = value;
                OnPropertyChanged();
                UpdatePlot();
            }
        }

        public PlotModel plotModel { get; }

        private Dictionary<string, List<double>> curveCoef;
        
        public ObservableCollection<string> CurveOptions { get; set; }

        public PtocViewModel()
        {
            CurveOptions = new ObservableCollection<string>()
            {
                "C1 - IEC Normal Inverse",
                "C2 - IEC Very Inverse",
                "C3 - IEC Extremely Inverse",
                "C4 - IEC Long Time Inverse",
                "C5 - IEC Short Time Inverse",

                "U1 - US Moderately Inverse",
                "U2 - US Inverse",
                "U3 - US Very Inverse",
                "U4 - US Extremely Inverse",
                "U5 - US Short Time Inverse",
            };
            curveCoef = new Dictionary<string, List<double>>()
            {
                    {"U1", new List<double> {0.0226, 0.0104, 0.02 } },
                    {"U2", new List<double> {0.180, 5.95, 2.0} },
                    {"U3", new List<double> {0.0963, 3.88, 2.0} },
                    {"U4", new List<double> {0.0352, 5.67, 2.0} },
                    {"U5", new List<double> {0.00262, 0.00342, 0.02} },
                    {"C1", new List<double> {0.0, 0.14, 0.02} },
                    {"C2", new List<double> {0.0, 13.5, 1.0} },
                    {"C3", new List<double> {0.0, 80.0, 2.0} },
                    {"C4", new List<double> {0.0, 120.0, 1.0} },
                    { "C5", new List<double> {0.0, 0.05, 0.04} }
            };
            Curve = CurveOptions[0];
            _timeDial = 2;
            _minTime = 0.1;
            _pickup = 1;
            plotModel = DefaultClasses.CreatePlotModel();
            UpdatePlot();
        }

        private void UpdatePlot()
        {
            try{
                if (plotModel == null)
                {
                    return;
                }
                var series = new OxyPlot.Series.LineSeries { 
                    Title = "Ptoc",
                    TrackerFormatString = "Current: {2:0.000} pu\nTime: {4:0.0000} s"
                };
                double y;
                string curveIdx = $"{_curve[0]}{_curve[1]}";
                for (double i = 1.01; i < 20; i += 0.01)
                {
                    y = _timeDial * (curveCoef[curveIdx][0] + (curveCoef[curveIdx][1] / (Math.Pow((i / 1), curveCoef[curveIdx][2]) - 1)));
                    if (y < MinTime)
                    {
                        y = MinTime;
                    }
                    series.Points.Add(new OxyPlot.DataPoint(i, y));
                }
                series.Color = OxyColors.Blue;
                series.TextColor = OxyColors.Blue;
                plotModel.Series.Clear();
                plotModel.Series.Add(series);
                plotModel.InvalidatePlot(true);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
