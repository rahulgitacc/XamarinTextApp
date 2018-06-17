using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinTextApp.ViewModels
{
    class MainpageViewModel
    {
        public string Prompt { get; set; }
        public string Name { get; set; }
        public MainpageViewModel()
        {
            Prompt = "Full Name:";
            Name = "Rahul";
        }
    }
}
