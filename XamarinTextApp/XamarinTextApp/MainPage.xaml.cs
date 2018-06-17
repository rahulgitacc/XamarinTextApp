using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinTextApp.ViewModels;

namespace XamarinTextApp
{
	public partial class MainPage : ContentPage
	{
        MainpageViewModel viewModel;
		public MainPage()
		{
			InitializeComponent(); 
            // helps to bind the page with viewModel
            BindingContext = new MainpageViewModel(); ; 
		}
	}
}
