using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTI.LeadsManagement.Model
{
    public class Company
    {
        public int ID
        {
            get;
            set;
        }
        public string CompanyName
        {
            get;
            set;
        }
        public string Category
        {
            get;
            set;
        }
        public string Address
        {
            get;
            set;
        }
        public string City
        {
            get;
            set;
        }
        public string PostalCode
        {
            get;
            set;
        }
        public string State
        {
            get;
            set;
        }
        public string Website
        {
            get;
            set;
        }
        public string Phone
        {
            get;
            set;
        }
        public string Fax
        {
            get;
            set;
        }
        public string Email
        {
            get;
            set;
        }
        public ContactStages Stage
        {
            get;
            set;
        }
        public string Notes
        {
            get;
            set;
        }

        //public IList<Contact> AllContacts
        //{
        //    get; set;
        //}

    }
}
