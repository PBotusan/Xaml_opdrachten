using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht.Models
{
    class ContactGroup : List<Contact>
    {
        public string Title { get; set; }

        public ContactGroup(string title)
        {
            Title = title;
        }
    }
}
