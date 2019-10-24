using System;
using System.Collections.Generic;

using Xamarin.Forms;

using Xamarin.Essentials;

namespace DiabetesApp7211.Views
{
    public partial class FindCarbsPage : ContentPage
    {
        public FindCarbsPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        void Handle_HomeButtonClicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new MainPage());
        }

        private async void ButtonOpenMaps_Clicked(object sender, System.EventArgs e)
        {
            try
            {
                var request = new GeolocationRequest(GeolocationAccuracy.High);
                var location = await Geolocation.GetLocationAsync(request);

                if (location != null)
                {
                    Console.WriteLine($"Latitude: {location.Latitude}, Longitude: {location.Longitude}, Altitude: {location.Altitude}");
                    var lat = location.Latitude;
                    var lng = location.Longitude;
                    await Map.OpenAsync(lat, lng, new MapLaunchOptions
                    {
                        Name = "You are here",
                        NavigationMode = NavigationMode.None
                    });
                }
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                await DisplayAlert("Error", "Feature not supported on this device", "OK");
            }
            catch (FeatureNotEnabledException fneEx)
            {
                await DisplayAlert("Error", "Geolocation not enabled on this device", "OK");
            }
            catch (PermissionException pEx)
            {
                await DisplayAlert("Error", "Permission denied", "OK");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.ToString(), "OK");
            }

        }
    }
}
