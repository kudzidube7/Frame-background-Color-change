using System;
using System.Globalization;
using Xamarin.Forms;

namespace FrameColorChange.Converters
{
    public class SelectedCategoryConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var categorySelected = value is bool ? (bool)value : false;
            return categorySelected ? (Color)Color.Red : (Color)Color.Green;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var categorySelected = value is bool ? (bool)value : false;
            return categorySelected ? (Color)Color.Red : (Color)Color.Green;

        }
    }
}
