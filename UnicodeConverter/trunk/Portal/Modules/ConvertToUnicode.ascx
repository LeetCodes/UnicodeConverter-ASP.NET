<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ConvertToUnicode.ascx.cs" Inherits="Hajloo.FOSS.UnicodeConverter.Web.UI.Modules.ConvertToUnicode" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajax" %>

<div id="ConvertToUnicode">
    <div id="TitleContainer">
        <h1>
            <asp:Label ID="lblTitle" runat="server" SkinID="Title" Text="<%$ Resources: CommonResources, ConvertToUnicodeTitle %>" />
        </h1>
    </div>
    <div id="ConvertToUnicodeContent">
        <p>
        <asp:Label ID="lblConvertToUnicodeMainText" runat="server" Text="<%$ Resources: CommonResources, ConvertToUnicodeMainText %>" />
        </p>
        <br />
        <ajax:RoundedCornersExtender ID="rceConvertToUnicode" TargetControlID="pnlConvertToUnicode" Corners="All" Radius="10" runat="server" />
        <asp:Panel ID="pnlConvertToUnicode" runat="server" CssClass="ConvertToUnicodePanel" DefaultButton="btnConvert">
            <div id="ConvertToUnicodeInputSection">
                <asp:Label ID="lblWords" runat="server" Text="<%$ Resources: CommonResources, ConvertToUnicodeWords %>" />
                <asp:TextBox ID="txtInput" runat="server" SkinID="Input" />
                <asp:Button ID="btnConvert" runat="server" SkinID="Button" Text="<%$ Resources: CommonResources, ConvertToUnicodeConvert %>" OnClick="btnConvert_Click" />
            </div>
            <asp:UpdatePanel ID="upResult" runat="server" UpdateMode="Conditional">
                <ContentTemplate>
                    <div id="ConvertToUnicodeResultSection">
                        <asp:TextBox ID="txtResult" runat="server" SkinID="Result" TextMode="MultiLine" />
                    </div>
                </ContentTemplate>
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="btnConvert" EventName="Click" />
                </Triggers>
            </asp:UpdatePanel>
        </asp:Panel>
    </div>
</div>