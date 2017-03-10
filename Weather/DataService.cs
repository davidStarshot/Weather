using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace Weather
{
	public class DataService
	{
		public static async Task<string> GetDataFromService(string queryString)
		{
			HttpClient client = new HttpClient();
			var response = await client.GetAsync(queryString);

			string json;
			if (response != null)
			{
				json = await response.Content.ReadAsStringAsync();
				//data = (JContainer)JsonConvert.DeserializeObject(json);
			}
			else
				return string.Empty;

			return json;
		}
	}
}