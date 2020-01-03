using System.Collections.Generic;
using RestSharp;

namespace Leacme.Lib.TVShowAtlas {

	public class SeriesEpisodes : ITVDBResource {
		public List<Episode> Data { get; set; }
		public Errors Errors { get; set; }
		public Links Links { get; set; }

		public static class BuilderEpisodes {
			public static string GetResource() {
				return "/series/{id}/episodes";
			}
			public static Parameter GetIdParameter(long value) {
				return new Parameter("id", value, ParameterType.UrlSegment);
			}
			public static Parameter GetPageParameter(string value) {
				return new Parameter("page", value, ParameterType.GetOrPost);
			}
		}

		public static class BuilderEpisodesWithFilter {
			public static string GetResource() {
				return "/series/{id}/episodes/query";
			}
			public static Parameter GetIdParameter(long value) {
				return new Parameter("id", value, ParameterType.UrlSegment);
			}
			public static Parameter GetPageParameter(string value) {
				return new Parameter("page", value, ParameterType.GetOrPost);
			}
			public static Parameter GetAiredSeasonParameter(string value) {
				return new Parameter("airedSeason", value, ParameterType.GetOrPost);
			}
			public static Parameter GetAiredEpisodeParameter(string value) {
				return new Parameter("airedEpisode", value, ParameterType.GetOrPost);
			}
		}

	}
}