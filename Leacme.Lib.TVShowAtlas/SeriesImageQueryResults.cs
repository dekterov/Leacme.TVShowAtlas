using System.Collections.Generic;
using RestSharp;

namespace Leacme.Lib.TVShowAtlas {
	public class SeriesImageQueryResults : ITVDBResource {
		public List<SeriesImageQueryResult> Data { get; set; }
		public Errors Errors { get; set; }


		public static class BuilderImagesQueries {
			public static string GetResource() {
				return "/series/{id}/images/query";
			}
			public static Parameter GetIdParameter(long value) {
				return new Parameter("id", value, ParameterType.UrlSegment);
			}
			public static Parameter GetKeyTypeParameter(string value) {
				return new Parameter("keyType", value, ParameterType.GetOrPost);
			}
			public static Parameter GetResolutionParameter(string value) {
				return new Parameter("resolution", value, ParameterType.GetOrPost);
			}
			public static Parameter GetSubKeyParameter(string value) {
				return new Parameter("subKey", value, ParameterType.GetOrPost);
			}
		}

	}

	public class SeriesImageQueryResult {
		public string FileName { get; set; }
		public long Id { get; set; }
		public string KeyType { get; set; }
		public long LanguageId { get; set; }
		public RatingsInfo RatingsInfo { get; set; }
		public string Resolution { get; set; }
		public string SubKey { get; set; }
		public string Thumbnail { get; set; }
	}

	public class RatingsInfo {
		public long Average { get; set; }
		public long Count { get; set; }
	}


}