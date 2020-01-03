// Copyright (c) 2017 Leacme (http://leac.me). View LICENSE.md for more information.
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Avalonia;
using Avalonia.Collections;
using Avalonia.Controls;
using Avalonia.Layout;
using Avalonia.Media;
using Avalonia.Media.Imaging;
using Avalonia.Threading;
using Leacme.Lib.TVShowAtlas;

namespace Leacme.App.TVShowAtlas {

	public class AppUI {

		private StackPanel rootPan = (StackPanel)Application.Current.MainWindow.Content;
		private Library lib = new Library();
		private (StackPanel holder, Carousel carousel, Button left, Button right, DispatcherTimer flipTimer) crs = App.Carousel;

		public AppUI() {
			var searchBar = App.HorizontalFieldWithButton;
			searchBar.holder.HorizontalAlignment = HorizontalAlignment.Center;
			rootPan.Children.Add(searchBar.holder);
			searchBar.label.Text = "Seach TV Shows:";
			searchBar.field.Width = 500;
			searchBar.field.Watermark = "Under Construction";
			searchBar.field.IsReadOnly = true;
			var showSearch = searchBar.holder.Children.OfType<Button>().First();
			searchBar.button.Content = "Search";

			var recentBlurb = App.TextBlock;
			recentBlurb.Text = "Recently updated shows (past hour):";
			recentBlurb.TextAlignment = TextAlignment.Center;
			recentBlurb.Margin = new Thickness(0, 20);
			rootPan.Children.Add(recentBlurb);

			crs.carousel.Height = 375;
			crs.carousel.Width = 600;
			crs.holder.HorizontalAlignment = HorizontalAlignment.Center;
			rootPan.Children.Add(crs.holder);

			Dispatcher.UIThread.InvokeAsync(async () => {
				((App)Application.Current).LoadingBar.IsIndeterminate = true;
				await LoadResults();
				crs.flipTimer.Start();
				((App)Application.Current).LoadingBar.IsIndeterminate = false;
			});

		}

		private async Task LoadResults() {
			foreach (var result in await lib.GetRecentResults()) {
				var img = new Image();
				using (Stream stream = new MemoryStream(result.image)) {
					img.Source = new Bitmap(stream);
				}
				var holder = new StackPanel();
				holder.VerticalAlignment = VerticalAlignment.Center;
				holder.HorizontalAlignment = HorizontalAlignment.Center;
				holder.Margin = App.Margin;
				var seriesName = App.TextBlock;
				seriesName.Text = result.name;
				seriesName.Margin = new Thickness(0, 30);
				seriesName.TextAlignment = TextAlignment.Center;
				seriesName.FontSize = 25;
				seriesName.FontWeight = FontWeight.Heavy;
				holder.Children.AddRange(new List<IControl> { img, seriesName });
				((AvaloniaList<object>)crs.carousel.Items).Add(holder);
			}
		}
	}
}