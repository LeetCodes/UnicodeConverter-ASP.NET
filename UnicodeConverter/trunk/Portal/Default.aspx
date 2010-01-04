<%@ Page Title="" EnableEventValidation="false" Language="C#" MasterPageFile="~/Master/Portal.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Hajloo.FOSS.UnicodeConverter.Web.UI.Default" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajax" %>
<%@ Register TagPrefix="Hajloo" TagName="UnicodeInformation" Src="~/Modules/UnicodeInformation.ascx" %>
<%@ Register TagPrefix="Hajloo" TagName="About" Src="~/Modules/About.ascx" %>
<%@ Register TagPrefix="Hajloo" TagName="ConvertToUnicode" Src="~/Modules/ConvertToUnicode.ascx" %>
<%@ Register TagPrefix="Hajloo" TagName="ConvertFromUnicode" Src="~/Modules/ConvertFromUnicode.ascx" %>
<%@ Register TagPrefix="Hajloo" TagName="Standards" Src="~/Modules/Standards.ascx" %>
<%@ Register TagPrefix="Hajloo" TagName="HelpAndHowTo" Src="~/Modules/HelpAndHowTo.ascx" %>

<asp:Content ID="MetaContent" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="DefaultContent" ContentPlaceHolderID="UnicodeConverterContent" runat="server">
    <div id="Sidebar">
        <div id="SideTopSeperator">
        </div>
        <asp:LinkButton ID="lnbConvertToUnicode" runat="server" SkinID="SideLink" Text="<%$ Resources: CommonResources, ConvertToUnicode %>" onclick="lnbConvertToUnicode_Click" />
        <asp:LinkButton ID="lnbConvertFromUnicode" runat="server" SkinID="SideLink" Text="<%$ Resources: CommonResources, ConvertFromUnicode %>" onclick="lnbConvertFromUnicode_Click" />
        <asp:LinkButton ID="lnbUnicodeInformation" runat="server" SkinID="SideLink" Text="<%$ Resources: CommonResources, UnicodeInformation %>" onclick="lnbUnicodeInformation_Click" />
        <asp:LinkButton ID="lnbStandards" runat="server" SkinID="SideLink" Text="<%$ Resources: CommonResources, Standards %>" onclick="lnbStandards_Click" />
        <span id="SideBottom">
            <asp:LinkButton ID="lnbHelpAndHowTo" runat="server" SkinID="SideLink" Text="<%$ Resources: CommonResources, HelpAndHowTo %>" onclick="lnbHelpAndHowTo_Click" />
            <asp:LinkButton ID="lnbAbout" runat="server" SkinID="SideLink" Text="<%$ Resources: CommonResources, About %>" onclick="lnbAbout_Click" />
        </span>
    </div>
    <div id="Content">
        <Hajloo:About ID="AboutControl" runat="server" />
        <Hajloo:ConvertFromUnicode ID="ConvertFromUnicode" runat="server" />
        <Hajloo:ConvertToUnicode ID="ConvertToUnicode" runat="server" />
        <Hajloo:Standards ID="StandardsControl" runat="server" />
        <Hajloo:UnicodeInformation ID="UnicodeInformationControl" runat="server" />
        <Hajloo:HelpAndHowTo ID="HelpAndHowToControl" runat="server" />
    </div>
</asp:Content>