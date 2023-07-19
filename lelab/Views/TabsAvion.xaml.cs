using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace lelab.Views
{	
	public partial class TabsAvion : ContentPage
	{	
		public TabsAvion ()
		{
			InitializeComponent ();
			avionImage.Opacity = 0;
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();
			avionImage.TranslationX = -250;
			avionImage.TranslationY = -150;
			avionImage.Rotation = 45;
			avionImage.Scale = 0.7;
			avionImage.Opacity = 0;

			uint length = 800;

			avionImage.FadeTo(1, 100);
			avionImage.TranslateTo(0, 0, length, Easing.SinOut);
			avionImage.RotateTo(0, length, Easing.SinOut);
			avionImage.ScaleTo(1, length, Easing.SinOut);
        }
    }
}

