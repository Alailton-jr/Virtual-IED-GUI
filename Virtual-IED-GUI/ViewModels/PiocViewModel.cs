using OxyPlot;
using OxyPlot.Axes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Virtual_IED_GUI.Controls;

namespace Virtual_IED_GUI.ViewModels
{
    public class PiocViewModel : ViewModelBase
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

        private double _timeDelay;
        public double TimeDelay
        {
            get => _timeDelay;
            set
            {
                _timeDelay = value;
                OnPropertyChanged();
                UpdatePlot();
            } 
        }

        private double NominalCurrent { get; set; }


        public PlotModel plotModel { get; }
        public PiocViewModel(double? nominalCurrent)
        {
            plotModel = DefaultClasses.CreatePlotModel();

            NominalCurrent = nominalCurrent ?? 1;

            Pickup = 1;
            TimeDelay = 0.5;
        }

        private void UpdatePlot()
        {
            try
            {
                if (plotModel == null)
                {
                    return;
                }
                var series = new OxyPlot.Series.LineSeries
                {
                    Title = "PIOC",
                    TrackerFormatString = "Current: {2:0.000} pu\nTime: {4:0.0000} s"
                };
                double y;
                for (double i = 0; i < 20; i += 0.1)
                {
                    y = i > (Pickup / NominalCurrent) ? TimeDelay : 1000;
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
