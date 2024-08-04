<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="FeedBackForm.aspx.cs" Inherits="Ecom.FeedBackForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        width: 100%;
    }
    .auto-style2 {
        width: 368px;
    }
    .auto-style3 {
        width: 368px;
        height: 24px;
    }
    .auto-style4 {
            height: 24px;
        }
        .auto-style6 {
            width: 188px;
        }
        .auto-style7 {
            width: 368px;
            height: 22px;
        }
        .auto-style8 {
            height: 22px;
        }
        .auto-style9 {
            width: 368px;
            height: 23px;
        }
        .auto-style10 {
            height: 23px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
    <tr>
        <td class="auto-style2">
            <asp:Label ID="Label3" runat="server" BackColor="#FFFF66" Font-Size="XX-Large" ForeColor="#CC0000" Text="Label" Visible="False"></asp:Label>
        </td>
        <td>
            &nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style9">
            <table __designer:mapid="c" class="auto-style1">
                <tr __designer:mapid="d">
                    <td __designer:mapid="e" class="auto-style6">
            <asp:Label ID="Label1" runat="server" Font-Size="X-Large" ForeColor="#9900FF" Text="Feed Back Form"></asp:Label>
                    </td>
                    <td __designer:mapid="f">&nbsp;</td>
                    <td __designer:mapid="10">&nbsp;</td>
                </tr>
                <tr __designer:mapid="11">
                    <td __designer:mapid="12" class="auto-style6">
            <asp:Label ID="Label2" runat="server" ForeColor="#333399" Text="Enter Your Experience here!"></asp:Label>
                    </td>
                    <td __designer:mapid="13">&nbsp;</td>
                    <td __designer:mapid="14">&nbsp;</td>
                </tr>
                <tr __designer:mapid="15">
                    <td __designer:mapid="16" class="auto-style6">
            <asp:TextBox ID="TextBox1" runat="server" Height="108px" TextMode="MultiLine" Width="689px"></asp:TextBox>
                    </td>
                    <td __designer:mapid="17">&nbsp;</td>
                    <td __designer:mapid="18">&nbsp;</td>
                </tr>
                <tr __designer:mapid="19">
                    <td __designer:mapid="1a" class="auto-style6">
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Send" />
                    </td>
                    <td __designer:mapid="1b">&nbsp;</td>
                    <td __designer:mapid="1c">&nbsp;</td>
                </tr>
                <tr __designer:mapid="1d">
                    <td __designer:mapid="1e" class="auto-style6">&nbsp;</td>
                    <td __designer:mapid="1f">&nbsp;</td>
                    <td __designer:mapid="20">&nbsp;</td>
                </tr>
            </table>
        </td>
        <td class="auto-style10"></td>
        <td class="auto-style10"></td>
        <td class="auto-style10"></td>
    </tr>
    <tr>
        <td class="auto-style7">
        </td>
        <td class="auto-style8"></td>
        <td class="auto-style8"></td>
        <td class="auto-style8"></td>
    </tr>
    <tr>
        <td class="auto-style3">
        </td>
        <td class="auto-style4"></td>
        <td class="auto-style4"></td>
        <td class="auto-style4"></td>
    </tr>
    <tr>
        <td class="auto-style2">
            <asp:Panel ID="Panel1" runat="server">
            </asp:Panel>
        </td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style2">&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>
