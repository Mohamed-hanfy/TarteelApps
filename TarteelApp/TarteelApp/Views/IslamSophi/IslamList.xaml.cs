using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarteelApp.Helper;
using TarteelApp.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TarteelApp.Views.IslamSophi
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IslamList : ContentPage
    {
        FirebaseHelper firebaseHelper = new FirebaseHelper();
        public IslamList()
        {
            InitializeComponent();
        }
        protected async override void OnAppearing()
        {

            base.OnAppearing();
            var allItems = await firebaseHelper.GetAllPersons();
            Islamlistes.ItemsSource = allItems;
        }

        private void Islamlistes_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Itemes;
            App.Current.MainPage.Navigation.PushModalAsync(new IslamMaster(item));
        }
    }
}