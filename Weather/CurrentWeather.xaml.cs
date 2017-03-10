using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Weather
{
	public partial class CurrentWeather : ContentPage
	{
		public CurrentWeather()
		{
			InitializeComponent();
		}

		async void Handle_Clicked(object sender, System.EventArgs e)
		{
			if (!String.IsNullOrEmpty(cityEntry.Text))
			{
				RootObject weatherObject = await Core.GetWeather(cityEntry.Text);
				if (weatherObject!= null)
				{
					this.BindingContext = new CurrentWeatherModel(weatherObject);
				}
			}
		}
	}
}
