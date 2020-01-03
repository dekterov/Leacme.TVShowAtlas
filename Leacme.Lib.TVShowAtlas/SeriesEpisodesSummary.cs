using System.Collections.Generic;
using RestSharp;

namespace Leacme.Lib.TVShowAtlas {

	public class SeriesEpisodesSummary : ITVDBResource {
		public string AiredEpisodes { get; set; }
		public List<string> AiredSeasons { get; set; }
		public string DvdEpisodes { get; set; }
		public List<string> DvdSeasons { get; set; }

		public static class BuilderEpisodeSummaries {
			public static string GetResource() {
				return "/series/{id}/episodes/summary";
			}
			public static Parameter GetIdParameter(long value) {
				return new Parameter("id", value, ParameterType.UrlSegment);
			}
		}
	}
}