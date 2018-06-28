using System;
using System.ComponentModel;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Web.UI.WebControls.WebParts;
using LTI.LeadsManagement.Model;
using System.Data;
using System.Net;


namespace LTI.LeadsManagement.CompanySearchWebPart
{
    [ToolboxItemAttribute(false)]
    public partial class CompanySearchWebPart : WebPart
    {
        public CompanySearchWebPart()
        {
        }

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            InitializeControl();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void search_Click(object sender, EventArgs e)
        {
            CompanyData cd = new CompanyData();

            var items = cd.findCompany(this.ddlColumns.SelectedValue, this.txtKeyword.Text);

            this.gvcompamysearch.DataSource = items;
            this.gvcompamysearch.DataBind();
        }

        protected void lnkviewcontact_Click(object sender, EventArgs e)
        {
          
            
        }

        protected void gvcompamysearch_RowCommand(object sender, System.Web.UI.WebControls.GridViewCommandEventArgs e)
        {
            
        }

        protected void gvcompamysearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }

        protected void lnkviewcontact_Command(object sender, System.Web.UI.WebControls.CommandEventArgs e)
        {
            Page.Response.Redirect("http://leads.trg10.int/SitePages/Contact.aspx?cid=" + e.CommandArgument.ToString());
        }
    }
}