using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace lelab.Views
{	
	public partial class TabsVoiture : ContentPage
	{	
		public TabsVoiture ()
		{
			InitializeComponent ();
            voitureImage.Opacity = 0;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
			voitureImage.Opacity = 0;
            voitureImage.TranslationX = -100;
			voitureImage.FadeTo(1, 1000);
            voitureImage.TranslateTo(0, 0, 2000, Easing.SinOut);
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            voitureImage.Opacity = 0;
            voitureImage.TranslationX = -100;
        }
    }
}

