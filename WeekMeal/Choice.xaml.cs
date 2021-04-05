using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WeekMeal
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Choice : ContentPage
    {
        public Choice()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        private void Stepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            value_stepper.Text = stepper.Value.ToString(); //Incrementation stepper and display
        }

        private void list_choice_recipe_Scrolled(object sender, ScrolledEventArgs e)
        {
            
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new List_Modify());
        }
    }
}