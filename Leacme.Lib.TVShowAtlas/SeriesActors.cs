using System.Collections.Generic;
using RestSharp;

namespace Leacme.Lib.TVShowAtlas {

	public class SeriesActors : ITVDBResource {
		public List<SeriesActorsData> Data { get; set; }
		public Errors Errors { get; set; }

		public static class BuilderActors {
			public static string GetResource() {
				return "/series/{id}/actors";
			}
			public static Parameter GetIdParameter(long value) {
				return new Parameter("id", value, ParameterType.UrlSegment);
			}
		}
	}

	public class SeriesActorsData {
		public long Id { get; set; }
		public string Image { get; set; }
		public string ImageAdded { get; set; }
		public long ImageAuthor { get; set; }
		public string LastUpdated { get; set; }
		public string Name { get; set; }
		public string Role { get; set; }
		public long SeriesId { get; set; }
		public long SortOrder { get; set; }
	}

}