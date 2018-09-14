using Opdracht.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Opdracht.ContactBook
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Contacts : ContentPage
	{
        private ObservableCollection<ContactDetails> contactsInBook;

        public Contacts ()
		{
			InitializeComponent ();

            listView.ItemsSource = contactsInBook;

            contactsInBook = new ObservableCollection<ContactDetails>
            {
                new ContactDetails{FirstName = "Anna", LastName = "Schoenmaker", Phone = "0228121212154", Email ="anna.shoenmaker@live.nl"},
                new ContactDetails{FirstName = "Julian", LastName = "Koster", Phone = "022812563895", Email ="julian.koster@live.nl"},
                new ContactDetails{FirstName = "Edwin", LastName = "Peper", Phone = "02205690212", Email ="edwin.peper@live.nl"},
                new ContactDetails{FirstName = "Erika", LastName = "Bushnell", Phone = "02283380019", Email ="erika.bushanel@live.nl"},
                new ContactDetails{FirstName = "Merna", LastName = "Kosha", Phone = "022823898210", Email ="anna.shoenmaker@live.nl"},

            };
            listView.ItemsSource = contactsInBook;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
           listView.SelectedItem = null;
        }

        async void Delete_Clicked(object sender, EventArgs e)
        {
            var contact = (sender as MenuItem).CommandParameter as ContactDetails;
            if (await DisplayAlert("Hold up", $"Are you sure you want to delete {contact.FirstName}?", "Yes", "No"))
            contactsInBook.Remove(contact);
        }
    }
}