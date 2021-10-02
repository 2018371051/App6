using App6.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App6.ViewModels
{
    internal class PaginaInicioViewModel : BaseViewModel
    {
        Command _goToDetails;
        Command _logOut;

       

        public PaginaInicioViewModel(INavigation navigation = null) : base(navigation)
        {
        }
        public Command GoToDetailsCommand { get => _goToDetails ?? (_goToDetails = new Command(GoToDetailsAction)); }
        public Command LogOutCommand { get => _logOut ?? (_logOut = new Command(() => Navigation.PopToRootAsync())); }

        private void GoToDetailsAction()
        {
            Navigation.PushAsync(new DetailsPage());
        }
    }
}
