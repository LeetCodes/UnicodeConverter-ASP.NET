<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="About.ascx.cs" Inherits="Hajloo.FOSS.UnicodeConverter.Web.UI.Modules.About" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajax" %>

<div id="UnicodeInformation">
    <div id="TitleContainer">
        <h1>
            <asp:Label ID="lblTitle" runat="server" SkinID="Title" Text="<%$ Resources: CommonResources, AboutTitle %>" />
        </h1>
    </div>
    <div id="AboutContent">
        <div class="AboutRow">
            <asp:Label ID="lblAboutDescription" runat="server" SkinID="Simple" Text="<%$ Resources: CommonResources, AboutDescription %>" />
        </div>
        <br />
        <div class="AboutRow">
            <span class="AboutLabelContainer">
                <asp:Label ID="lblDevelopersLabel" runat="server" SkinID="Simple" Text="<%$ Resources: CommonResources, AboutDevelopersLabel %>" />
            </span>
            <span class="AboutControlContainer">
                <asp:Label ID="lblDevelopers" runat="server" SkinID="Bold" />
            </span>
        </div>
        <div class="AboutRow">
            <span class="AboutLabelContainer">
                <asp:Label ID="lblProjectManagerLabel" runat="server" SkinID="Simple" Text="<%$ Resources: CommonResources, AboutProjectManagerLabel %>" />
            </span>
            <span class="AboutControlContainer">
                <asp:Label ID="lblProjectManager" runat="server" SkinID="Bold" />
            </span>
        </div>
        <div class="AboutRow">
            <span class="AboutLabelContainer">
                <asp:Label ID="lbleMailLabel" runat="server" SkinID="Simple" Text="<%$ Resources: CommonResources, AbouteMailLabel %>" />
            </span>
            <span class="AboutControlContainer">
                <asp:Label ID="lbleMail" runat="server" SkinID="Bold" />
            </span>
        </div>
        <div class="AboutRow">
            <span class="AboutLabelContainer">
                <asp:Label ID="lblBlogLabel" runat="server" SkinID="Simple" Text="<%$ Resources: CommonResources, AboutBlogLabel %>" />
            </span>
            <span class="AboutControlContainer">
                <asp:HyperLink ID="lnkBlog" runat="server" />
            </span>
        </div>
        <div class="AboutRow">
            <span class="AboutLabelContainer">
                <asp:Label ID="lblVersionLabel" runat="server" SkinID="Simple" Text="<%$ Resources: CommonResources, AboutVersionLabel %>" />
            </span>
            <span class="AboutControlContainer">
                <asp:Label ID="lblVersion" runat="server" SkinID="Bold" />
            </span>
        </div>
        <div class="AboutRow">
            <span class="AboutLabelContainer">
                <asp:Label ID="lblLastVersionLabel" runat="server" SkinID="Simple" Text="<%$ Resources: CommonResources, AboutLastVersionLabel %>" />
            </span>
            <span class="AboutControlContainer">
                <asp:Label ID="lblLastVersion" runat="server" SkinID="Bold" />
            </span>
        </div>
        <div class="AboutRow">
            <span class="AboutLabelContainer">
                <asp:Label ID="lblProjectHostLabel" runat="server" SkinID="Simple" Text="<%$ Resources: CommonResources, AboutProjectHostLabel %>" />
            </span>
            <span class="AboutControlContainer">
                <asp:Label ID="lblProjectHost" runat="server" SkinID="Bold" />
            </span>
        </div>
        <div class="AboutRow">
            <span class="AboutLabelContainer">
                <asp:Label ID="lblProjectURL" runat="server" SkinID="Simple" Text="<%$ Resources: CommonResources, AboutProjectURL %>" />
            </span>
            <span class="AboutControlContainer">
                <asp:HyperLink ID="lnkProjectURL" runat="server" />
            </span>
        </div>
        <div class="AboutRow">
            <span class="AboutLabelContainer">
                <asp:Label ID="lblProjectLicenseLabel" runat="server" SkinID="Simple" Text="<%$ Resources: CommonResources, AboutProjectLicenseLabel %>" />
            </span>
            <span class="AboutControlContainer">
                <asp:Label ID="lblProjectLicense" runat="server" SkinID="Bold" />
            </span>
        </div>
    </div>
</div>