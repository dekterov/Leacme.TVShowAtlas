// Copyright (c) 2017 Leacme (http://leac.me). View LICENSE.md for more information.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leacme.Lib.TVShowAtlas {

	public class Library {

		private const string DEFAULT_IMAGE = @"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
					VHwj5ZydhMQAAAABJRU5ErkJggg==";

		public Library() {

		}

		/// <summary>
		///	Downloads the series results.
		/// /// </summary>
		/// <param name="id">Series ID.</param>
		/// <param name="image">Downloaded image.</param>
		/// <param name="name">Series name.</param>
		/// <returns>Downloaded series results.</returns>
		public async Task<List<(long id, byte[] image, string name)>> GetRecentResults() {

			List<(long id, byte[] image, string name)> results = new List<(long id, byte[] image, string name)>();

			var updatedShows = await UpdateData.ExecuteRequest<UpdateData>(UpdateData.BuildRequest(UpdateData.BuilderUpdateData.GetResource()).AddParameter(UpdateData.BuilderUpdateData.GetFromTimeParameter(DateTimeOffset.Now.AddHours(-1).ToUnixTimeSeconds().ToString())));
			foreach (var show in updatedShows.Data) {
				byte[] imgData;
				var seriesImageResults = await SeriesImageQueryResults.ExecuteRequest<SeriesImageQueryResults>(SeriesImageQueryResults.BuildRequest(SeriesImageQueryResults.BuilderImagesQueries.GetResource()).AddParameter(SeriesImageQueryResults.BuilderImagesQueries.GetIdParameter(show.Id)).AddParameter(SeriesImageQueryResults.BuilderImagesQueries.GetKeyTypeParameter("series")));

				if (seriesImageResults.Data?.Any() == true) {
					imgData = await Task.Run(() => ITVDBResource.AnonymousImagesClient.DownloadData(ITVDBResource.BuildRequest(ITVDBResource.AnonymousImagesClient.BaseUrl.ToString() + seriesImageResults.Data.First().FileName)));
				} else {
					imgData = Convert.FromBase64String(DEFAULT_IMAGE);
				}

				var showDetails = await SeriesData.ExecuteRequest<SeriesData>(SeriesData.BuildRequest(SeriesData.BuilderSeries.GetResource()).AddParameter(SeriesData.BuilderSeries.GetIdParameter(show.Id)));
				results.Add((show.Id, imgData, showDetails.Data?.SeriesName));
			}
			return results;
		}
	}
}