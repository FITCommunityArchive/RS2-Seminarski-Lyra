﻿using Lyra.Mobile.ViewModels;
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
    public partial class ActivityPlaylistsPage : ContentPage
    {
        private ActivityPlaylistsViewModel model = null;

        public ActivityPlaylistsPage()
        {
            InitializeComponent();
            BindingContext = model = new ActivityPlaylistsViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }
    }
}