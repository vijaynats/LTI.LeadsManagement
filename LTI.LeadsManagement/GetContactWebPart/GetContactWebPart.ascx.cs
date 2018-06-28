using System;
using System.ComponentModel;
using System.Web.UI.WebControls.WebParts;
using LTI.LeadsManagement.Model;
using System.Net;


namespace LTI.LeadsManagement.GetContactWebPart
{
    [ToolboxItemAttribute(false)]
    public partial class GetContactWebPart : WebPart
    {
        public GetContactWebPart()
        {
        }

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            InitializeControl();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                if (!Page.IsPostBack)
                {
                    string companyid = Page.Request["cid"];
                    CompanyData cd = new CompanyData();
                    Company c = new Company();
                    c = cd.GetCompanyById(int.Parse(companyid));
                    Company.Text = c.CompanyName;

                    this.btnShow_Click(this, null);
                }
            }
            catch (Exception ex)
            {
                this.lblError.Text = "Error in webpart : " + ex.Message;
                    this.lblError.ToolTip = ex.StackTrace;
            }
        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            ContactData cd = new ContactData();
            string companyid = Page.Request["cid"];
            var items = cd.findContacts(Convert.ToInt32(companyid));
            this.gvCompanyContacts.DataSource =items;
            this.gvCompanyContacts.DataBind();
        }
    }
}
