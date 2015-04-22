﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using ActiveVB.News.Rss;
using ActiveVB.News.Views;
using Xamarin.Forms;

namespace ActiveVB.News
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			// The root page of your application
			MainPage = new MainView();
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
