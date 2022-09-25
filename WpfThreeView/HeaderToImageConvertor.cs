using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace WpfThreeView
{
    /// <summary>
    /// Convert a full path to a specific image type of a drive, folder or file
    /// </summary>
    [ValueConversion(typeof(string),typeof(BitmapImage))]
    public class HeaderToImageConvertor : IValueConverter
    {
        public static HeaderToImageConvertor Instance = new HeaderToImageConvertor();
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Get the full path
            var path = (string)value;

            // If get the full path is null, ignur
            if (path == null)
                return null;

            // By default, we presume an image
            var image = "Image/file.png";
            return new BitmapImage(new Uri($"pack://application:,,,/{image}"));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
