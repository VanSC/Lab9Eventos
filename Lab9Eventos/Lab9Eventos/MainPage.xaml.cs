using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lab9Eventos
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            TapDemo.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new TapDemo());
            };
            PanDemo.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new PanDemo());
            };
            PinchDemo.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new PinchDemo());
            };
            SwipedDemo.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new SwipeDemo());
            };
        }
    }
}
