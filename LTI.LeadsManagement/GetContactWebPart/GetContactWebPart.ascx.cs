using System;
using System.ComponentModel;
using System.Web.UI.WebControls.WebParts;
using LTI.LeadsManagement.Model;


namespace LTI.LeadsManagement.GetContactWebPart
{
    [ToolboxItemAttribute(false)]
    public partial class GetContactWebPart : WebPart
    {
        // Uncomment the following SecurityPermission attribute only when doing Performance Profiling on a farm solution
        // using the Instrumentation method, and then remove the SecurityPermission attribute when the code is ready
        // for production. Because the SecurityPermission attribute bypasses the security check for callers of
        // your constructor, it's not recommended for production purposes.
        // [System.Security.Permissions.SecurityPermission(System.Security.Permissions.SecurityAction.Assert, UnmanagedCode = true)]
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
            string ID = Page.Request["cid"];

            CompanyData c = new CompanyData();

            Company l= c.GetCompanyById(Convert.ToInt32(ID));

           Company.Text= l.CompanyName;
        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            ContactData cd = new ContactData();
            var items = cd.findContacts(Company.Text);
            this.gvCompanyContacts.DataSource = cd;
            this.gvCompanyContacts.DataBind();
        }
    }
}
