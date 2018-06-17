using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace XamarinTextApp.ViewModels
{
    // Inheritated INotifyPropertyChanged for 
    class MainpageViewModel : INotifyPropertyChanged
    {
        private string labelText = "hello World!!";
        public string LabelText {
            get{
                return labelText;
            }
            set {
                labelText = value;
                RaisePpropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        //helper method
        protected void RaisePpropertyChanged([CallerMemberName] string caller = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(caller));
        }

        private Command changeTextCommand;
        public Command ChangeTextCommand
        {
            get
            {
                return changeTextCommand ?? (changeTextCommand = new Command(
                    () =>
                    {
                        LabelText = "GoodBye";
                    }));
            }
        }
    }
}
