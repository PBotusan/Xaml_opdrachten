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
	public partial class ActivityFeedPage : ContentPage
	{
        private List<Activity> activity;
        private List<Activity> user;

        public ActivityFeedPage ()
		{
			InitializeComponent ();



            listView.ItemsSource = activity;
            

            activity = new List<Activity>
            {
                new Activity { Name = "Anna", ImageUrl = "https://lorempixel.com/output/people-q-c-100-100-6.jpg", Description ="Hello my name is Anna" },
                new Activity { Name = "Edwin", ImageUrl = "https://lorempixel.com/output/people-q-c-100-100-8.jpg", Description ="Hello i am using this app"},
                new Activity { Name = "Skwena", ImageUrl = "https://lorempixel.com/output/people-q-c-100-100-4.jpg", Description ="Hello  everyone" },
                new Activity { Name = "Julian", ImageUrl = "https://lorempixel.com/output/people-q-c-100-100-3.jpg", Description=" my name is Fallout" },
                new Activity { Name = "AB", ImageUrl = "https://lorempixel.com/output/people-q-c-100-100-2.jpg", Description="Hello my name is Anna" },
                new Activity { Name = "kulian", ImageUrl = "https://lorempixel.com/output/people-q-c-100-100-1.jpg", Description="Hello my name is Kuljar" },
                new Activity { Name = "Blondlashes", ImageUrl = "https://lorempixel.com/output/people-q-c-100-100-9.jpg", Description="follow my instagram" },
                new Activity { Name = "Patricia", ImageUrl = "https://lorempixel.com/output/people-q-c-100-100-7.jpg", Description="Patricia kwaai" }

            };

            listView.ItemsSource = activity;
        }


        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
         
                var activity = e.SelectedItem as Activity;
                //Navigation.PopAsync(new FriendProfilePage(activity));

        }
    }
}