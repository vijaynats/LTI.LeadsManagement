using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SharePoint.Client;
using System.IO;

namespace LTI.LeadsManagement.Import1
{
   public class program1
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
                    //Check if the File exists
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
                            ListItem newItem = ctx.Web.Lists.GetByTitle("ContactList").AddItem(item);

                            newItem["Title"] = cols[0];
                           
                            newItem["Title1"] = cols[1];
                            newItem["Email"] = cols[2];
                            newItem["OPhone"] = cols[3];
                            newItem["CellPhone"] = cols[4];
                            newItem["ol_Department"] = cols[5];
                            newItem["pic"] = cols[6];
                            newItem["LinkedIn"] = cols[7];
                            newItem["Facebook"] = cols[8];
                            newItem["Twitter"] = cols[9];
                            newItem["Notes1"] = cols[10];
                            newItem["status"] = cols[11];
                            newItem["Company"] = cols[12];
                            //newItem["Company:ID"] = cols[13];

                            newItem.Update();
                            ctx.Load(newItem);

                            ctx.ExecuteQuery();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("-- Error During Execution : " + ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}