using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;
using Acr.UserDialogs;

namespace TarteelApp
{
    public partial class MainPage : Xamarin.Forms.Shell
    {
        public MainPage()
        {
            InitializeComponent();
            var current = Connectivity.NetworkAccess;

            if (current == NetworkAccess.Internet)
            {
                UserDialogs.Instance.HideLoading();
            }
            else
            {
                UserDialogs.Instance.ShowLoading("في انتظار الاتصال بالانترنت وقم بفتح التطبيق مرة اخري");
            }
        }


    // Handle exception here.



    }
}
