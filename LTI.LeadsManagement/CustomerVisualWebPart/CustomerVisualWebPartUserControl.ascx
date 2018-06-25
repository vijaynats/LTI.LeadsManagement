<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> 
<%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %> 
<%@ Register Tagprefix="Utilities" Namespace="Microsoft.SharePoint.Utilities" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="asp" Namespace="System.Web.UI" Assembly="System.Web.Extensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" %>
<%@ Import Namespace="Microsoft.SharePoint" %> 
<%@ Register Tagprefix="WebPartPages" Namespace="Microsoft.SharePoint.WebPartPages" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CustomerVisualWebPartUserControl.ascx.cs" Inherits="LTI.LeadsManagement.CustomerVisualWebPart.CustomerVisualWebPartUserControl" %>
<style type="text/css">
    .auto-style3 {
        width: 237px;
        height: 23px;
    }
    .auto-style4 {
        width: 240px;
        height: 23px;
    }
    .auto-style5 {
        height: 23px;
    }
    .auto-style7 {
        width: 237px;
        height: 32px;
    }
    .auto-style8 {
        width: 240px;
        height: 32px;
    }
    .auto-style9 {
        height: 32px;
    }
    .auto-style10 {
        width: 237px;
        height: 35px;
    }
    .auto-style11 {
        width: 240px;
        height: 35px;
    }
    .auto-style12 {
        height: 35px;
    }
    .auto-style13 {
        width: 237px;
        height: 54px;
    }
    .auto-style14 {
        width: 240px;
        height: 54px;
    }
    .auto-style15 {
        height: 54px;
    }
    .auto-style16 {
        width: 226px;
        height: 23px;
    }
    .auto-style17 {
        width: 226px;
        height: 32px;
    }
    .auto-style18 {
        width: 226px;
        height: 35px;
    }
    .auto-style19 {
        width: 226px;
        height: 54px;
    }
    .auto-style20 {
        height: 23px;
        width: 130px;
    }
    .auto-style21 {
        height: 32px;
        width: 130px;
    }
    .auto-style22 {
        height: 35px;
        width: 130px;
    }
    .auto-style23 {
        height: 54px;
        width: 130px;
    }
</style>
<asp:Label ID="Label1" runat="server" Text="Company Search"></asp:Label>
<p>
    <asp:Label ID="Label2" runat="server" Text="Search By"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label3" runat="server" Text="Sort By:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:DropDownList ID="sortby" runat="server">
    </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="search" runat="server" Text="Search" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
</p>
<p>
    &nbsp;</p>


<p>
    <asp:DataList ID="DataList1" runat="server">
        <ItemTemplate>
            <table style="width: 99%; height: 192px;">
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label4" runat="server" Text="Company Name:"></asp:Label>
                    </td>
                    <td class="auto-style4">
                        <asp:Label ID="CompanyName" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:Label ID="Label14" runat="server" Text="Category"></asp:Label>
                    </td>
                    <td class="auto-style20">
                        <asp:Label ID="Category" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">
                        <asp:Label ID="Label6" runat="server" Text="Address"></asp:Label>
                    </td>
                    <td class="auto-style8">
                        <asp:Label ID="Address" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style9">
                        <asp:Label ID="city1" runat="server" Text="City"></asp:Label>
                    </td>
                    <td class="auto-style21">
                        <asp:Label ID="city" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style10">
                        <asp:Label ID="Label8" runat="server" Text="State"></asp:Label>
                    </td>
                    <td class="auto-style11">
                        <asp:Label ID="state" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style12">
                        <asp:Label ID="PostalCode1" runat="server" Text="PostalCode:"></asp:Label>
                    </td>
                    <td class="auto-style22">
                        <asp:Label ID="PostalCode" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style13">
                        <asp:Label ID="Label9" runat="server" Text="Phone"></asp:Label>
                    </td>
                    <td class="auto-style14">
                        <asp:Label ID="Phone" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style15">
                        <asp:Label ID="FaxNumber1" runat="server" Text="FaxNumber:"></asp:Label>
                    </td>
                    <td class="auto-style23">
                        <asp:Label ID="FaxNumber" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style19">
                        <asp:Label runat="server" Text="Email"></asp:Label>
                    </td>
                    <td class="auto-style14">
                        <asp:Label ID="Email" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style15">
                        <asp:Label runat="server" Text="WebSite"></asp:Label>
                    </td>
                    <td class="auto-style23">
                        <asp:Label ID="WebSite" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style19">
                        <asp:Label runat="server" Text="Stage"></asp:Label>
                    </td>
                    <td class="auto-style14">
                        <asp:Label ID="Stage" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style15">&nbsp;</td>
                    <td class="auto-style23">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style19">&nbsp;</td>
                    <td class="auto-style14">&nbsp;</td>
                    <td class="auto-style15">&nbsp;</td>
                    <td class="auto-style23">
                        <asp:Button ID="viewcontact" runat="server" Text="View Contact" />
                    </td>
                </tr>
            </table>
        </ItemTemplate>

    </asp:DataList>
</p>



