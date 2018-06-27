<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> 
<%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> 
<%@ Register Tagprefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Import Namespace="Microsoft.SharePoint" %> 
<%@ Register Tagprefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CompanySearchWebPart.ascx.cs" Inherits="LTI.LeadsManagement.CompanySearchWebPart.CompanySearchWebPart" %>
<strong>
<asp:Label ID="Label1" runat="server" Text="SEARCH COMPANY"></asp:Label>
</strong>

<table style="width: 100%;">
    <tr>
        <td>Keyword :</td>
        <td>
            <asp:TextBox ID="txtKeyword" runat="server"></asp:TextBox>
        </td>
        <td>
            Find in :
        </td>
        <td>
            <asp:DropDownList ID="ddlColumns" runat="server">
                <asp:ListItem>Title</asp:ListItem>
                <asp:ListItem>Category</asp:ListItem>
                <asp:ListItem>WorkAddress</asp:ListItem>
                <asp:ListItem>WorkCity</asp:ListItem>
                <asp:ListItem>PostalCode</asp:ListItem>
                <asp:ListItem>state</asp:ListItem>
                <asp:ListItem>Website</asp:ListItem>
                <asp:ListItem>Phone</asp:ListItem>
                <asp:ListItem>WorkFax</asp:ListItem>
                <asp:ListItem>Email</asp:ListItem>
                <asp:ListItem>Stage</asp:ListItem>
                <asp:ListItem Value="notes">Notes</asp:ListItem>
            </asp:DropDownList>
        </td>
        <td>
            <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="search_Click" Width="56px" />
        </td>
    </tr>
</table>

<asp:GridView ID="compamysearch" runat="server" AutoGenerateColumns="False" Height="169px" Width="942px">
    <Columns>
        <asp:BoundField DataField="Title" HeaderText="Company Name" >
        <HeaderStyle Font-Bold="True" />
        </asp:BoundField>
        <asp:BoundField DataField="Category" HeaderText="Category">
        <HeaderStyle Font-Bold="True" />
        </asp:BoundField>
        <asp:BoundField DataField="Address" HeaderText="Address" />
    </Columns>
</asp:GridView>
<p>
    &nbsp;</p>

