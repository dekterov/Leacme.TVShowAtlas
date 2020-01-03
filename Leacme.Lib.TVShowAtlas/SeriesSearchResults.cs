using System.Collections.Generic;
using RestSharp;

namespace Leacme.Lib.TVShowAtlas {

	public class SeriesSearchResults : ITVDBResource {
		public List<SeriesSearchResult> Data { get; set; }

		public static class BuilderSeries {
			public static string GetResource() {
				return "/search/series";
			}
			public static Parameter GetNameParameter(string value) {
				return new Parameter("name", value, ParameterType.UrlSegment);
			}
		}

	}

	public class SeriesSearchResult {
		public List<string> Aliases { get; set; }
		public string Banner { get; set; }
		public string FirstAired { get; set; }
		public long Id { get; set; }
		public string Network { get; set; }
		public string Overview { get; set; }
		public string SeriesName { get; set; }
		public string Slug { get; set; }
		public string Status { get; set; }
	}
}