using System.Collections.Generic;
using RestSharp;

namespace Leacme.Lib.TVShowAtlas {

	public class EpisodeRecordData : ITVDBResource {
		public Episode Data { get; set; }
		public Errors Errors { get; set; }

		public static class BuilderEpisodes {
			public static string GetResource() {
				return "/episodes/{id}";
			}
			public static Parameter GetIdParameter(long value) {
				return new Parameter("id", value, ParameterType.UrlSegment);
			}
		}

	}

	public class Episode {
		public long AbsoluteNumber { get; set; }
		public long AiredEpisodeNumber { get; set; }
		public long AiredSeason { get; set; }
		public long AirsAfterSeason { get; set; }
		public long AirsBeforeEpisode { get; set; }
		public long AirsBeforeSeason { get; set; }
		public string Director { get; set; }
		public List<string> Directors { get; set; }
		public long DvdChapter { get; set; }
		public string DvdDiscid { get; set; }
		public long DvdEpisodeNumber { get; set; }
		public long DvdSeason { get; set; }
		public string EpisodeName { get; set; }
		public string Filename { get; set; }
		public string FirstAired { get; set; }
		public List<string> GuestStars { get; set; }
		public long Id { get; set; }
		public string ImdbId { get; set; }
		public long LastUpdated { get; set; }
		public string LastUpdatedBy { get; set; }
		public string Overview { get; set; }
		public string ProductionCode { get; set; }
		public string SeriesId { get; set; }
		public string ShowUrl { get; set; }
		public long SiteRating { get; set; }
		public long SiteRatingCount { get; set; }
		public string ThumbAdded { get; set; }
		public long ThumbAuthor { get; set; }
		public string ThumbHeight { get; set; }
		public string ThumbWidth { get; set; }
		public List<string> Writers { get; set; }
	}

}