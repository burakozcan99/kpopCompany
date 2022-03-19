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
    public partial class Wiki : ContentPage
    {
        Uri dreamcatcher = new Uri("https://image.kpopmap.com/2020/04/61049d222e8f70bf9987b1aa36dfb0fc.jpg");
        public Wiki()
        {
            InitializeComponent();
            this.BindingContext = new[] { "Dreamcatcher", "A.C.E", "LOONA", "ATEEZ", "Blackpink", "ITZY", "(G)I-DLE", "Red Velvet",
                "Mamamoo", "Everglow", "KARD", "æspa", "SHINee", "Monsta X", "iKON", "BTS", "TWICE"};
        }
        async void OnClicked_Back(object o, EventArgs args)
        {
            await Navigation.PushModalAsync(new MainPage());
        }
    }
}