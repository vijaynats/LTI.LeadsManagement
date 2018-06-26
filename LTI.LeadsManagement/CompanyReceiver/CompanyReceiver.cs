﻿using System;
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
        /// An item was added.
        /// </summary>
        public override void ItemAdded(SPItemEventProperties properties)
        {
            base.ItemAdded(properties);

            try
            {
                Email message = new Email()
                {
                    Subject="New Comapany Added",
                    From ="admin@trg10.int",
                    Body="A New Company is added to the Sales Manger Group",
                };

                MailUtil mailer = new MailUtil(properties.Site.Url);
                mailer.sendEmailToGroup("Sales Manager", message);
            }
            catch { }

        }


    }
}