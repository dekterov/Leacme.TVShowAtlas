using RestSharp;

namespace Leacme.Lib.TVShowAtlas {

	public class SeriesImagesCounts : ITVDBResource {
		public SeriesImagesCount Data { get; set; }

		public static class BuilderSeriesImages {
			public static string GetResource() {
				return "/series/{id}/images";
			}
			public static Parameter GetIdParameter(long value) {
				return new Parameter("id", value, ParameterType.UrlSegment);
			}
		}
	}

	public class SeriesImagesCount {
		public long Fanart { get; set; }
		public long Poster { get; set; }
		public long Season { get; set; }
		public long Seasonwide { get; set; }
		public long Series { get; set; }
	}
}