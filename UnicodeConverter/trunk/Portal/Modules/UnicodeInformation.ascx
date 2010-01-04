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
        <asp:Panel ID="pnlUnicodeInformation" runat="server" CssClass="UnicodeInformationPanel">
            <asp:UpdatePanel ID="upUnicodeInformation" runat="server" UpdateMode="Conditional">
                <ContentTemplate>
                    <div class="UnicodeInformationRow">
                        <span class="FirstColLabelContainer">
                            <asp:Label ID="lblChar" runat="server" SkinID="Simple" Text="<%$ Resources: CommonResources, UnicodeInformationCharLabel %>" />
                        </span>
                        <span class="SecondColControlContainer">
                            <asp:TextBox ID="txtChar" runat="server" SkinID="InformationalInput" />
                        </span>
                        <span class="SecondColLabelContainer">
                            <asp:Button ID="btnGetInfotmation" runat="server" SkinID="Button" Text="<%$ Resources: CommonResources, UnicodeInformationInformationButton %>" OnClick="btnGetInfotmation_Click" />
                        </span>
                        <span class="FirstColControlContainer">
                            <asp:Button ID="btnAddToWord" runat="server" SkinID="Button" Text="<%$ Resources: CommonResources, UnicodeInformationAddToWordButton %>" OnClick="btnAddToWord_Click" />
                        </span>
                    </div>
                    <div class="UnicodeInformationRow">
                        <span class="FirstColLabelContainer">
                            <asp:Label ID="lblShape" runat="server" SkinID="Simple" Text="<%$ Resources: CommonResources, UnicodeInformationShapeLabel %>" />
                        </span>
                        <span class="FirstColControlContainer">
                            <asp:Label ID="lblUnicodeShape" runat="server" SkinID="Bold" />
                        </span>
                        <span class="SecondColLabelContainer">
                            <asp:Label ID="lblName" runat="server" SkinID="Simple" Text="<%$ Resources: CommonResources, UnicodeInformationNameLabel %>" />
                        </span>
                        <span class="SecondColControlContainer">
                            <asp:Label ID="lblUnicodeName" runat="server" SkinID="Simple" />
                        </span>
                    </div>
                    <div class="UnicodeInformationRow">
                        <span class="FirstColLabelContainer">
                            <asp:Label ID="lblHexCode" runat="server" SkinID="Simple" Text="<%$ Resources: CommonResources, UnicodeInformationHexCodeLabel %>" />
                        </span>
                        <span class="FirstColControlContainer">
                            <ajax:FilteredTextBoxExtender ID="ftbeHexCode" runat="server" FilterType="Numbers" TargetControlID="txtHexCode" />
                            <asp:TextBox ID="txtHexCode" runat="server" SkinID="Input" />
                            <asp:Button ID="btnGetHexCodeInfo" runat="server" SkinID="Button" Text="<%$ Resources: CommonResources, UnicodeInformationGetHexCodeInfoButton %>" OnClick="btnGetHexCodeInfo_Click" />
                        </span>
                        <span class="SecondColLabelContainer">
                            <asp:Label ID="lblDecimal" runat="server" SkinID="Simple" Text="<%$ Resources: CommonResources, UnicodeInformationDecimalLabel %>" />
                        </span>
                        <span class="SecondColControlContainer">
                            <ajax:FilteredTextBoxExtender ID="ftbeDecimal" runat="server" FilterType="Numbers" TargetControlID="txtDecimal" />
                            <asp:TextBox ID="txtDecimal" runat="server" SkinID="Input" />
                            <asp:Button ID="btnGetDecimalInfo" runat="server" SkinID="Button" Text="<%$ Resources: CommonResources, UnicodeInformationGetDecimalInfoButton %>" OnClick="btnGetDecimalInfo_Click" />
                        </span>
                    </div>
                    <div class="UnicodeInformationRow">
                        <span class="FirstColLabelContainer">
                            <asp:Label ID="lblType" runat="server" SkinID="Simple" Text="<%$ Resources: CommonResources, UnicodeInformationTypeLabel %>" />
                        </span>
                        <span class="FirstColControlContainer">
                            <asp:Label ID="lblUnicodeType" runat="server" SkinID="Bold" />
                        </span>
                        <span class="SecondColLabelContainer">
                            <asp:Label ID="lblCategory" runat="server" SkinID="Simple" Text="<%$ Resources: CommonResources, UnicodeInformationCategoryLabel %>" />
                        </span>
                        <span class="SecondColControlContainer">
                            <asp:Label ID="lblUnicodeCategory" runat="server" SkinID="Simple" />
                        </span>
                    </div>
                    <div class="UnicodeInformationRow">
                        <span class="FirstColLabelContainer">
                            <asp:Label ID="lblRange" runat="server" SkinID="Simple" Text="<%$ Resources: CommonResources, UnicodeInformationRangeLabel %>" />
                        </span>
                        <span class="FirstColControlContainer">
                            <asp:Label ID="lblUnicodeRange" runat="server" SkinID="Bold" />
                        </span>
                        <span class="SecondColLabelContainer">
                            <asp:Label ID="lblIsBidi" runat="server" SkinID="Simple" Text="<%$ Resources: CommonResources, UnicodeInformationIsBidiLabel %>" />
                        </span>
                        <span class="SecondColControlContainer">
                            <asp:Label ID="lblDirectionalityStatus" runat="server" SkinID="Simple" />
                        </span>
                    </div>
                    <div class="UnicodeInformationRow">
                        <asp:Label ID="lblResults" runat="server" SkinID="Bold" Text="<%$ Resources: CommonResources, UnicodeInformationResultsLabel %>" />
                    </div>
                    <div class="UnicodeInformationRow">
                        <asp:TextBox ID="txtUnicodeHexCodeResult" runat="server" TextMode="MultiLine" SkinID="UnicodeInformationResult" />
                        <asp:TextBox ID="txtUnicodeTextResult" runat="server" TextMode="MultiLine" SkinID="UnicodeInformationResult" />
                    </div>
                    </ContentTemplate>
            </asp:UpdatePanel>
        </asp:Panel>
    </div>
</div>