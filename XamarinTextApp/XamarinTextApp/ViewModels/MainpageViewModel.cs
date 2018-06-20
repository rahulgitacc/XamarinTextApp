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
            for (int i = 1; i < 6; i++)
            {
                Person person = new Person();
                person.FirstName = "Rahul" + i.ToString();
                person.LastName = "Sen" + i.ToString();
                person.Address = i.ToString() + "Bhubaneshwar";
                person.ImageSource = "image" + i + ".png";
                Person.Add(person);
            }
        }
    }
}
