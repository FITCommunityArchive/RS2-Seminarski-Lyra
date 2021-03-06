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
    public partial class ActivityAlbumsPage : ContentPage
    {
        private ActivityAlbumsViewModel model = null;
        private readonly APIService _service = new APIService("Album");

        public ActivityAlbumsPage()
        {
            InitializeComponent();
            BindingContext = model = new ActivityAlbumsViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private async void Album_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedAlbum = (e.SelectedItem as UserActivityAlbum);
            await Navigation.PushAsync(new AlbumDetailsPage(selectedAlbum.Album));
        }
    }
}