﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App2
{
	public class App : Application
	{
		public App()
		{
			MainPage = new TabbedPage1();
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
