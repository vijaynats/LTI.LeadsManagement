using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Data;
using Microsoft.SharePoint;
using System.Web.Configuration;

namespace LTI.LeadsManagement.ContactWebpart
{
    public partial class ContactWebpartUserControl : UserControl
    {
     
        protected void Page_Load(object sender, EventArgs e)
        {

            //if (!this.IsPostBack)
            //{
              
            //    //DataTable items = this.getDetails();
            //    //    this.dlContacts.DataSource = items;

            //    //    this.dlContacts.DataBind();
            //}
        }
        public DataTable GetDetails()
        {

            SPList Details = SPContext.Current.Web.Lists["ContactList"];

            SPQuery q = new SPQuery();

            q.Query = string.Format(@"<Where>
  					  <Eq>
       					  <FieldRef Name='GKH' />
       					  <Value Type='Choice'>{0}</Value>
    					  </Eq>
  					 </Where>",ddlCompany.Text);
            //SPListItemCollection results = Details.GetItems(q);
            //Bind();
            return Details.GetItems(q).GetDataTable();

        }
        public void Bind()
        {
            //try
            //{
                DataTable ds = this.GetDetails();
                //results.Fill(ds, "Employee");
                dlContacts.DataSource = ds;
                dlContacts.DataBind();

                //int index = e.Item.ItemIndex;
                int count = 0;
            try
            {
                //foreach (DataTable item in ds.)
                while (count < ds.Rows.Count)
                {
                    //int index = results.Item.ItemIndex;
                    Label Name = (Label)dlContacts.FindControl("lblName");
                    Name.Text = ds.Rows[count]["Title"].ToString();
                    Label Title = (Label)dlContacts.FindControl("lblTitle");
                    Label Department = (Label)dlContacts.FindControl("lblDepartment");
                    Label Email = (Label)dlContacts.FindControl("lblEmail");
                    Label Phone = (Label)dlContacts.FindControl("lblPhone");
                    Label Mobile = (Label)dlContacts.FindControl("lblMobile");
                    FileUpload Image = (FileUpload)dlContacts.FindControl("Img");
                    FileUpload LinkedIn = (FileUpload)dlContacts.FindControl("lblLink");
                    FileUpload Facebook = (FileUpload)dlContacts.FindControl("lblFb");
                    Label Twitter = (Label)dlContacts.FindControl("lblTwitter");
                    Label Status = (Label)dlContacts.FindControl("lblStatus");
                    count++;
                }
            }

            catch
            {

            }

        }

        protected void dlContacts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ddlCompany_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        protected void btnSNotes_Click(object sender, EventArgs e)
        {

        }

        public void btnShow_Click(object sender, EventArgs e)
        {
            //string CompanyName = this.ddlCompany.Text;

            Bind();
            
        }
    }
}
