using connectDB.databases;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace connectDB.common
{
    [ValueConversion(typeof(user_role), typeof(string))]
    public class ConventerUserRole : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            user_role user_Role = value as user_role;
            if (user_Role == null)
                return "none";
            return $"{user_Role.name}";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
