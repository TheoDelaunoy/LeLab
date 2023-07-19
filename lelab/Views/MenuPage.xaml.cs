using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace lelab.Views
{	
	public partial class MenuPage : ContentPage
	{	
		public MenuPage ()
		{
			InitializeComponent ();
		}

        void Compteur_Button_Clicked(System.Object sender, System.EventArgs e)
        {
			this.Navigation.PushAsync(new CountPage());
        }

        void Tabs_Button_Clicked(System.Object sender, System.EventArgs e)
        {
            this.Navigation.PushAsync(new TabsPage());
        }

        void Liste_Button_Clicked(System.Object sender, System.EventArgs e)
        {
            this.Navigation.PushAsync(new ListPage());
        }

        void News_Button_Clicked(System.Object sender, System.EventArgs e)
        {
            this.Navigation.PushAsync(new Forms35Page());
        }
    }
}

