using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Opdracht
{
    public class ContactMethod
    {
        public int Id { get; set;}
        public string Name { get; set;}
    }

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FormsPage : ContentPage
    {


        public FormsPage()
        {
            InitializeComponent();

            picker.ItemsSource = GetContactMethods();

        }

        private void Switch_Toggled(object sender, ToggledEventArgs e)
        {
            label.IsVisible = e.Value;
        }

        private IList<ContactMethod> _contactMethods;

        void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {

            var item = picker.SelectedItem as ContactMethod;
            DisplayAlert("Picker", $"{item.Name} {item.Id}", "Ok");
        }

        private List<ContactMethod> GetContactMethods()
        {
            return new List<ContactMethod>
            {
                new ContactMethod { Id= 1, Name = "SMS"},
                new ContactMethod { Id= 2, Name = "Email"},
                new ContactMethod { Id= 3, Name = "Fax"},
                new ContactMethod { Id= 4, Name = "Call"},
                new ContactMethod { Id= 5, Name = "Letter"},
            };

        }

        private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {
            
        }
    }
}