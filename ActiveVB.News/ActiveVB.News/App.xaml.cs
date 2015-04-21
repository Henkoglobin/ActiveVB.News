using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using ActiveVB.News.Rss;
using Xamarin.Forms;

namespace ActiveVB.News
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			// The root page of your application
			MainPage = new ContentPage
			{
				Content = new StackLayout
				{
					VerticalOptions = LayoutOptions.Center,
					Children = {
						new Label {
							XAlign = TextAlignment.Center,
							Text = "Welcome to Xamarin Forms!"
						},
						new Button
						{
							Text= "Laden",
							Command = new Command(async () => {
								var client = new RssClient();
								var items = await client.Load(new Uri("http://www.activevb.de/news/"));
								Debugger.Break();
							})
						}
					}
				}
			};
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
