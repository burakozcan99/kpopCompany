using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace kpopCompany
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void OnClicked(object o, EventArgs args)
        {
            await Navigation.PushModalAsync(new Game());
        }
        async void OnClicked_New(object o, EventArgs args)
        {
            await Navigation.PushModalAsync(new newGame());
        }
        async void OnClicked_Wiki(object o, EventArgs args)
        {
            await Navigation.PushModalAsync(new Wiki());
        }
        async void OnClicked_Settings(object o, EventArgs args)
        {
            await Navigation.PushModalAsync(new Settings());
        }
        void OnClicked_Exit(object o, EventArgs args)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }
    }
}
