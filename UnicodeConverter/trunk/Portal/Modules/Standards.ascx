<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Standards.ascx.cs" Inherits="Hajloo.FOSS.UnicodeConverter.Web.UI.Modules.Standards" %>

<div id="Standards">
    <div id="TitleContainer">
        <h1>
            <asp:Label ID="lblTitle" runat="server" SkinID="Title" Text="<%$ Resources: CommonResources, StandardsTitle %>" />
        </h1>
    </div>
    <div id="StandardsContent">
        <asp:UpdatePanel ID="upResults" runat="server" UpdateMode="Conditional">
            <ContentTemplate>
                <div id="StandardListContainer">
                    <asp:Label ID="StandardsListTopTitle" runat="server" Text="<%$ Resources: CommonResources, StandardsListTopTitle %>" />
                    <asp:ListBox ID="lstCountries" runat="server" CssClass="StandardList" OnSelectedIndexChanged="lstCountries_SelectedIndexChanged" SelectionMode="Single" AutoPostBack="True" />
                </div>
                <div id="StandardResult">
                    <div id="StandardResultTop">
                        <asp:Label ID="lblStandardsListResultTitle" runat="server" Text="<%$ Resources: CommonResources, StandardsListResultTitle %>" />
                    </div>
                    <div id="StandardResultLabels">
                        <asp:Label ID="StandardsList_Country" runat="server" Text="<%$ Resources: CommonResources, StandardsList_Country %>" />
                        <asp:Label ID="lblStandardsList_KeyboardLayout" runat="server" Text="<%$ Resources: CommonResources, StandardsList_KeyboardLayout %>" />
                        <asp:Label ID="lblStandardsList_StandardDate" runat="server" Text="<%$ Resources: CommonResources, StandardsList_StandardDate %>" />
                        <asp:Label ID="lblStandardsList_License" runat="server" Text="<%$ Resources: CommonResources, StandardsList_License %>" />
                        <asp:Label ID="lblStandardsList_Producer" runat="server" Text="<%$ Resources: CommonResources, StandardsList_Producer %>" />
                        <asp:Label ID="lblStandardsList_ProjectURL" runat="server" Text="<%$ Resources: CommonResources, StandardsList_ProjectURL %>" />
                        <asp:Label ID="lblStandardsList_Referer" runat="server" Text="<%$ Resources: CommonResources, StandardsList_Referer %>" />
                        <asp:Label ID="lblStandardsList_RefererMail" runat="server" Text="<%$ Resources: CommonResources, StandardsList_RefererMail %>" />
                    </div>  
                    <div id="StandardResultData">
                        <asp:Label ID="lblCountry" runat="server" />
                        <asp:Label ID="lblKeyboardLayout" runat="server" />
                        <asp:Label ID="lblStandardDate" runat="server" />
                        <asp:Label ID="lblLicense" runat="server" />
                        <asp:Label ID="lblProducer" runat="server" />
                        <asp:HyperLink ID="lnkProjectURL" runat="server" />
                        <asp:Label ID="lblReferer" runat="server" />
                        <asp:Label ID="lblRefererMail" runat="server" />
                    </div>
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
</div>