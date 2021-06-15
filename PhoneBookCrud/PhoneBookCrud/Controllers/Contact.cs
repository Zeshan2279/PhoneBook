using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhoneBookCrud.Controllers
{
    public class Contact
    {
        public String Name
        {
            get; set;
        }
        public DateTime Dob
        {
            get; set;
        }
        public String ContactNumber
        {
            get; set;
        }
        public String Email
        {
            get; set;
        }
        public DateTime SavedOn
        {
            get;set;
        }


    }
}