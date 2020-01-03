using System.Collections.Generic;
using RestSharp;

namespace Leacme.Lib.TVShowAtlas {

	public class SeriesData : ITVDBResource {
		public Series Data { get; set; }
		public Errors Errors { get; set; }

		public static class BuilderSeries {
			public static string GetResource() {
				return "/series/{id}";
			}
			public static Parameter GetIdParameter(long value) {
				return new Parameter("id", value, ParameterType.UrlSegment);
			}
		}

		public static class BuilderSeriesWithFilter {
			public static string GetResource() {
				return "/series/{id}/filter";
			}
			public static Parameter GetIdParameter(long value) {
				return new Parameter("id", value, ParameterType.UrlSegment);
			}
			public static Parameter GetKeysParameter(string value) {
				return new Parameter("keys", value, ParameterType.GetOrPost);
			}
		}
	}

	public class Series {
		public string Added { get; set; }
		public string AirsDayOfWeek { get; set; }
		public string AirsTime { get; set; }
		public List<string> Aliases { get; set; }
		public string Banner { get; set; }
		public string FirstAired { get; set; }
		public List<string> Genre { get; set; }
		public long Id { get; set; }
		public string ImdbId { get; set; }
		public long LastUpdated { get; set; }
		public string Network { get; set; }
		public string NetworkId { get; set; }
		public string Overview { get; set; }
		public string Rating { get; set; }
		public string Runtime { get; set; }
		public string SeriesId { get; set; }
		public string SeriesName { get; set; }
		public long SiteRating { get; set; }
		public long SiteRatingCount { get; set; }
		public string Slug { get; set; }
		public string Status { get; set; }
		public string Zap2ItId { get; set; }
	}

}