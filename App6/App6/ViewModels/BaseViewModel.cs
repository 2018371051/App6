using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace App6.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {


        public INavigation Navigation { get; set; }
        public BaseViewModel(INavigation navigation)
        {
            Navigation = navigation ?? App.Navigation;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
