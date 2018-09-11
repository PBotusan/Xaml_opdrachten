using Opdracht.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Opdracht
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListOpdracht : ContentPage
	{
		public ListOpdracht ()
		{
			InitializeComponent ();
            listView.ItemsSource = GetSearches();
        }

        private IEnumerable GetSearches(string searchText = null)
        {
            var locations = new List<Search>
            {
                new Search{Id = 1, Location = "West Hollywood, CA, United States", CheckIn = "11/2/2018", CheckOut = "11/4/2018"},
                new Search{Id = 2, Location = "Wervershoof, NH, Nederland", CheckIn = "11/4/2018", CheckOut = "11/4/2020"},
                new Search{Id = 3, Location = "Hoorn, NH, Nederland", CheckIn = "11/2/2018", CheckOut = "11/4/2018"},
                new Search{Id = 4, Location = "West Gronja, CO, United States", CheckIn = "1/2/2018", CheckOut = "11/8/2018"},
                new Search{Id = 5, Location = "Colorado, CO, United States", CheckIn = "7/2/2018", CheckOut = "11/9/2018"},
                new Search{Id = 6, Location = "GrooteBroek, NH, Nederland", CheckIn = "11/2/2038", CheckOut = "11/4/2099"},
                new Search{Id = 7, Location = "East Hollywood, CA, United States", CheckIn = "11/2/2015", CheckOut = "11/4/2080"},
                new Search{Id = 8, Location = "South Hollywood, CA, United States", CheckIn = "3/2/2019", CheckOut = "61/4/3018"},
                new Search{Id = 9, Location = "North Hollywood, CA, United States", CheckIn = "2/2/2019", CheckOut = "11/4/4018"},
                new Search{Id = 10, Location = "North/West Hollywood, CA, United States", CheckIn = "11/2/2018", CheckOut = "11/4/2018"}
            };
            if (String.IsNullOrWhiteSpace(searchText))
                return locations;

            return locations.Where(c => c.Location.StartsWith(searchText));
        }

        private void SearchbarList_TextChanged(object sender, TextChangedEventArgs e)
        {
            listView.ItemsSource = GetSearches(e.NewTextValue);
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var search = e.Item as Search;
            DisplayAlert("Good choice", search.Location, "OK");
        }

        private void MenuItem_Delete(object sender, EventArgs e)
        {
            var contact = (sender as MenuItem).CommandParameter as Contact;
        }
    }
}