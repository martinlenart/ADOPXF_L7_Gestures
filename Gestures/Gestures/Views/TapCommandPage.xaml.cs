using System;
using System.Collections.Generic;
using Xamarin.Forms;

using Gestures.ViewModels;

namespace Gestures.Views
{	
	public partial class TapCommandPage : ContentPage
	{	
		public TapCommandPage ()
		{
			InitializeComponent ();

			// The TapViewModel contains the TapCommand which is wired up in Xaml
			BindingContext = new TapCommandPageViewModel ();
		}
	}
}

