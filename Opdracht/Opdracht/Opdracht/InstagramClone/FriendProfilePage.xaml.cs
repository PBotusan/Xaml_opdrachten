using Opdracht.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Opdracht.InstagramClone
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FriendProfilePage : ContentPage
	{
		public FriendProfilePage (Activity activity)
		{
            if (activity == null)
                throw new ArgumentException();

            BindingContext = activity;

            InitializeComponent();
        }
	}
}