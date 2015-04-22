using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ActiveVB.News.Models;
using ActiveVB.News.Rss;
using Xamarin.Forms;

namespace ActiveVB.News.ViewModels
{
	public class MainViewModel : BaseViewModel
	{
		private const string FeedUri = "http://www.activevb.de/news/";

		private bool _isActivityIndicatorVisible;

		public bool IsActivityIndicatorVisible
		{
			get { return _isActivityIndicatorVisible; }
			set { Set(ref _isActivityIndicatorVisible, value); }
		}

		private ObservableCollection<RssFeedItem> _feed;

		public ObservableCollection<RssFeedItem> Feed
		{
			get { return _feed; }
			set { Set(ref _feed, value); }
		}

		private RssFeedItem _selectedItem;

		public RssFeedItem SelectedItem
		{
			get { return _selectedItem; }
			set
			{
				OnItemSelected(value);
				Set(ref _selectedItem, value);
			}
		}

		private void OnItemSelected(RssFeedItem item)
		{
			if(item != null)
			{
				Device.OpenUri(item.Link);
			}
		}

		public async void Update()
		{
			IsActivityIndicatorVisible = true;
			Feed = new ObservableCollection<RssFeedItem>(await RssClient.Load(new Uri(FeedUri)));
			IsActivityIndicatorVisible = false;
		}
	}
}
