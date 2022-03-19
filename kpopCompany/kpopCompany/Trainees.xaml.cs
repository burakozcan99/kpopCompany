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
    public partial class Trainees : ContentPage
    {
        public Trainees()
        {
            InitializeComponent();
        }
        async void OnClicked_Back(object o, EventArgs args)
        {
            await Navigation.PushModalAsync(new Game());
        }
    }
}