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
    class Program
    {
        static void Main(string[] args)
        {
            
                Console.WriteLine("sales data being imported");
           
                ClientContext ctx = new ClientContext("http://leadsmgmt.trg14.int/");

            Console.WriteLine("check");//setting that the client is using it
           
                using (var reader = new StreamReader(@"c:\company.csv"))//the file to be imported
                {

                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();//reading the csv line
                        var cols = line.Split(',');
                        //Create SP lIst Item
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
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            Console.ReadLine();

        }
    }


}
