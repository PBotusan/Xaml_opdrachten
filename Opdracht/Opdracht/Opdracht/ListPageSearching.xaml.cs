using Opdracht.Models;
using System;
using System.Collections.Generic;
using System.Linq;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Opdracht
{


    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListPageSearching : ContentPage
	{
        public ListPageSearching ()
		{
			InitializeComponent ();			
			listView.ItemsSource = GetContacts();
		}



        IEnumerable<Contact> GetContacts(string searchText = null)
        {
            var contacts = new List<Contact>
                    {
                        new Contact{Name = "Anna",  Status="Hey let's talk" },
                        new Contact{ Name = "Jake",  Status="I am a man"},
                        new Contact{Name = "Julian",  Status="I Like Fallout"} ,
                        new Contact{Name = "Paul",  Status="Hello There"}
                    };

            if (String.IsNullOrWhiteSpace(searchText))
                return contacts;

            return contacts.Where(c => c.Name.StartsWith(searchText));

        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			//var contact = e.SelectedItem as Contact;
			//DisplayAlert("Selected", contact.Name, "OK");
			listView.SelectedItem = null;
		}

		private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
		{
			var contact = e.Item as Contact;
			DisplayAlert("Tapped", contact.Name, "OK");
		}

		private void Call_Clicked(object sender, System.EventArgs e)
		{
			var menuItem = sender as MenuItem;
			var contact = menuItem.CommandParameter as Contact;

			DisplayAlert("Call", contact.Name, "OK");
		}

		private void Delete_Clicked(object sender, System.EventArgs e)
		{
			var contact = (sender as MenuItem).CommandParameter as Contact;
			//_contacts.Remove(contact);
		}	

		private void ListView_Refreshing(object sender, EventArgs e)
		{
            // listView.ItemsSource = (); 
            //listView.EndRefresh();
		}

        void SearchBarList_TextChanged(object sender, TextChangedEventArgs e)
        {
            listView.ItemsSource = GetContacts(e.NewTextValue);
        }

      
    }
}