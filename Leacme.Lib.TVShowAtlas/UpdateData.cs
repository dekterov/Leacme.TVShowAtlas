using System.Collections.Generic;
using RestSharp;

namespace Leacme.Lib.TVShowAtlas {
	public class UpdateData : ITVDBResource {
		public List<Update> Data { get; set; }
		public Errors Errors { get; set; }

		public static class BuilderUpdateData {
			public static string GetResource() {
				return "/updated/query";
			}
			public static Parameter GetFromTimeParameter(string value) {
				return new Parameter("fromTime", value, ParameterType.GetOrPost);
			}
			public static Parameter GetToTimeParameter(string value) {
				return new Parameter("toTime", value, ParameterType.GetOrPost);
			}
		}
	}

	public class Update {
		public long Id { get; set; }
		public long LastUpdated { get; set; }
	}

}