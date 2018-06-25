using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SharePoint;
using System.Net;

using System.IO;

namespace LTI.LeadsManagement
{
    class companycsv
    {
        public static void Main(string[] args)

        {

           

            SPSite site = new SPSite("http://leadsmgmt.trg14.int/");

            SPWeb web = site.RootWeb;

            SPList list = web.Lists["CompanyList"];

            // READ SALE CSV FILE

            using (var reader = new StreamReader(@"c:\CompanyListCSV.csv"))

            {

                while (!reader.EndOfStream)


                {

                    string line = reader.ReadLine();

                    var cols = line.Split(',');

                    // Create SP List ITem

                    SPListItem newItem = list.AddItem();



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

                    //ctx.Load(newItem);

                    //ctx.ExecuteQuery();

                

                }

            }

            Console.ReadLine();

        }

    }

}

