using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Utilities;
using System.Collections.Specialized;
using LTI.LeadsManagement.Util;
using LTI.LeadsManagement.Model;

namespace LTI.LeadsManagement
{
    class Email
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Sending Email....");

                MailUtil mailer = new MailUtil("http://leads.trg10.int");
                LTI.LeadsManagement.Model.Email email = new Model.Email()
                {
                    To = new List<string>()
                    {
                        "divya@trg10.int", "harshu@trg10.int", "vani@trg10.int"
                    },
                    Subject = "** NEW CUSTOMER",
                    From = "admin@trg10.int",
                    Body = "New Customer Added, Please check"
                };

                mailer.sendEmail(email);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error sending Email - " + ex.ToString());
            }

            Console.ReadLine();
        }
    }
}
    