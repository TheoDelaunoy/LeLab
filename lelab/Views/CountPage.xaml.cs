using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace lelab.Views
{	
	public partial class CountPage : ContentPage
	{

        int counter= 0;

        public CountPage ()
		{
			InitializeComponent ();
		}

        void CountButtonClick(System.Object sender, System.EventArgs e)
        {
			counter++;
			countLabel.Text = counter.ToString();
        }
    }
}