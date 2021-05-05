using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarteelApp.Views.IslamSophi;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TarteelApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();

            
        }

        private void Islamsophie_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage.Navigation.PushAsync(new IslamList());
        }
    }
}