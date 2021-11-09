using System;
using System.Collections.Generic;
using System.Text;

namespace mailing
{
    public class Part
    {
        public Part(string Name, string Email)
        {
            this.Name = Name;
            this.Email = Email;
        }

        public Part() { }


        public string Name;
        public string Email;
    }
}
