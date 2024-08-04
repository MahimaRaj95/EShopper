<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="PaymentPage.aspx.cs" Inherits="Ecom.PaymentPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style3 {
            width: 378px;
            height: 27px;
        }
        .auto-style4 {
            height: 27px;
        }
        .auto-style8 {
            width: 251px;
            height: 24px;
        }
        .auto-style14 {
            width: 251px;
        }
        .auto-style16 {
            width: 294px;
            height: 24px;
        }
        .auto-style17 {
            width: 294px;
        }
        .auto-style18 {
            width: 294px;
            font-family:'Copperplate Gothic';
            font-size:larger;
        }
        .auto-style19 {
            width: 251px;
            height: 25px;
        }
        .auto-style20 {
            width: 294px;
            height: 25px;
        }
        .auto-style21 {
            width: 378px;
        }
        .auto-style22 {
            width: 251px;
            height: 26px;
        }
        .auto-style23 {
            width: 294px;
            height: 26px;
        }
        .auto-style24 {
            width: 378px;
            height: 29px;
        }
        .auto-style25 {
            height: 29px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style21">&nbsp;</td>
            <td>
                <asp:Panel ID="Panel1" runat="server" BackColor="#FFCCFF" Width="359px">
                    <table class="auto-style1">
                        <tr>
                            <td class="auto-style14">
                                &nbsp;</td>
                            <td class="auto-style17">&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style14">&nbsp;</td>
                            <td class="auto-style18">
                                <asp:Label ID="Label1" runat="server" ForeColor="#FF5050" Text="Payment Gateway" Font-Bold="True"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style19"></td>
                            <td class="auto-style20"></td>
                        </tr>
                        <tr>
                            <td class="auto-style8">
                                <asp:Label ID="Label2" runat="server" ForeColor="#6600FF" Text="   Total Amount"></asp:Label>
                            </td>
                            <td class="auto-style16">
                                <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style22">
                                &nbsp;</td>
                            <td class="auto-style23">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style14">
                                <asp:Label ID="Label3" runat="server" ForeColor="#9966FF" Text="Acount No."></asp:Label>
                            </td>
                            <td class="auto-style17">
                                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style14">
                                &nbsp;</td>
                            <td class="auto-style17">&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style14">
                                <asp:Label ID="Label5" runat="server" Text="Mobile No" Visible="False"></asp:Label>
                            </td>
                            <td class="auto-style17">
                                <asp:Label ID="Label6" runat="server" Text="Label" Visible="False"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style14">&nbsp;</td>
                            <td class="auto-style17">&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style14">&nbsp;</td>
                            <td class="auto-style17">
                                <asp:Button ID="Button1" runat="server" BackColor="#FF6666" ForeColor="Yellow" Text="Pay" OnClick="Button1_Click" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style14">
                                <asp:Label ID="Label7" runat="server" Text="Label" Visible="False"></asp:Label>
                            </td>
                            <td class="auto-style17">&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style14">&nbsp;</td>
                            <td class="auto-style17">&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style14">&nbsp;</td>
                            <td class="auto-style17">&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style14">&nbsp;</td>
                            <td class="auto-style17">&nbsp;</td>
                        </tr>
                    </table>
                </asp:Panel>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style24"></td>
            <td class="auto-style25"></td>
            <td class="auto-style25"></td>
            <td class="auto-style25"></td>
        </tr>
        <tr>
            <td class="auto-style21">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3"></td>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style4"></td>
            <td class="auto-style4"></td>
        </tr>
        <tr>
            <td class="auto-style21">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style21">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style21">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style21">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style21">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style21">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style21">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
