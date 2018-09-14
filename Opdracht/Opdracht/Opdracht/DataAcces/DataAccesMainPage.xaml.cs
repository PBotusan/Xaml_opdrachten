using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Opdracht.DataAcces
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DataAccesMainPage : ContentPage
    {

        public DataAccesMainPage()
        {
            InitializeComponent();

            BindingContext = Application.Current;

            var app = Application.Current as App;

        }


        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
    }
}