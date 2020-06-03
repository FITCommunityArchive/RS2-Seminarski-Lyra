﻿using Lyra.Mobile.Services;
using Lyra.Mobile.ViewModels;
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
    public partial class YourMusicPlaylistsPage : ContentPage
    {
        private YourMusicPlaylistsViewModel model = null;
        private readonly APIService _service = new APIService("Playlist");
        public YourMusicPlaylistsPage()
        {
            InitializeComponent();
            BindingContext = model = new YourMusicPlaylistsViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        async void OnTapped(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new NewPlaylistPage());
        }

        private async void Playlist_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedPlaylist = (e.SelectedItem as Playlist);
            await Navigation.PushAsync(new PlaylistDetailsPage(selectedPlaylist));
        }
    }
}