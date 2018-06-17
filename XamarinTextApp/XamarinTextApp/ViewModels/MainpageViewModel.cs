using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;
using XamarinTextApp.Model;

namespace XamarinTextApp.ViewModels
{
    class MainpageViewModel
    {
        public ObservableCollection<Person> Person { get; set; } = new ObservableCollection<Person>();

        public MainpageViewModel()
        {
            for (int i = 0; i < 5; i++)
            {
                Person person = new Person();
                person.Name = "Rahul" + i.ToString();
                person.Address = i.ToString() + "Bhubaneshwar";
            }
        }
    }
}
