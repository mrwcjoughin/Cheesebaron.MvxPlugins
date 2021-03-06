﻿using Xamarin.Forms;

namespace FormsPresenters.Sample.Pages
{
    public class MainPage : ContentPage
    {
        public MainPage()
        { 
            var content = new StackLayout
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            var label = new Label();
            label.SetBinding(Label.TextProperty, "Hello");

            var entry = new Entry();
            entry.SetBinding(Entry.TextProperty, "Hello");

            content.Children.Add(label);
            content.Children.Add(entry);

            Content = content;
        }
    }
}
