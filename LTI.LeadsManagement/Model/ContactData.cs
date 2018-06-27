using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LTI.LeadsManagement.Model;
using Microsoft.SharePoint;

namespace LTI.LeadsManagement.Model
{
   public  class ContactData
    {
        public IList<Contact> findContacts(string Company)
        {
            var list = SPContext.Current.Web.Lists["ContactList"];
            var q = new SPQuery();
            q.Query = string.Format(@"<Where>
                                        <Eq>
                                        <FieldRef Name='Company' />
                                        <Value Type='Text'>{0}</Value>
                                        </Eq>
                                        </Where>", Company);

            var items = list.GetItems(q).AsQueryable();

            List<Contact> results = new List<Contact>();

            foreach (SPListItem item in items)
            {
                Contact c = new Contact()
                {
                    ID = Convert.ToInt32(item["ID"]),
                    ContactName = item["ContactName"].ToString(),
                    Company= item["Company"].ToString(),
                    Title= item["Title"].ToString(),
                    Email= item["Email"].ToString(),
                    Phone = item["Phone"].ToString(),
                    
                    Mobile = item["Mobile"].ToString(),
                    Department = item["Department"].ToString(),
                    Picture= item["Picture"].ToString(),
                    LinkedInUrl= item[""].ToString(),
                    FacebookUrl = item["FacebookUrl"].ToString(),
                    Notes= item["Notes"].ToString(),
                    Status=(ContactStatus)item["Status"]
                };
            }

            return results;
        }
    }
}
