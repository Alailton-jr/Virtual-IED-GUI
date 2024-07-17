using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OxyPlot;
using OxyPlot.Axes;

namespace Virtual_IED_GUI.Controls
{
    public class DefaultClasses
    {

        public static PlotModel CreatePlotModel()
        {
            var model = new OxyPlot.PlotModel { Title = "PIOC" };
            var series = new OxyPlot.Series.LineSeries { Title = "PIOC" };
            model.Series.Add(series);
            model.TextColor = OxyColors.Black;

            var logAxisX = new LinearAxis()
            {
                Position = AxisPosition.Bottom,
                Title = "Current [pu]",
                UseSuperExponentialFormat = false,
                MajorGridlineStyle = LineStyle.Dot,
                MinorGridlineStyle = LineStyle.Dot,
                MajorGridlineColor = OxyColors.Gray,
                MinorGridlineColor = OxyColors.LightGray,
                TitleColor = OxyColors.Lavender,
                TextColor = OxyColors.Lavender,
                AbsoluteMinimum = 0,
                AbsoluteMaximum = 999
            };
            var linearAxisY = new LogarithmicAxis
            {
                Position = AxisPosition.Left,
                Title = "Trip Time [s]",
                Base = 10,
                UseSuperExponentialFormat = false,
                AxislineColor = OxyColors.Blue,
                MajorGridlineStyle = LineStyle.Dot,
                MinorGridlineStyle = LineStyle.Dot,
                MajorGridlineColor = OxyColors.Gray,
                MinorGridlineColor = OxyColors.LightGray,
                TextColor = OxyColors.Lavender,
                TitleColor = OxyColors.Lavender,
                AbsoluteMinimum = 0
            };

            model.DefaultColors = new List<OxyColor>
            {
                OxyColor.FromRgb(0x4E, 0x9A, 0x06),
                OxyColor.FromRgb(0xC8, 0x8D, 0x00),
                OxyColor.FromRgb(0xCC, 0x00, 0x00),
                OxyColor.FromRgb(0x20, 0x4A, 0x87),
                OxyColors.Red,
                OxyColors.Orange,
                OxyColors.Black,
                OxyColors.Green,
                OxyColors.Blue,
                OxyColors.Indigo,
                OxyColors.Violet
            };

            model.TitleColor = OxyColors.Lavender;


            model.Axes.Add(logAxisX);
            model.Axes.Add(linearAxisY);
            return model;
        }
    }
}
