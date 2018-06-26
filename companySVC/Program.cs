using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SharePoint.Client;
using System.IO;
using System.Net;

namespace LTI.LeadsManagement.Import
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                string siteUrl = "";
                string fileName = "";

                Console.WriteLine("** COMPANY DATA IMPORT ***");

                // Accept Site Url
                do
                {
                    Console.Write("Site Url : ");
                    siteUrl = Console.ReadLine();
                } while (string.IsNullOrEmpty(siteUrl));

                // Accept FileName
                do
                {
                    Console.Write("File Name : ");
                    fileName = Console.ReadLine();
                } while (string.IsNullOrEmpty(fileName));


                // Connect to SharePoint
                using (ClientContext ctx = new ClientContext(siteUrl))
                {
                    // Check if the File exists
                    if (!System.IO.File.Exists(fileName))
                    {
                        Console.WriteLine("\nFile Not found {0}", fileName);
                        return;
                    }

                    // Import from the file
                    using (var reader = new StreamReader(fileName))
                    {
                        while (!reader.EndOfStream)
                        {
                            string line = reader.ReadLine();
                            var cols = line.Split(',');

                            // Add a new SP ListItem
                            ListItemCreationInformation item = new ListItemCreationInformation();//creating an item
                            ListItem newItem = ctx.Web.Lists.GetByTitle("CompanyList").AddItem(item);

                            newItem["Title"] = cols[0];
                            newItem["category"] = cols[1];
                            newItem["WorkAddress"] = cols[2];
                            newItem["WorkCity"] = cols[3];
                            newItem["PostalCode"] = cols[4];
                            newItem["state"] = cols[5];
                            newItem["Website"] = cols[6];
                            newItem["Phone"] = cols[7];
                            newItem["WorkFax"] = cols[8];
                            newItem["Email"] = cols[9];
                            newItem["Stage"] = cols[10];

                            newItem.Update();
                            ctx.Load(newItem);

                            ctx.ExecuteQuery();
                        }
                    }
                }

            } catch(Exception ex)
            {
                Console.WriteLine("-- Error During Execution : " + ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
