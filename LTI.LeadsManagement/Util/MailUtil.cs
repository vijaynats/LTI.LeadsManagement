using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Utilities;

using LTI.LeadsManagement.Model;

namespace LTI.LeadsManagement.Util
{
    public class MailUtil
    {
        private string siteColUrl;
        public MailUtil(string siteCollnUrl)
        {
            if(string.IsNullOrEmpty(siteCollnUrl))
            {
                throw new Exception("Site Collection Url is empty");
            }

            this.siteColUrl = siteCollnUrl;
        }

        public string SiteUrl
        {
            get
            {
                return this.siteColUrl;
            }
        }

        public void sendEmail(Email email)
        {
            this.sendEmail("", email);
        }

        public void sendEmailToGroup(string groupName, Email email)
        {
            this.sendEmail(groupName, email);
        }

        private void sendEmail(string grpName, Email email)
        {
            using (SPSite Site = new SPSite(this.SiteUrl))  //Site collection URL
            {
                using (SPWeb web = Site.RootWeb)  //Subsite URL
                {
                    if (!SPUtility.IsEmailServerSet(web))
                    {
                        throw new Exception("Error : Outgoing Email Server not set in SharePoint");
                    }

                    StringDictionary headers = new StringDictionary();

                    string toRecipients = "";

                    if (string.IsNullOrEmpty(grpName))
                    {
                        if(email.To.Count == 0)
                        {
                            throw new Exception("Email has 0 recipients");
                        }

                        // Find out users from Email To field
                        foreach (string recipient in email.To)
                        {
                            toRecipients += recipient + ",";
                        }
                    }
                    else
                    {
                        
                        // Find out Users from Group
                        SPGroup group = web.Groups.Cast<SPGroup>().ToList()
                                                .Where(a => a.Name == grpName).FirstOrDefault();

                        if(group == null)
                        {
                            throw new Exception("No such SharePoint group in current site collection : " + grpName);
                        }

                        SPUserCollection users = group.Users;

                        foreach (SPUser u in users)
                        {
                            toRecipients += u.Email + ",";
                        }
                    }

                    toRecipients = toRecipients.Substring(0, toRecipients.Length - 2);

                    headers.Add("from", email.From);
                    headers.Add("to", toRecipients);
                    headers.Add("subject", email.Subject);
                    headers.Add("fAppendHtmlTag", "True"); //To enable HTML format

                    System.Text.StringBuilder strMessage = new System.Text.StringBuilder();
                    strMessage.Append(email.Body);

                    SPUtility.SendEmail(web, headers, strMessage.ToString());
                }
            }
        }
    }
}
