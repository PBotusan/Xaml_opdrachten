using Opdracht.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Opdracht.MasterDetailPage
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContactsPage : ContentPage
	{
		public ContactsPage ()
		{
			InitializeComponent ();

            listView.ItemsSource = new List<Contact>
            {
                new Contact{Name = "Anna", Status="Hey let's talk" },
                new Contact{Name = "Julian", Status="Hey ik ben het" },
                new Contact{Name = "Patty", Status="let's talk about life" },
                new Contact{Name = "Paul", Status="Hello there" },
                new Contact{Name = "Coen de Moon", Status="General Kenobi" }
            };
		}

        async void Listview_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            var contact = e.SelectedItem as Contact;
            await Navigation.PushAsync(new ContactDetailPage(contact));
            listView.SelectedItem = null;
        }
    }
}