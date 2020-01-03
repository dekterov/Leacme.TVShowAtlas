using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace Leacme.Lib.TVShowAtlas {

	public abstract class ITVDBResource {

		public static RestClient AnonymousImagesClient { get; } = new RestClient("https://www.thetvdb.com/banners/");
		public static RestClient Client { get; } = InitClient();

		private static RestClient InitClient() {
			var client = new RestClient("https://api.thetvdb.com");
			client.AddDefaultHeader("Authorization", " Bearer " + (string)((dynamic)JObject.Parse(client.Execute(new RestRequest("login", Method.POST, DataFormat.Json).AddJsonBody(@"{""apikey"":""N6Y4HLINJXLE1Y3A""}")).Content)).token);
			return client;
		}

		public static IRestRequest BuildRequest(string resource, DataFormat dataFormat = DataFormat.Json, Method method = Method.GET) {
			var req = new RestRequest(resource, method, dataFormat);
			return req;
		}

		public async static Task<T> ExecuteRequest<T>(IRestRequest request) {
			return await Task.Run(() => JsonConvert.DeserializeObject<T>(Client.Execute(request).Content));
		}
	}
}