using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Registration.Converters
{
    public class DateToStringConverter:IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            DateTime outParam;
            if (value!=null)
            {
                return value.ToString().Equals(DateTime.MinValue.ToString()) ? string.Empty : value.ToString();
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            DateTime outParam;
            DateTime.TryParse(value.ToString(), out outParam);
            return outParam;
        }
    }
}
