using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinTextApp.Model;
using XamarinTextApp.ViewModels;

namespace XamarinTextApp
{
	public partial class MainPage : ContentPage
	{        
		public MainPage()
		{
			InitializeComponent(); 
            // helps to bind the page with viewModel
            //BindingContext = new MainpageViewModel();
		}        

        private void SelectListView(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return;
            }

            Person person = e.SelectedItem as Person;
            DisplayAlert("Selected Item", person.FirstName + ": " + person.LastName, "Close");
        }
    }
}
