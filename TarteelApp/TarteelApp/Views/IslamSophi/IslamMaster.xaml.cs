using LibVLCSharp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarteelApp.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TarteelApp.Views.IslamSophi
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IslamMaster : ContentPage
    {
        LibVLC _libvlc;
        public IslamMaster(Itemes item)
        {
            InitializeComponent();
            BindingContext = item;
            Core.Initialize();
            _libvlc = new LibVLC();
            var media = new Media(_libvlc, item.link,
            FromType.FromLocation);
            myVideo.MediaPlayer = new MediaPlayer(media) { EnableHardwareDecoding = true };
            myVideo.MediaPlayer.Play();
        }
    }
}