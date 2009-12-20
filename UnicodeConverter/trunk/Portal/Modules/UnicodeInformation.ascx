<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UnicodeInformation.ascx.cs" Inherits="Hajloo.FOSS.UnicodeConverter.Web.UI.Modules.UnicodeInformation" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajax" %>

<div id="UnicodeInformation">
    <div id="TitleContainer">
        <h1>
            <asp:Label ID="lblTitle" runat="server" SkinID="Title" Text="<%$ Resources: CommonResources, UnicodeInformationTitle %>" />
        </h1>
    </div>
    <div id="UnicodeInformationContent">
        <ajax:RoundedCornersExtender ID="rceUnicodeInformation" TargetControlID="pnlUnicodeInformation" Corners="All" Radius="10" runat="server" />
        <asp:Panel ID="pnlUnicodeInformation" runat="server" CssClass="UnicodeInformationPanel" >
            <div id="UnicodeInformation_Row1">
            </div>
            <div id="UnicodeInformation_Row2">
            </div>
            <div id="UnicodeInformation_Row3">
            </div>
            <div id="UnicodeInformation_Row4">
            </div>
            <div id="UnicodeInformation_Row5">
            </div>
            <div id="UnicodeInformation_Result">
                <asp:TextBox ID="txtUnicodeHexCodeResult" runat="server" TextMode="MultiLine" SkinID="UnicodeInformationResult" />
                <asp:TextBox ID="txtUnicodeTextResult" runat="server" TextMode="MultiLine" SkinID="UnicodeInformationResult" />
            </div>
        </asp:Panel>
    </div>
</div>