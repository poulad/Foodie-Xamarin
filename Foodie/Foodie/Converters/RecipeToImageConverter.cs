using System;
using System.Globalization;
using Xamarin.Forms;

namespace Foodie.Converters
{
    public class RecipeToImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string imageName = value as string;
            if (string.IsNullOrWhiteSpace(imageName))
            {
                return null;
            }

            var img = ImageSource.FromResource("Foodie.Images." + imageName);
            return img;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
