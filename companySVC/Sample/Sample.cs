using System;
using System.Security.Permissions;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Utilities;
using Microsoft.SharePoint.Workflow;
using System.Collections.Specialized;
using LTI.LeadsManagement.Util;
namespace LTI.LeadsManagement.Sample
{
    /// <summary>
    /// List Item Events
    /// </summary>
    public class Sample : SPItemEventReceiver
    {
        /// <summary>
        /// An item was added.
        /// </summary>
        public override void ItemAdded(SPItemEventProperties properties)
        {
            base.ItemAdded(properties);
            try
            {


                using (SPSite Site = new SPSite("http://leads.trg10.int"))  //Site collection URL
                {
                    using (SPWeb web = Site.RootWeb)  //Subsite URL
                    {
                        SPList list = properties.Web.Lists["Companies"];
                        SPListItem item = list.GetItemById(properties.ListItemId);
                        StringDictionary headers = new StringDictionary();
                        headers.Add("from", ConfigUtil.getKeyValue("eremailfrom"));
                        headers.Add("to", "rapuru.srinithya@gmail.com");
                        headers.Add("subject", ConfigUtil.getKeyValue("eremailsubject"));
                        System.Text.StringBuilder strMessage = new System.Text.StringBuilder();
                        strMessage.Append("A New Company is added to the Companies List" + item["CompanyName"].ToString() + item["Category"].ToString() + item["Address"].ToString());
                        SPUtility.SendEmail(web, headers, strMessage.ToString());

                    }
                }
            }
            catch (Exception ex)
            {

            }

        }
    }
}