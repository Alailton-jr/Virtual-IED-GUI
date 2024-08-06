using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Virtual_IED_GUI.Converters
{
    public class ColumnWidthConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values[0] is double listViewWidth &&
                values[1] is double selfWidth)
            {
                double componentsWidths = 0;
                for (int i = 2; i < values.Length; i++)
                {
                    if (values[i] is double)
                        componentsWidths += (double)values[i];
                }
                double remainingWidth = listViewWidth - componentsWidths - 10;
                return remainingWidth > 0 ? remainingWidth : 0;
            }
            return 0;
        }

        public object[]? ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            // It's Not used
            return null;
        }
    }
}
