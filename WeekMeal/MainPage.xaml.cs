using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WeekMeal
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void button_recipe_Pressed(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Choice());
        }
        private async void button_list_Pressed(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new List_Modify());
        }

        private void quit_pressed(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
