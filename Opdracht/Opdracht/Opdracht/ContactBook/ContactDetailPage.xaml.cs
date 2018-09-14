using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Opdracht.ContactBook
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContactDetailPage : ContentPage
	{
		public ContactDetailPage()
		{
			InitializeComponent ();
		}

        private void SaveButton_Clicked(object sender, EventArgs e)
        {
            if (firstName == null)
            {
                DisplayAlert("Invalid input", "You must enter firstName", "OK");
                return;
            }
            else
            {
                
            }
        }
    }
}