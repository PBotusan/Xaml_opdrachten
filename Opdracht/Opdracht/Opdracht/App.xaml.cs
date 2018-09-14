using Opdracht.ContactBook;
using Opdracht.DataAcces;
using Opdracht.InstagramClone;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Opdracht
{

    public partial class App : Application
    {

        private const string TitleKey = "Name";
        private const string NotificationEnabledKey = "NotificationEnabled";

        public App()
        {
            InitializeComponent();

            MainPage = new Sqlite.Sqlite();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        public string Title
        {
            get
            {
                if (Properties.ContainsKey(TitleKey))
                   return Properties[TitleKey].ToString();

                return "";
            }

            set
            {
                Properties[TitleKey] = value;
            }
        }


        public bool NotificationsEnabled
        {
            get
            {
                if (Properties.ContainsKey(NotificationEnabledKey))
                    return (bool)Properties[NotificationEnabledKey];

                return false;
            }

            set
            {
                Properties[NotificationEnabledKey] = value;
            }
        }

    }
}
