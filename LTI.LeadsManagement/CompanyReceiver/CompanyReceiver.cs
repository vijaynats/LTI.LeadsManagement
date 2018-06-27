using System;
using System.Security.Permissions;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Utilities;
using Microsoft.SharePoint.Workflow;

using LTI.LeadsManagement.Model;
using LTI.LeadsManagement.Util;


namespace LTI.LeadsManagement.CompanyReceiver
{
    /// <summary>
    /// List Item Events
    /// </summary>
    public class CompanyReceiver : SPItemEventReceiver
    {
        
        /// <summary>
        /// Sends an Email to a designated SharePoint group
        /// after New Company is added
        /// </summary>
        public override void ItemAdded(SPItemEventProperties properties)
        {
            base.ItemAdded(properties);      

            try
            {

                SPList list = properties.Web.Lists["Companies"];
                SPListItem item = list.GetItemById(properties.ListItemId);
                ConfigUtil config = new ConfigUtil(properties.Web);

                Email message = new Email()
                {
                    Subject = config.getKeyValue("eremailsubject"),
                    From = config.getKeyValue("eremailfrom"),
                    Body = String.Format(@"<div>A New Company is added 
                                to the Companies List <br/>
                                Company Name : {0} <br/>
                                Category : {1} <br/>
                                Address : {2} <br/>
                                City : {3} <br/>                              
                                Phone : {4} <br/>
                                Stage : {5} <br/>
                                <div>",
                                item["CompanyName"].ToString(),
                                item["Category"].ToString(),
                                item["Address"].ToString(),
                                item["City"].ToString(),                              
                                item["Phone"].ToString(),
                                item["Stage"].ToString()
                            )
                };

                MailUtil mailer = new MailUtil(properties.Site.Url);
                mailer.sendEmailToGroup(config.getKeyValue("mgrspgroup"), message);
                
            }
            catch(Exception ex)
            {
                string details = ex.Message;
            }

        }
    }
}