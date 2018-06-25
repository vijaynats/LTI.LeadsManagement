using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SharePoint.Client;
using System.IO;



namespace companycsv
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("sales data being imported");
            ClientContext ctx = new ClientContext("http://leadsmgmt.trg14.int"); //setting that the client is using it
            using (var reader = new StreamReader(@"c:\CompanyListCSV.csv"))//the file to be imported
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();//reading the csv line
                    var cols = line.Split(',');
                    //Create SP lIst Item
                    ListItemCreationInformation item = new ListItemCreationInformation();//creating an item
                    ListItem newItem = ctx.Web.Lists.GetByTitle("CompanyList").AddItem(item);

                    newItem["CompanyName"] = cols[0];

                    newItem["Category"] = cols[1];

                    newItem["Address"] = cols[2];

                    newItem["City"] = cols[3];

                    newItem["PostalCode"] = cols[4];

                    newItem["State"] = cols[5];

                    newItem["Website"] = cols[6];

                    newItem["Phone"] = cols[7];

                    newItem["Fax Number"] = cols[8];

                    newItem["Email"] = cols[9];

                    newItem["Stage"] = cols[10];

                    newItem["Notes"] = cols[11];



                    newItem.Update();
                    ctx.Load(newItem);
                    ctx.ExecuteQuery();
                        

                    Console.ReadLine();
                }
            }
        }
    }
}
