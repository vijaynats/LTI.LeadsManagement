using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTI.LeadsManagement.Model
{
    public class Contact
    {
        /// <summary>
        /// Contact ID - Unique ListItem ID 
        /// </summary>
        public int ID
        {
            get;set;
        }

        /// <summary>
        /// Name of the Contact
        /// </summary>
        public string ContactName
        {
            get;
            set;
        }

        /// <summary>
        ///  Name of the Company
        /// </summary>
        public string Company
        {
            get;
            set;
        }
        /// <summary>
        /// Designation of the Contact Person
        /// </summary>
        public string Title
        {
            get;
            set;
        }
        /// <summary>
        ///  Email Url Of the Contact Person
        /// </summary>
        public string Email
        {
            get;
            set;
        }
        /// <summary>
        ///PhoneNo of the Contact Person
        /// </summary>
        public string Phone
        {
            get;
            set;
        }
        /// <summary>
        /// MobileNo of the Contact Person
        /// </summary>
        public string Mobile
        {
            get;
            set;
        }
        /// <summary>
        ///Department Name of the Contact Person
        /// </summary>
        public string Department
        {
            get;
            set;
        }
        /// <summary>
        /// Image Url Of the Contact Person 
        /// </summary>
        public string Picture
        {
            get;
            set;
        }
        /// <summary>
        ///LinkedIn Url Of the Contact Person
        /// </summary>
        public string LinkedIn
        {
            get;
            set;
        }
        /// <summary>
        ///Facebook Url oF the Contact Person
        /// </summary>
        public string Facebook
        {
            get;
            set;
        }
        /// <summary>
        /// Twitter Id of the Contact Person
        /// </summary>
        public string Twitter
        {
            get;
            set;
        }
        /// <summary>
        ///  Description of the Contact Person
        /// </summary>
        public string Notes
        {
            get;
            set;
        }

        /// <summary>
        /// Status of the Contact
        /// </summary>
        public ContactStatus Status
        {
            get;
            set;
        }
    }
}
