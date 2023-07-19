using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace lelab.Views
{	
	public partial class WebViewPage : ContentPage
	{	
		public WebViewPage (string url)
		{
			InitializeComponent ();
			webview.Source = url;
		}

        public WebViewPage()
        {
            InitializeComponent();
        }
    }
}

