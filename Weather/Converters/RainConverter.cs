using System;
using System.Globalization;
using Xamarin.Forms;

namespace Weather
{
	public class RainConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (value is double)
			{
				double rainVolume = (double)value;

				ImageSource img = null;
				if (rainVolume == 0)
					img = ImageSource.FromResource("sun.png");
				else if (rainVolume > 10 && rainVolume < 20)
					img = ImageSource.FromResource("/pathToPocaLluvia");
				else
					img = ImageSource.FromResource("/pathToChubascos");
				return img;
			}
			return value;
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
