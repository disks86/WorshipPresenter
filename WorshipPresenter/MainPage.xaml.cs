﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Media.Core;
using Windows.Media.Playback;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.UI;
using Windows.UI.Core;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace WorshipPresenter
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        int mWindowId = ApplicationView.GetForCurrentView().Id;

        CoreApplicationView mMediaPlayerWindow = CoreApplication.CreateNewView();
        Frame mMediaPlayerFrame = null;
        int mMediaPlayerWindowId = 0;

        internal SelectedMediaType SelectedMediaType { get; set; } = SelectedMediaType.None;

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs eventArgs)
        {
            Application.Current.Exit();
        }

        private async void Page_Loaded(object sender, RoutedEventArgs eventArgs)
        {
            await mMediaPlayerWindow.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                mMediaPlayerFrame = new Frame();
                mMediaPlayerFrame.Navigate(typeof(MediaPlayerPage), null);

                Window.Current.Content = mMediaPlayerFrame;
                Window.Current.Activate();
                ApplicationView.GetForCurrentView().Title = "Media Player";

                mMediaPlayerWindowId = ApplicationView.GetForCurrentView().Id;
            });
        }

        private async void OpenFileButton_Click(object sender, RoutedEventArgs eventArgs)
        {
            var openPicker = new FileOpenPicker();
            openPicker.FileTypeFilter.Add(".mp4");

            StorageFile file = await openPicker.PickSingleFileAsync();
            if (file != null)
            {
                await mMediaPlayerWindow.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
                {
                    Frame mediaPlayerFrame = Window.Current.Content as Frame;
                    MediaPlayerPage mediaPlayerPage = mediaPlayerFrame.Content as MediaPlayerPage;
                    Grid grid = mediaPlayerPage.Content as Grid;
                    var mediaElement = grid.FindName("MainMediaPlayer") as MediaElement;
                    mediaElement.AutoPlay = false;
                    mediaElement.SetPlaybackSource(MediaSource.CreateFromStorageFile(file));
                    SelectedMediaType = SelectedMediaType.VideoFile;
                });


                bool available = ProjectionManager.ProjectionDisplayAvailable;

                ProjectionManager.ProjectionDisplayAvailableChanged += (s, e) =>
                {
                    available = ProjectionManager.ProjectionDisplayAvailable;
                };

                await ProjectionManager.StartProjectingAsync(mMediaPlayerWindowId, mWindowId);
            }


        }

        private async void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            switch (SelectedMediaType)
            {
                case SelectedMediaType.VideoFile:
                    await mMediaPlayerWindow.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
                    {
                        Frame mediaPlayerFrame = Window.Current.Content as Frame;
                        MediaPlayerPage mediaPlayerPage = mediaPlayerFrame.Content as MediaPlayerPage;
                        Grid grid = mediaPlayerPage.Content as Grid;
                        var mediaElement = grid.FindName("MainMediaPlayer") as MediaElement;
                        mediaElement.Play();
                    });
                    break;
                default:
                    //TODO: handle
                    break;
            }   
        }

        private async void PauseButton_Click(object sender, RoutedEventArgs e)
        {
            switch (SelectedMediaType)
            {
                case SelectedMediaType.VideoFile:
                    await mMediaPlayerWindow.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
                    {
                        Frame mediaPlayerFrame = Window.Current.Content as Frame;
                        MediaPlayerPage mediaPlayerPage = mediaPlayerFrame.Content as MediaPlayerPage;
                        Grid grid = mediaPlayerPage.Content as Grid;
                        var mediaElement = grid.FindName("MainMediaPlayer") as MediaElement;
                        mediaElement.Pause();
                    });
                    break;
                default:
                    //TODO: handle
                    break;
            }
        }

        private async void StopButton_Click(object sender, RoutedEventArgs e)
        {
            switch (SelectedMediaType)
            {
                case SelectedMediaType.VideoFile:
                    await mMediaPlayerWindow.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
                    {
                        Frame mediaPlayerFrame = Window.Current.Content as Frame;
                        MediaPlayerPage mediaPlayerPage = mediaPlayerFrame.Content as MediaPlayerPage;
                        Grid grid = mediaPlayerPage.Content as Grid;
                        var mediaElement = grid.FindName("MainMediaPlayer") as MediaElement;
                        mediaElement.Stop();
                    });
                    break;
                default:
                    //TODO: handle
                    break;
            }
        }
    }
}