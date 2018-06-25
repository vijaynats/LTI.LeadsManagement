using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SharePoint;
using System.IO;
using System.Net;



namespace LeadsCSV
{
   public class Program
    {
       public static void Main(string[] args)
        {
            SPSite site = new SPSite("http://leadsmgmt.trg14.int/");
            SPWeb web = site.RootWeb;



            SPList list = web.Lists["CompanyList"];





            using (var reader = new StreamReader(@"c:\CompanyListCSV.csv"))

            {

                while (!reader.EndOfStream)


                {

                    string line = reader.ReadLine();

                    var cols = line.Split(',');



                    SPListItem newItem = list.Items.Add();

                    newItem["CompanyName"] = "lti";

                    newItem["Category"] = "mnc";

                    newItem["Address"] = "abc nagar";

                    newItem["City"] = "chennai";

                    newItem["PostalCode"] = "600082";

                    newItem["State"] = "taminadu";

                    newItem["Website"] = "http://www.facebook.com";

                    newItem["Phone"] = "987654321";

                    newItem["Fax Number"] = cols[8];

                    newItem["Email"] = cols[9];

                    newItem["Stage"] = cols[10];

                    newItem["Notes"] = cols[11];



                    newItem.Update();
                }
            }
       }
    }
}
