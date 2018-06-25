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

           

            SPListCollection lc = web.Lists;

            SPList list = web.Lists["CompanyList"];
            foreach(SPList l in lc )
                Console.WriteLine(l.Title);
           

            // READ SALE CSV FILE

            //using (var reader = new StreamReader(@"c:\CompanyListCSV.csv"))

            //{

            //    while (!reader.EndOfStream)


            //    {

            //        string line = reader.ReadLine();

            //        var cols = line.Split(',');

                    // Create SP List ITem

                    //SPListItem newItem = list.Items.Add();

                    //newItem["CompanyName"] = "lti";

                    //newItem["Category"] = "mnc";

                    //newItem["Address"] = "abc nagar";

                    //newItem["City"] = "chennai";

                    //newItem["PostalCode"] = "600082";

                    //newItem["State"] = "taminadu";

                    //newItem["Website"] = "http://www.facebook.com";

                    //newItem["Phone"] = "987654321";

            //newItem["Fax Number"] = cols[8];

            //newItem["Email"] = cols[9];

            //newItem["Stage"] = cols[10];

            //newItem["Notes"] = cols[11];



            //newItem.Update();

            //ctx.Load(newItem);

            //ctx.ExecuteQuery();
          

        }

     }


}

    



