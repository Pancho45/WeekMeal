using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;

namespace WeekMeal
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class List_Modify : ContentPage
    {
        public List_Modify()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string filename = Path.Combine(path, "liste");

            list_complete.ItemsSource = Directory.GetFiles(filename);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}