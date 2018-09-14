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
	public partial class ContactsBookMainPage : TabbedPage
	{
		public ContactsBookMainPage ()
		{
			InitializeComponent ();
		}
	}
}