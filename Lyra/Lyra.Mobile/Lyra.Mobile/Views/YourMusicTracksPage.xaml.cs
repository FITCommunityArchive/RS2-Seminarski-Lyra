﻿using Lyra.Mobile.ViewModels;
using Lyra.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lyra.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class YourMusicTracksPage : ContentPage
    {
        private YourMusicTracksViewModel model = null;
        public YourMusicTracksPage()
        {
            InitializeComponent();
            BindingContext = model = new YourMusicTracksViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private async void Track_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var trackVM = (e.SelectedItem as TrackViewModel);
            await Navigation.PushAsync(new MusicPlayerPage(new List<Track> { trackVM.Track }));
        }
    }
}