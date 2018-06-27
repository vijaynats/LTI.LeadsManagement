<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> 
<%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> 
<%@ Register Tagprefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Import Namespace="Microsoft.SharePoint" %> 
<%@ Register Tagprefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="GetContactWebPart.ascx.cs" Inherits="LTI.LeadsManagement.GetContactWebPart.GetContactWebPart" %>
<style type="text/css">
    .auto-style1 {
        width: 187px;
    }
    .auto-style2 {
        width: 229px;
    }
</style>
<table style="width: 100%;">
    <tr>
        <td colspan="3">
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </td>
     </tr>
    <tr>
        <td class="auto-style1">
            Company Contacts
        </td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
     </tr>
    <tr>
        <td class="auto-style1">
            Company:
        </td>
        <td class="auto-style2">
            <asp:TextBox ID="Company" runat="server"></asp:TextBox>
        </td>
        <td> 
            <asp:Button ID="btnShow" runat="server" Text="Show...." OnClick="btnShow_Click" />
        </td>
    </tr>
 </table>
<asp:GridView ID="gvCompanyContacts" runat="server" AutoGenerateColumns="False">
    <Columns>
        <asp:ImageField DataImageUrlField="pic" HeaderText="picture">
        </asp:ImageField>
        <asp:BoundField DataField="Title" HeaderText="Contact Name" />
        <asp:BoundField DataField="company" HeaderText="Company" />
        <asp:BoundField DataField="Title1" HeaderText="Title" />
        <asp:BoundField DataField="Email" HeaderText="Email" />
        <asp:BoundField DataField="OPhone" HeaderText="phone" />
        <asp:BoundField DataField="CellPhone" HeaderText="Mobile" />
        <asp:BoundField DataField="ol_Department" HeaderText="Department" />
        <asp:HyperLinkField DataTextField="LinkedIn" HeaderText="Linkedin" />
        <asp:HyperLinkField DataTextField="Facebook" HeaderText="FacebookUrl" />
        <asp:BoundField DataField="Twitter" HeaderText="Twitter" />
        <asp:BoundField DataField="status" HeaderText="Status" />
        <asp:BoundField DataField="Notes1" HeaderText="Notes" />
    </Columns>

</asp:GridView>
