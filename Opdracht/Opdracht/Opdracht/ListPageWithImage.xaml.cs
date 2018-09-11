using Opdracht.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Opdracht
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListPageWithImage : ContentPage
	{
		public ListPageWithImage ()
		{
			InitializeComponent ();


            listView2.ItemsSource = new List<ContactGroup>
            {

                new ContactGroup("A")
                {
                       new Contact{Name = "Anna", ImageUrl = "https://lorempixel.com/output/people-q-c-100-100-6.jpg", Status="Hey let's talk" }
                },

                new ContactGroup("J")
                {
                    new Contact{ Name = "Jake", ImageUrl = "https://lorempixel.com/output/people-q-c-100-100-3.jpg", Status="I am a man"},
                        new Contact{Name = "Julian", ImageUrl = "https://lorempixel.com/output/people-q-c-100-100-5.jpg", Status="I Like Fallout"}
                },

                new ContactGroup("P")
                {
                    new Contact{Name = "Paul", ImageUrl = "https://lorempixel.com/output/people-q-c-100-100-2.jpg", Status="Hello There"}
                }
            };


        }

        private void ListView_ItemSelected2(object sender, SelectedItemChangedEventArgs e)
        {
            //var contact = e.SelectedItem as Contact;
            //DisplayAlert("Selected", contact.Name, "OK");
            listView2.SelectedItem = null;
        }

        private void ListView_ItemTapped2(object sender, ItemTappedEventArgs e)
        {
            var contact = e.Item as Contact;
            DisplayAlert("Tapped", contact.Name, "OK");
        }

        private void Call_Clicked2(object sender, System.EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var contact = menuItem.CommandParameter as Contact;

            DisplayAlert("Call", contact.Name, "OK");
        }

        private void Delete_Clicked2(object sender, System.EventArgs e)
        {
            var contact = (sender as MenuItem).CommandParameter as Contact;


        }
    }
}