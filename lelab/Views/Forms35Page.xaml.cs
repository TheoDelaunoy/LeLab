using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;

namespace lelab.Views
{	
	public partial class Forms35Page : ContentPage
	{	
		public Forms35Page ()
		{
			InitializeComponent ();
            BindingContext = this;
		}

        public ICommand ClickCommand => new Command<string>((url) =>
        {
            //Device.OpenUri(new System.Uri(url));
            Navigation.PushAsync(new WebViewPage(url));
        });

        void ImageButton_Clicked(System.Object sender, System.EventArgs e)
        {
			Console.WriteLine("ImageButtonClicked");
        }
    }
}

