﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LTI.LeadsManagement.CompanySearchWebPart {
    using System.Web.UI.WebControls.Expressions;
    using System.Web.UI.HtmlControls;
    using System.Collections;
    using System.Text;
    using System.Web.UI;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml.Linq;
    using Microsoft.SharePoint.WebPartPages;
    using System.Web.SessionState;
    using System.Configuration;
    using Microsoft.SharePoint;
    using System.Web;
    using System.Web.DynamicData;
    using System.Web.Caching;
    using System.Web.Profile;
    using System.ComponentModel.DataAnnotations;
    using System.Web.UI.WebControls;
    using System.Web.Security;
    using System;
    using Microsoft.SharePoint.Utilities;
    using System.Text.RegularExpressions;
    using System.Collections.Specialized;
    using System.Web.UI.WebControls.WebParts;
    using Microsoft.SharePoint.WebControls;
    using System.CodeDom.Compiler;
    
    
    public partial class CompanySearchWebPart {
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "15.0.0.0")]
        protected global::System.Web.UI.WebControls.Label Label1;
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "15.0.0.0")]
        protected global::System.Web.UI.WebControls.TextBox txtKeyword;
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "15.0.0.0")]
        protected global::System.Web.UI.WebControls.DropDownList ddlColumns;
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "15.0.0.0")]
        protected global::System.Web.UI.WebControls.Button btnSearch;
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "15.0.0.0")]
        protected global::System.Web.UI.WebControls.GridView gvcompamysearch;
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebPartCodeGenerator", "15.0.0.0")]
        public static implicit operator global::System.Web.UI.TemplateControl(CompanySearchWebPart target) 
        {
            return target == null ? null : target.TemplateControl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "15.0.0.0")]
        private global::System.Web.UI.WebControls.Label @__BuildControlLabel1() {
            global::System.Web.UI.WebControls.Label @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Label();
            this.Label1 = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "Label1";
            @__ctrl.Text = "SEARCH COMPANY";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "15.0.0.0")]
        private global::System.Web.UI.WebControls.TextBox @__BuildControltxtKeyword() {
            global::System.Web.UI.WebControls.TextBox @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.TextBox();
            this.txtKeyword = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "txtKeyword";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "15.0.0.0")]
        private global::System.Web.UI.WebControls.ListItem @__BuildControl__control3() {
            global::System.Web.UI.WebControls.ListItem @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.ListItem();
            @__ctrl.Text = "Title";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "15.0.0.0")]
        private global::System.Web.UI.WebControls.ListItem @__BuildControl__control4() {
            global::System.Web.UI.WebControls.ListItem @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.ListItem();
            @__ctrl.Text = "Category";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "15.0.0.0")]
        private global::System.Web.UI.WebControls.ListItem @__BuildControl__control5() {
            global::System.Web.UI.WebControls.ListItem @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.ListItem();
            @__ctrl.Text = "WorkAddress";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "15.0.0.0")]
        private global::System.Web.UI.WebControls.ListItem @__BuildControl__control6() {
            global::System.Web.UI.WebControls.ListItem @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.ListItem();
            @__ctrl.Text = "WorkCity";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "15.0.0.0")]
        private global::System.Web.UI.WebControls.ListItem @__BuildControl__control7() {
            global::System.Web.UI.WebControls.ListItem @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.ListItem();
            @__ctrl.Text = "PostalCode";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "15.0.0.0")]
        private global::System.Web.UI.WebControls.ListItem @__BuildControl__control8() {
            global::System.Web.UI.WebControls.ListItem @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.ListItem();
            @__ctrl.Text = "state";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "15.0.0.0")]
        private global::System.Web.UI.WebControls.ListItem @__BuildControl__control9() {
            global::System.Web.UI.WebControls.ListItem @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.ListItem();
            @__ctrl.Text = "Website";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "15.0.0.0")]
        private global::System.Web.UI.WebControls.ListItem @__BuildControl__control10() {
            global::System.Web.UI.WebControls.ListItem @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.ListItem();
            @__ctrl.Text = "Phone";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "15.0.0.0")]
        private global::System.Web.UI.WebControls.ListItem @__BuildControl__control11() {
            global::System.Web.UI.WebControls.ListItem @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.ListItem();
            @__ctrl.Text = "WorkFax";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "15.0.0.0")]
        private global::System.Web.UI.WebControls.ListItem @__BuildControl__control12() {
            global::System.Web.UI.WebControls.ListItem @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.ListItem();
            @__ctrl.Text = "Email";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "15.0.0.0")]
        private global::System.Web.UI.WebControls.ListItem @__BuildControl__control13() {
            global::System.Web.UI.WebControls.ListItem @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.ListItem();
            @__ctrl.Text = "Stage";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "15.0.0.0")]
        private global::System.Web.UI.WebControls.ListItem @__BuildControl__control14() {
            global::System.Web.UI.WebControls.ListItem @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.ListItem();
            @__ctrl.Value = "notes";
            @__ctrl.Text = "Notes";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "15.0.0.0")]
        private void @__BuildControl__control2(System.Web.UI.WebControls.ListItemCollection @__ctrl) {
            global::System.Web.UI.WebControls.ListItem @__ctrl1;
            @__ctrl1 = this.@__BuildControl__control3();
            @__ctrl.Add(@__ctrl1);
            global::System.Web.UI.WebControls.ListItem @__ctrl2;
            @__ctrl2 = this.@__BuildControl__control4();
            @__ctrl.Add(@__ctrl2);
            global::System.Web.UI.WebControls.ListItem @__ctrl3;
            @__ctrl3 = this.@__BuildControl__control5();
            @__ctrl.Add(@__ctrl3);
            global::System.Web.UI.WebControls.ListItem @__ctrl4;
            @__ctrl4 = this.@__BuildControl__control6();
            @__ctrl.Add(@__ctrl4);
            global::System.Web.UI.WebControls.ListItem @__ctrl5;
            @__ctrl5 = this.@__BuildControl__control7();
            @__ctrl.Add(@__ctrl5);
            global::System.Web.UI.WebControls.ListItem @__ctrl6;
            @__ctrl6 = this.@__BuildControl__control8();
            @__ctrl.Add(@__ctrl6);
            global::System.Web.UI.WebControls.ListItem @__ctrl7;
            @__ctrl7 = this.@__BuildControl__control9();
            @__ctrl.Add(@__ctrl7);
            global::System.Web.UI.WebControls.ListItem @__ctrl8;
            @__ctrl8 = this.@__BuildControl__control10();
            @__ctrl.Add(@__ctrl8);
            global::System.Web.UI.WebControls.ListItem @__ctrl9;
            @__ctrl9 = this.@__BuildControl__control11();
            @__ctrl.Add(@__ctrl9);
            global::System.Web.UI.WebControls.ListItem @__ctrl10;
            @__ctrl10 = this.@__BuildControl__control12();
            @__ctrl.Add(@__ctrl10);
            global::System.Web.UI.WebControls.ListItem @__ctrl11;
            @__ctrl11 = this.@__BuildControl__control13();
            @__ctrl.Add(@__ctrl11);
            global::System.Web.UI.WebControls.ListItem @__ctrl12;
            @__ctrl12 = this.@__BuildControl__control14();
            @__ctrl.Add(@__ctrl12);
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "15.0.0.0")]
        private global::System.Web.UI.WebControls.DropDownList @__BuildControlddlColumns() {
            global::System.Web.UI.WebControls.DropDownList @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.DropDownList();
            this.ddlColumns = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "ddlColumns";
            this.@__BuildControl__control2(@__ctrl.Items);
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "15.0.0.0")]
        private global::System.Web.UI.WebControls.Button @__BuildControlbtnSearch() {
            global::System.Web.UI.WebControls.Button @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.Button();
            this.btnSearch = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "btnSearch";
            @__ctrl.Text = "Search";
            @__ctrl.Width = new System.Web.UI.WebControls.Unit(56D, global::System.Web.UI.WebControls.UnitType.Pixel);
            @__ctrl.Click -= new System.EventHandler(this.search_Click);
            @__ctrl.Click += new System.EventHandler(this.search_Click);
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "15.0.0.0")]
        private void @__BuildControl__control17(System.Web.UI.WebControls.TableItemStyle @__ctrl) {
            @__ctrl.Font.Bold = true;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "15.0.0.0")]
        private global::System.Web.UI.WebControls.BoundField @__BuildControl__control16() {
            global::System.Web.UI.WebControls.BoundField @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.BoundField();
            @__ctrl.DataField = "Title";
            @__ctrl.HeaderText = "Company Name";
            this.@__BuildControl__control17(@__ctrl.HeaderStyle);
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "15.0.0.0")]
        private void @__BuildControl__control19(System.Web.UI.WebControls.TableItemStyle @__ctrl) {
            @__ctrl.Font.Bold = true;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "15.0.0.0")]
        private global::System.Web.UI.WebControls.BoundField @__BuildControl__control18() {
            global::System.Web.UI.WebControls.BoundField @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.BoundField();
            @__ctrl.DataField = "Category";
            @__ctrl.HeaderText = "Category";
            this.@__BuildControl__control19(@__ctrl.HeaderStyle);
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "15.0.0.0")]
        private global::System.Web.UI.WebControls.BoundField @__BuildControl__control20() {
            global::System.Web.UI.WebControls.BoundField @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.BoundField();
            @__ctrl.DataField = "WorkAddress";
            @__ctrl.HeaderText = "Address";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "15.0.0.0")]
        private void @__BuildControl__control22(System.Web.UI.WebControls.TableItemStyle @__ctrl) {
            @__ctrl.Font.Bold = true;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "15.0.0.0")]
        private global::System.Web.UI.WebControls.BoundField @__BuildControl__control21() {
            global::System.Web.UI.WebControls.BoundField @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.BoundField();
            @__ctrl.DataField = "WorkCity";
            @__ctrl.HeaderText = "City";
            this.@__BuildControl__control22(@__ctrl.HeaderStyle);
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "15.0.0.0")]
        private void @__BuildControl__control24(System.Web.UI.WebControls.TableItemStyle @__ctrl) {
            @__ctrl.Font.Bold = true;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "15.0.0.0")]
        private global::System.Web.UI.WebControls.BoundField @__BuildControl__control23() {
            global::System.Web.UI.WebControls.BoundField @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.BoundField();
            @__ctrl.DataField = "PostalCode";
            @__ctrl.HeaderText = "Postal Code";
            this.@__BuildControl__control24(@__ctrl.HeaderStyle);
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "15.0.0.0")]
        private global::System.Web.UI.WebControls.BoundField @__BuildControl__control25() {
            global::System.Web.UI.WebControls.BoundField @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.BoundField();
            @__ctrl.DataField = "state";
            @__ctrl.HeaderText = "State";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "15.0.0.0")]
        private global::System.Web.UI.WebControls.BoundField @__BuildControl__control26() {
            global::System.Web.UI.WebControls.BoundField @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.BoundField();
            @__ctrl.DataField = "Website";
            @__ctrl.HeaderText = "WebSite";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "15.0.0.0")]
        private global::System.Web.UI.WebControls.BoundField @__BuildControl__control27() {
            global::System.Web.UI.WebControls.BoundField @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.BoundField();
            @__ctrl.DataField = "Phone";
            @__ctrl.HeaderText = "Phone";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "15.0.0.0")]
        private global::System.Web.UI.WebControls.BoundField @__BuildControl__control28() {
            global::System.Web.UI.WebControls.BoundField @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.BoundField();
            @__ctrl.DataField = "WorkFax";
            @__ctrl.HeaderText = "WorkFax";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "15.0.0.0")]
        private global::System.Web.UI.WebControls.BoundField @__BuildControl__control29() {
            global::System.Web.UI.WebControls.BoundField @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.BoundField();
            @__ctrl.DataField = "Email";
            @__ctrl.HeaderText = "Email";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "15.0.0.0")]
        private global::System.Web.UI.WebControls.BoundField @__BuildControl__control30() {
            global::System.Web.UI.WebControls.BoundField @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.BoundField();
            @__ctrl.DataField = "stage";
            @__ctrl.HeaderText = "Stage";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "15.0.0.0")]
        private global::System.Web.UI.WebControls.BoundField @__BuildControl__control31() {
            global::System.Web.UI.WebControls.BoundField @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.BoundField();
            @__ctrl.DataField = "notes";
            @__ctrl.HeaderText = "Notes";
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "15.0.0.0")]
        private global::System.Web.UI.WebControls.LinkButton @__BuildControl__control34() {
            global::System.Web.UI.WebControls.LinkButton @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.LinkButton();
            @__ctrl.TemplateControl = this;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "lnkviewcontact";
            @__ctrl.Text = "View Contact..";
            @__ctrl.DataBinding += new System.EventHandler(this.@__DataBinding__control34);
            @__ctrl.Command -= new System.Web.UI.WebControls.CommandEventHandler(this.lnkviewcontact_Command);
            @__ctrl.Command += new System.Web.UI.WebControls.CommandEventHandler(this.lnkviewcontact_Command);
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "15.0.0.0")]
        public void @__DataBinding__control34(object sender, System.EventArgs e) {
            System.Web.UI.WebControls.LinkButton dataBindingExpressionBuilderTarget;
            System.Web.UI.IDataItemContainer Container;
            dataBindingExpressionBuilderTarget = ((System.Web.UI.WebControls.LinkButton)(sender));
            Container = ((System.Web.UI.IDataItemContainer)(dataBindingExpressionBuilderTarget.BindingContainer));
            dataBindingExpressionBuilderTarget.CommandArgument = global::System.Convert.ToString( Eval("ID") , global::System.Globalization.CultureInfo.CurrentCulture);
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "15.0.0.0")]
        private void @__BuildControl__control33(System.Web.UI.Control @__ctrl) {
            System.Web.UI.IParserAccessor @__parser = ((System.Web.UI.IParserAccessor)(@__ctrl));
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n             "));
            global::System.Web.UI.WebControls.LinkButton @__ctrl1;
            @__ctrl1 = this.@__BuildControl__control34();
            @__parser.AddParsedSubObject(@__ctrl1);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n\r\n          "));
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "15.0.0.0")]
        private void @__BuildControl__control35(System.Web.UI.WebControls.TableItemStyle @__ctrl) {
            @__ctrl.HorizontalAlign = global::System.Web.UI.WebControls.HorizontalAlign.Center;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "15.0.0.0")]
        private global::System.Web.UI.WebControls.TemplateField @__BuildControl__control32() {
            global::System.Web.UI.WebControls.TemplateField @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.TemplateField();
            @__ctrl.ItemTemplate = new System.Web.UI.CompiledBindableTemplateBuilder(new System.Web.UI.BuildTemplateMethod(this.@__BuildControl__control33), null);
            @__ctrl.ItemStyle.HorizontalAlign = global::System.Web.UI.WebControls.HorizontalAlign.Center;
            this.@__BuildControl__control35(@__ctrl.ItemStyle);
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "15.0.0.0")]
        private global::System.Web.UI.WebControls.BoundField @__BuildControl__control36() {
            global::System.Web.UI.WebControls.BoundField @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.BoundField();
            @__ctrl.DataField = "ID";
            @__ctrl.Visible = false;
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "15.0.0.0")]
        private void @__BuildControl__control15(System.Web.UI.WebControls.DataControlFieldCollection @__ctrl) {
            global::System.Web.UI.WebControls.BoundField @__ctrl1;
            @__ctrl1 = this.@__BuildControl__control16();
            @__ctrl.Add(@__ctrl1);
            global::System.Web.UI.WebControls.BoundField @__ctrl2;
            @__ctrl2 = this.@__BuildControl__control18();
            @__ctrl.Add(@__ctrl2);
            global::System.Web.UI.WebControls.BoundField @__ctrl3;
            @__ctrl3 = this.@__BuildControl__control20();
            @__ctrl.Add(@__ctrl3);
            global::System.Web.UI.WebControls.BoundField @__ctrl4;
            @__ctrl4 = this.@__BuildControl__control21();
            @__ctrl.Add(@__ctrl4);
            global::System.Web.UI.WebControls.BoundField @__ctrl5;
            @__ctrl5 = this.@__BuildControl__control23();
            @__ctrl.Add(@__ctrl5);
            global::System.Web.UI.WebControls.BoundField @__ctrl6;
            @__ctrl6 = this.@__BuildControl__control25();
            @__ctrl.Add(@__ctrl6);
            global::System.Web.UI.WebControls.BoundField @__ctrl7;
            @__ctrl7 = this.@__BuildControl__control26();
            @__ctrl.Add(@__ctrl7);
            global::System.Web.UI.WebControls.BoundField @__ctrl8;
            @__ctrl8 = this.@__BuildControl__control27();
            @__ctrl.Add(@__ctrl8);
            global::System.Web.UI.WebControls.BoundField @__ctrl9;
            @__ctrl9 = this.@__BuildControl__control28();
            @__ctrl.Add(@__ctrl9);
            global::System.Web.UI.WebControls.BoundField @__ctrl10;
            @__ctrl10 = this.@__BuildControl__control29();
            @__ctrl.Add(@__ctrl10);
            global::System.Web.UI.WebControls.BoundField @__ctrl11;
            @__ctrl11 = this.@__BuildControl__control30();
            @__ctrl.Add(@__ctrl11);
            global::System.Web.UI.WebControls.BoundField @__ctrl12;
            @__ctrl12 = this.@__BuildControl__control31();
            @__ctrl.Add(@__ctrl12);
            global::System.Web.UI.WebControls.TemplateField @__ctrl13;
            @__ctrl13 = this.@__BuildControl__control32();
            @__ctrl.Add(@__ctrl13);
            global::System.Web.UI.WebControls.BoundField @__ctrl14;
            @__ctrl14 = this.@__BuildControl__control36();
            @__ctrl.Add(@__ctrl14);
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "15.0.0.0")]
        private global::System.Web.UI.WebControls.GridView @__BuildControlgvcompamysearch() {
            global::System.Web.UI.WebControls.GridView @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.GridView();
            this.gvcompamysearch = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "gvcompamysearch";
            @__ctrl.AutoGenerateColumns = false;
            @__ctrl.Height = new System.Web.UI.WebControls.Unit(169D, global::System.Web.UI.WebControls.UnitType.Pixel);
            @__ctrl.Width = new System.Web.UI.WebControls.Unit(942D, global::System.Web.UI.WebControls.UnitType.Pixel);
            this.@__BuildControl__control15(@__ctrl.Columns);
            @__ctrl.RowCommand -= new System.Web.UI.WebControls.GridViewCommandEventHandler(this.gvcompamysearch_RowCommand);
            @__ctrl.RowCommand += new System.Web.UI.WebControls.GridViewCommandEventHandler(this.gvcompamysearch_RowCommand);
            @__ctrl.SelectedIndexChanged -= new System.EventHandler(this.gvcompamysearch_SelectedIndexChanged);
            @__ctrl.SelectedIndexChanged += new System.EventHandler(this.gvcompamysearch_SelectedIndexChanged);
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "15.0.0.0")]
        private void @__BuildControlTree(global::LTI.LeadsManagement.CompanySearchWebPart.CompanySearchWebPart @__ctrl) {
            System.Web.UI.IParserAccessor @__parser = ((System.Web.UI.IParserAccessor)(@__ctrl));
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n<strong>\r\n"));
            global::System.Web.UI.WebControls.Label @__ctrl1;
            @__ctrl1 = this.@__BuildControlLabel1();
            @__parser.AddParsedSubObject(@__ctrl1);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n</strong>\r\n\r\n<table style=\"width: 100%;\">\r\n    <tr>\r\n        <td>Keyword :</td>" +
                        "\r\n        <td>\r\n            "));
            global::System.Web.UI.WebControls.TextBox @__ctrl2;
            @__ctrl2 = this.@__BuildControltxtKeyword();
            @__parser.AddParsedSubObject(@__ctrl2);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n        </td>\r\n        <td>\r\n            Find in :\r\n        </td>\r\n        <td>" +
                        "\r\n            "));
            global::System.Web.UI.WebControls.DropDownList @__ctrl3;
            @__ctrl3 = this.@__BuildControlddlColumns();
            @__parser.AddParsedSubObject(@__ctrl3);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n        </td>\r\n        <td>\r\n            "));
            global::System.Web.UI.WebControls.Button @__ctrl4;
            @__ctrl4 = this.@__BuildControlbtnSearch();
            @__parser.AddParsedSubObject(@__ctrl4);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n        </td>\r\n    </tr>\r\n</table>\r\n\r\n"));
            global::System.Web.UI.WebControls.GridView @__ctrl5;
            @__ctrl5 = this.@__BuildControlgvcompamysearch();
            @__parser.AddParsedSubObject(@__ctrl5);
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl("\r\n<p>\r\n    &nbsp;</p>\r\n\r\n"));
        }
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "15.0.0.0")]
        private void InitializeControl() {
            this.@__BuildControlTree(this);
            this.Load += new global::System.EventHandler(this.Page_Load);
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "15.0.0.0")]
        protected virtual object Eval(string expression) {
            return global::System.Web.UI.DataBinder.Eval(this.Page.GetDataItem(), expression);
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "15.0.0.0")]
        protected virtual string Eval(string expression, string format) {
            return global::System.Web.UI.DataBinder.Eval(this.Page.GetDataItem(), expression, format);
        }
    }
}
