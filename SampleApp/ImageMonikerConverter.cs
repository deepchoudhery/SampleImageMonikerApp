using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media.Imaging;
using Microsoft.VisualStudio.Imaging.Interop;

namespace SampleApp
{
    public class ImageMonikerConverter : IValueConverter
    {
        public object? Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is ImageMoniker imageMoniker)
            {
                // Assume the image resource is in the correct path, use the resource name or logic to get ImageSource.
                return new BitmapImage(new Uri("pack://application:,,,/Resources/SampleIcon.png"));
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
