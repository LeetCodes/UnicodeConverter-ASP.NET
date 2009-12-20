<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ConvertFromUnicode.ascx.cs" Inherits="Hajloo.FOSS.UnicodeConverter.Web.UI.Modules.ConvertFromUnicode" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajax" %>

<div id="ConvertFromUnicode">
    <div id="TitleContainer">
        <h1>
            <asp:Label ID="lblTitle" runat="server" SkinID="Title" Text="<%$ Resources: CommonResources, ConvertFromUnicodeTitle %>" />
        </h1>
    </div>
    <div id="ConvertFromUnicodeContent">
        <p>
        <asp:Label ID="lblConvertFromUnicodeMainText" runat="server" Text="<%$ Resources: CommonResources, ConvertFromUnicodeMainText %>" />
        </p>
        <br />
        <ajax:RoundedCornersExtender ID="rceConvertFromUnicode" TargetControlID="pnlConvertFromUnicode" Corners="All" Radius="10" runat="server" />
        <asp:Panel ID="pnlConvertFromUnicode" runat="server" CssClass="ConvertFromUnicodePanel" DefaultButton="btnDecode">
            <div id="ConvertFromUnicodeInputSection">
                <asp:Label ID="lblHexCode" runat="server" Text="<%$ Resources: CommonResources, ConvertToUnicodeHexCode %>" />
                <asp:TextBox ID="txtInput" runat="server" SkinID="Input" />
                <asp:Button ID="btnDecode" runat="server" SkinID="Button" Text="<%$ Resources: CommonResources, ConvertFromUnicodeDeCode %>" OnClick="btnDecode_Click" />
            </div>
            <asp:UpdatePanel ID="upResult" runat="server" UpdateMode="Conditional">
                <ContentTemplate>
                    <div id="ConvertFromUnicodeResultSection">
                        <asp:TextBox ID="txtResult" runat="server" SkinID="Result" TextMode="MultiLine" />
                    </div>
                </ContentTemplate>
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="btnDecode" EventName="Click" />
                </Triggers>
            </asp:UpdatePanel>
        </asp:Panel>
    </div>
</div>