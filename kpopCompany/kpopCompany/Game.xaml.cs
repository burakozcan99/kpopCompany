using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace kpopCompany
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Game : ContentPage
    {
        public Game()
        {
            InitializeComponent();
        }
        async void OnClicked_Groups(object o, EventArgs args)
        {
            await Navigation.PushModalAsync(new Groups());
        }
        async void OnClicked_Trainees(object o, EventArgs args)
        {
            await Navigation.PushModalAsync(new Trainees());
        }
        async void OnClicked_Back(object o, EventArgs args)
        {
            await Navigation.PushModalAsync(new MainPage());
        }
    }
}