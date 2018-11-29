using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace prototipo.ViewModel
{
    class principalPageViewModel
    {
        public principalPageViewModel()
        {
            HotelComand = new Command(Hotel);
            RestauranteCommand = new Command(Restaurante);
            EventosSocialesCommand = new Command(SocialesEvents);
            ReunionesNegociosCommand = new Command(NegociosReuniones);

        }

        public async void NegociosReuniones(object obj)
        {

            await App.Current.MainPage.Navigation.PushAsync(new View.principalPage());
        }

        public async void SocialesEvents(object obj)
        {
            await App.Current.MainPage.Navigation.PushAsync(new View.principalPage());
        }

        public async void Restaurante(object obj)
        {
            await App.Current.MainPage.Navigation.PushAsync(new View.principalPage());
        }

        public async void Hotel(object obj)
        {
            await App.Current.MainPage.Navigation.PushAsync(new View.principalPage());
        }



        #region Command
        public Command HotelComand { get; set; }
        public Command RestauranteCommand { get; set; }
        public Command EventosSocialesCommand { get; set; }
        public Command ReunionesNegociosCommand { get; set; }
        #endregion
    }
}
