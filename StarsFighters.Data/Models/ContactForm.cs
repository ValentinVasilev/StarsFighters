using System;

namespace StarsFighters.Data.Models
{
    public class ContactForm
    {
        public ContactForm()
        {
            this.Id = new Guid().ToString();
        }
        public string Id { get; set; }

        public int MyProperty { get; set; }
    }
}
