using System;

using Xamarin.Forms;

namespace DiabetesApp7211.Extensions
{
    public class EmergencyButton : ContentPage
    {
        public EmergencyButton()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

