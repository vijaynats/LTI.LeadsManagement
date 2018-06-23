using System;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using Microsoft.SharePoint;
using System.Net;
using System.IO;


namespace LTI.LeadsManagement.CustomerVisualWebPart
{
    
    public partial class CustomerVisualWebPartUserControl : UserControl
    {
        SPWeb web = SPContext.Current.Site.OpenWeb("http://leadsmgmt.trg14.int");

        protected void Page_Load(object sender, EventArgs e)
        {
        }

      

        protected void Searchby_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
        }
    }
}
