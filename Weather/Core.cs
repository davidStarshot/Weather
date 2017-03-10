using System;
using System.Linq;
using System.Threading.Tasks;
namespace Weather
{
	public class Core
	{
		public static async Task<RootObject> GetWeather(string city)
		{
			//Sign up for a free API key at http://openweathermap.org/appid
			string key = "87e32935e8b06fadde698295899f5dbe";
			string queryString = "http://api.openweathermap.org/data/2.5/weather?q=" + city + "&units=metric&appid=" + key;

			var results = await DataService.GetDataFromService(queryString);
			if (results != string.Empty)
			{
				RootObject weatherObject = Newtonsoft.Json.JsonConvert.DeserializeObject<RootObject>(results);

				//Weather weather = r.weather.FirstOrDefault();
				//weather.Title = (string)results["name"];
				//weather.Country = (string)results["sys"]["country"];
				//weather.Temperature = (string)results["main"]["temp"] + " ºC";
				//weather.Temp_min = (string)results["main"]["temp"] + " ºC";
				//weather.Temp_max = (string)results["main"]["temp"] + " ºC";
				//weather.Wind = (string)results["wind"]["speed"] + " m/s";
				//weather.Humidity = (string)results["main"]["humidity"] + " %";
				//weather.Rain = (string)results["rain"]["3h"] + " L";
				//weather.Visibility = (string)results["weather"][0]["main"];
				//DateTime time = new System.DateTime(1970, 1, 1, 1, 0, 0, 0);
				//DateTime sunrise = time.AddSeconds((double)results["sys"]["sunrise"]);
				//DateTime sunset = time.AddSeconds((double)results["sys"]["sunset"]);
				//weather.Sunrise = sunrise.ToString();
				//weather.Sunset = sunset.ToString();
				return weatherObject;
			}
			else
			{
				return null;
			}
		}
	}
}
