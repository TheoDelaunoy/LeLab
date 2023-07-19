using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace lelab.Views
{
	public class Article
	{
		public String Nom { get; set; }
		public String Prix { get; set; }
		public String Description { get; set; }
	}

	public partial class ListPage : ContentPage
	{
		List<Article> articles;

		public ListPage ()
		{
			InitializeComponent ();
			articles = new List<Article>();
			articles.Add(new Article { Nom = "Lait", Prix = "4 euros", Description = "Pack de lait" });
            articles.Add(new Article { Nom = "Chocolat", Prix = "2.5 euros", Description = "70% de cacao" });
            articles.Add(new Article { Nom = "Pain", Prix = "2 euros", Description = "Baguettes Traditionnelles" });
            articles.Add(new Article { Nom = "Beurre", Prix = "1.2 euros", Description= "Beurre demi-sel" });

			maListeView.ItemsSource = articles;
			maListeView.ItemSelected += (sender, e) =>
			{
				Article item = maListeView.SelectedItem as Article;
				if(maListeView.SelectedItem != null)
				{
					DisplayAlert(item.Nom, item.Description, "OK");
				}
				maListeView.SelectedItem = null;
			}; 
        }
	}
}

