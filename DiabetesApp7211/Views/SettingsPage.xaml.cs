using System;
using System.Collections.Generic;
using DiabetesApp7211.Models;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace DiabetesApp7211.Views
{
    public partial class SettingsPage : ContentPage
    {

        public SettingsPage()
        {
            InitializeComponent();
            BindingContext = Application.Current;

            //LoadUserData();
        }

        async void Handle_HomeButtonClicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        //void LoadUserData()
        //{
        //    FirstNameEntry.Text = Preferences.Get(First_Name, "defaultValue");
        //}

        //const string FirstNameKey = "firstnamekey";

        //public string First_Name
        //{
        //    get => Preferences.Get(FirstNameKey, "");
        //    set
        //    {
        //        if (First_Name == value)
        //            return;

        //        Preferences.Set(FirstNameKey, value);
        //        OnPropertyChanged(nameof(First_Name));
        //    }
        //}

        //void LoadUserData()
        //{

        //    User user = new User(
        //        FirstNameEntry.Text,
        //        LastNameEntry.Text,
        //        FollowerNameEntry.Text,
        //        FollowerMobileEntry.Text,
        //        NightscoutUrlEntry.Text
        //        );

        //    Application.Current.Properties.Add("fname", user.FirstName);
        //    Application.Current.Properties.Add("lname", user.LastName);
        //}
    }
}

