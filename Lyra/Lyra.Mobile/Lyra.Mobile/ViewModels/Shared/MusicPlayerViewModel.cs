﻿using Lyra.Mobile.Extensions;
using Lyra.Mobile.Helpers;
using Lyra.Mobile.Services;
using Lyra.Model;
using MediaManager;
using MediaManager.Player;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Lyra.Mobile.ViewModels
{
    public class MusicPlayerViewModel : BaseViewModel
    {
        #region Properties
        private readonly APIService _trackService = new APIService("Track");
        ObservableCollection<Track> trackList;
        public ObservableCollection<Track> TrackList
        {
            get { return trackList; }
            set
            {
                trackList = value;
                OnPropertyChanged();
            }
        }

        private Track selectedTrack;
        public Track SelectedTrack
        {
            get { return selectedTrack; }
            set
            {
                selectedTrack = value;
                OnPropertyChanged();
            }
        }

        private TimeSpan duration;
        public TimeSpan Duration
        {
            get { return duration; }
            set
            {
                duration = value;
                OnPropertyChanged();
            }
        }

        private TimeSpan position;
        public TimeSpan Position
        {
            get { return position; }
            set
            {
                position = value;
                OnPropertyChanged();
            }
        }

        double maximum = 100f;
        public double Maximum
        {
            get { return maximum; }
            set
            {
                if (value > 0)
                {
                    maximum = value;
                    OnPropertyChanged();
                }
            }
        }


        private bool isPlaying;
        public bool IsPlaying
        {
            get { return isPlaying; }
            set
            {
                isPlaying = value;
                OnPropertyChanged(nameof(PlayIcon));
            }
        }

        public ImageSource PlayIcon
        {
            get => isPlaying ? ImageSource.FromResource("Lyra.Mobile.Assets.pause.png", typeof(ImageResourceExtension).GetTypeInfo().Assembly)
                             : ImageSource.FromResource("Lyra.Mobile.Assets.play.png", typeof(ImageResourceExtension).GetTypeInfo().Assembly);
        }
        #endregion

        public MusicPlayerViewModel(ObservableCollection<Track> trackList)
        {
            this.trackList = trackList;

            if(trackList != null)
            {
                PlayTrack(trackList[0].ID);
            }
        }

        

        public ICommand PlayCommand => new Command(Play);
        public ICommand ChangeCommand => new Command(ChangeMusic);


        private async void Play()
        {
            if (isPlaying)
            {
                await CrossMediaManager.Current.Pause();
                IsPlaying = false;
            }
            else
            {
                await CrossMediaManager.Current.Play();
                IsPlaying = true;
            }
        }

        private void ChangeMusic(object obj)
        {
            if ((string)obj == "P")
                PreviousTrack();
            else if ((string)obj == "N")
                NextTrack();
        }

        private async void PlayTrack(int ID)
        {
            SelectedTrack = await _trackService.GetById<Model.Track>(ID);
            var mediaInfo = CrossMediaManager.Current;

            string filename = FileHelper.SaveFile(selectedTrack.MP3File, selectedTrack.Name + Guid.NewGuid() + "mp3");        

            if (!string.IsNullOrEmpty(filename))
            {
                await mediaInfo.Play(filename);

                IsPlaying = true;

                mediaInfo.MediaItemFinished += (sender, args) =>
                {
                    IsPlaying = false;
                    FileHelper.DeleteFile(filename);
                    NextTrack();
                };

                Device.StartTimer(TimeSpan.FromMilliseconds(500), () =>
                {
                    Duration = mediaInfo.Duration;
                    Maximum = duration.TotalSeconds;
                    Position = mediaInfo.Position;
                    return true;
                });

                isPlaying = true;
            }
        }

        private void NextTrack()
        {
            var currentIndex = trackList.Select(i => i.ID).ToList().IndexOf(selectedTrack.ID);

            if (currentIndex < trackList.Count - 1)
            {
                SelectedTrack = trackList[currentIndex + 1];
                PlayTrack(selectedTrack.ID);
            }
        }

        private void PreviousTrack()
        {
            var currentIndex = trackList.Select(i => i.ID).ToList().IndexOf(selectedTrack.ID);

            if (currentIndex > 0)
            {
                SelectedTrack = trackList[currentIndex - 1];
                PlayTrack(selectedTrack.ID);
            }
        }
    }
}