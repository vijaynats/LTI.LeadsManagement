using Microsoft.SharePoint;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;

namespace LTI.LeadsManagement.Model
{
    public class CompanyData
    {
        public CompanyData()
        {

        }

        /// <summary>
        /// Gets a single Company based of ID field 
        /// </summary>
        /// <param name="id">ListItem ID of the Company</param>
        /// <returns>Company</returns>
        public Company GetCompanyById(int id)
        {
            var c = SPContext.Current.Web.Lists["Companies"].GetItemById(id);   
                 return new Company()
                 {
                    ID=Convert.ToInt32(c["ID"]),
                    CompanyName=c["CompanyName"].ToString(),
                    Category=c["Category"].ToString(),
                     Address=c["Address"].ToString(),
                      City=c["City"].ToString(),
                      PostalCode=c["PostalCode"].ToString(),
                      State=c["State"].ToString(),
                      Website=c["Website"].ToString(),
                      Phone=c[" Phone"].ToString(),
                      Fax=c["Fax"].ToString(),
                      Email=c["Email"].ToString(),
                      Stage=c["Stage"].ToString(),
                      Notes=c["Notes"].ToString()
                };
        }

        public IList<Company> getAllCompanies(int rowLimit)
        {
            SPList list = SPContext.Current.Web.Lists["Companies"];

            var q = new SPQuery();
            q.Query = string.Format(@"<View><RowLimit Paged='False'>{0}</RowLimit></View>", rowLimit);

            var items = list.GetItems(q).AsQueryable();

            List<Company> results = new List<Company>();

            foreach(SPListItem item in items)
            {
                Company c = new Company()
                {
                    ID = Convert.ToInt32(item["ID"]),
                    CompanyName = item["CompanyName"].ToString(),
                    Category = item["Category"].ToString(),
                    Address = item["Address"].ToString(),
                    City = item["City"].ToString(),
                    PostalCode = item["PostalCode"].ToString(),
                    State = item["State"].ToString(),
                    Website = item["Website"].ToString(),
                    Phone = item[" Phone"].ToString(),
                    Fax = item["Fax"].ToString(),
                    Email = item["Email"].ToString(),
                    Stage = item["Stage"].ToString(),
                    Notes = item["Notes"].ToString()
                };
            }

            return results;      
        }
         
        public bool addNewCompany(Company c)
        {
            try
            {
                SPList list = SPContext.Current.Web.Lists["Companies"];
                SPListItem citem = list.Items.Add();
                citem["CompanyName"] = c.CompanyName;
                citem["Category"] = c.Category;
                citem["Address"] = c.Address;
                citem["City"] = c.City;
                citem["PostalCode"] = c.PostalCode;
                citem["State"] = c.State;
                citem["Website"] = c.Website;
                citem[" Phone"] = c.Phone;
                citem["Fax"] = c.Fax;
                citem["Email"] = c.Email;
                citem["Stage"] = c.Stage;
                citem["Notes"] = c.Notes;
                citem.Update();
            }
            catch
            {
                return false;
            }

            return true;
        }

        public bool updateCompany(Company c)
        {
            SPList list = SPContext.Current.Web.Lists["Companies"];
           
            SPListItem citem =  list.GetItemById(c.ID);
            try
            {
                citem["CompanyName"] = c.CompanyName;
                citem["Category"] = c.Category;
                citem["Address"] = c.Address;
                citem["City"] = c.City;
                citem["PostalCode"] = c.PostalCode;
                citem["State"] = c.State;
                citem["Website"] = c.Website;
                citem[" Phone"] = c.Phone;
                citem["Fax"] = c.Fax;
                citem["Email"] = c.Email;
                citem["Stage"] = c.Stage;
                citem["Notes"] = c.Notes;
                citem.Update();
            }
            catch
            {
                return false;
            }

            return true;
        }

        public bool deleteCompanyById(int id)
        {
            try
            {
                SPList list = SPContext.Current.Web.Lists["Companies"];
                SPListItem item = list.GetItemById(id);
                item.Delete();
            }
            catch
            {
                return false;
            }

            return true;
        }

        public void deleteCompany(Company c)
        {

             this.deleteCompanyById(c.ID);
        }

        //public IList<Company> findCompany(string fieldName,string fieldValue)
        public DataTable findCompany(string fieldName, string fieldValue)
        {
            var list = SPContext.Current.Web.Lists["Companies"];
            var q = new SPQuery();
            q.Query = string.Format(@"<Where>
                                        <Contains>
                                            <FieldRef Name='{0}' />
                                            <Value Type='Text'>{1}</Value>
                                        </Contains>
                                    </Where>",fieldName,fieldValue);
            return list.GetItems(q).GetDataTable();
        }

        public IList<Company> findCompany(string fieldName, string fieldValue, int maxRows)
        {
            var list = SPContext.Current.Web.Lists["Companies"];
            var q = new SPQuery();
            q.Query = string.Format(@"<Where>
                                        <Contains>
                                            <FieldRef Name='{0}' />
                                            <Value Type='Text'>{1}</Value>
                                        </Contains>
                                     </Where>", fieldName, fieldValue);
            var items = list.GetItems(q).AsQueryable();

            List<Company> results = new List<Company>();

            foreach (SPListItem item in items)
            {
                Company c = new Company()
                {
                    ID = Convert.ToInt32(item["ID"]),
                    CompanyName = item["CompanyName"].ToString(),
                    Category = item["Category"].ToString(),
                    Address = item["Address"].ToString(),
                    City = item["City"].ToString(),
                    PostalCode = item["PostalCode"].ToString(),
                    //State = (state1)item["State"],
                    State = item["State"].ToString(),

                    Website = item["Website"].ToString(),
                    Phone = item[" Phone"].ToString(),
                    Fax = item["Fax"].ToString(),
                    Email = item["Email"].ToString(),
                    Stage = item["Stage"].ToString(),
                    Notes = item["Notes"].ToString()
                };
            }

            return results;
        }
    }
}
