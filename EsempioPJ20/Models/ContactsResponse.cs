using System;
using System.Collections.Generic;
using System.Text;

namespace EsempioPJ20.Models
{
    class ContactsResponse
    {
        public IEnumerable<Contact> data { get; set; }
    }

    class Contact
    {
        public Guid id { get; set; }
        public string tracerFrom { get; set; }
        public string tracerTo { get; set; }
        public string contactDate { get; set; }
        public int alarm { get; set; }
        public int prealarm { get; set; }
        public string uploadDate { get; set; }
    }
}
