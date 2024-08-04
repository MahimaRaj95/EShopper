<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ViewCart.aspx.cs" Inherits="Ecom.ViewCart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 405px;
        }
        .auto-style3 {
            width: 405px;
            height: 26px;
        }
        .auto-style4 {
            height: 26px;
        }
        .auto-style5 {
            width: 405px;
            height: 39px;
        }
        .auto-style6 {
            height: 39px;
        }
        .auto-style10 {
            width: 12px;
        }
        .auto-style11 {
            height: 26px;
            width: 12px;
        }
        .auto-style12 {
            margin-top: 18px;
        }
        .auto-style15 {
            width: 297px;
            height: 46px;
        }
        .auto-style16 {
            width: 12px;
            height: 46px;
        }
        .auto-style17 {
            height: 46px;
        }
        .auto-style20 {
            width: 112px;
            height: 46px;
        }
        .auto-style23 {
            width: 50px;
        }
        .auto-style24 {
            height: 26px;
            width: 50px;
        }
        .auto-style25 {
            height: 46px;
            width: 50px;
        }
        .auto-style26 {
            width: 112px;
        }
        .auto-style27 {
            height: 26px;
            width: 112px;
        }
        .auto-style30 {
            width: 297px;
        }
        .auto-style31 {
            height: 26px;
            width: 297px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="w-100">
        <tr>
            <td class="auto-style2">
                <asp:DataList ID="DataList1" runat="server" HorizontalAlign="Justify" RepeatColumns="5" RepeatDirection="Horizontal">
                    <HeaderStyle HorizontalAlign="Justify" />
                    <ItemStyle HorizontalAlign="Justify" />
                    <ItemTemplate>
                        <table class="w-100">
                            <tr>
                                <td class="auto-style30">
                                    <asp:Image ID="Image1" runat="server" BorderColor="Black" BorderStyle="Solid" ImageAlign="Middle" ImageUrl='<%# Eval("Pro_Image") %>' Width="143px" />
                                </td>
                                <td class="auto-style10">&nbsp;</td>
                                <td class="auto-style23">&nbsp;</td>
                                <td class="auto-style26">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style30">
                                    <asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Size="Larger" ForeColor="#FF5050" Text='<%# Eval("Pro_Name") %>'></asp:Label>
                                </td>
                                <td class="auto-style10">&nbsp;</td>
                                <td class="auto-style23">&nbsp;</td>
                                <td class="auto-style26">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style30">
                                    <asp:Label ID="Label11" runat="server" Font-Bold="True" Font-Italic="False" Font-Size="Small" ForeColor="Black" Text="Unit Price"></asp:Label>
                                    <asp:Label ID="Label7" runat="server" ForeColor="Black" Text='<%# Eval("Pro_Rate") %>'></asp:Label>
                                </td>
                                <td class="auto-style10">&nbsp;</td>
                                <td class="auto-style23">&nbsp;</td>
                                <td class="auto-style26">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style30">
                                    <asp:Label ID="Label12" runat="server" Font-Bold="True" Font-Size="Small" ForeColor="Black" Text="Qty"></asp:Label>
                                    &nbsp; </td>
                                <td class="auto-style10">&nbsp;</td>
                                <td class="auto-style23">&nbsp;</td>
                                <td class="auto-style26">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style30">
                                    <asp:Label ID="Label8" runat="server" BorderStyle="Solid" CssClass="auto-style12" ForeColor="#333333" Height="30px" Text='<%# Eval("Pro_Qty") %>' Width="59px"></asp:Label>
                                    <asp:ImageButton ID="imgPlus" runat="server" BorderColor="Black" BorderStyle="Solid" CommandArgument='<%# Eval("Cart_Id") %>' Height="25px" ImageAlign="Middle" ImageUrl="~/img/plus.jpg" OnClick="imgPlus_Click" OnCommand="imgPlus_Command" Width="25px" />
                                    <asp:ImageButton ID="imgMinus" runat="server" BorderColor="Black" BorderStyle="Solid" CommandArgument='<%# Eval("Cart_Id") %>' Height="25px" ImageAlign="Middle" ImageUrl="~/img/minus.jpg" OnCommand="imgMinus_Command" Width="25px" />
                                </td>
                                <td class="auto-style10">
                                    &nbsp;</td>
                                <td class="auto-style23">
                                    &nbsp;</td>
                                <td class="auto-style26">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style30">
                                    <asp:Label ID="Label13" runat="server" Font-Bold="True" Font-Size="Small" ForeColor="Black" Text="Total"></asp:Label>
                                    &nbsp;$
                                    <asp:Label ID="Label10" runat="server" ForeColor="Red" Text='<%# Eval("subtotal") %>'></asp:Label>
                                </td>
                                <td class="auto-style10">&nbsp;</td>
                                <td class="auto-style23">&nbsp;</td>
                                <td class="auto-style26">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style31">
                                    <asp:Label ID="Label9" runat="server" ForeColor="Lime" Text='<%# Eval("Pro_Status") %>'></asp:Label>
                                </td>
                                <td class="auto-style11"></td>
                                <td class="auto-style24"></td>
                                <td class="auto-style27"></td>
                                <td class="auto-style4"></td>
                                <td class="auto-style4"></td>
                            </tr>
                            <tr>
                                <td class="auto-style15">
                                    <asp:ImageButton ID="ImageButton6" runat="server" CommandArgument='<%# Eval("Cart_Id") %>' Height="44px" ImageUrl="~/img/del.png" OnCommand="ImageButton6_Command" Width="58px" />
                                </td>
                                <td class="auto-style16"></td>
                                <td class="auto-style25"></td>
                                <td class="auto-style20"></td>
                                <td class="auto-style17"></td>
                                <td class="auto-style17"></td>
                            </tr>
                            <tr>
                                <td class="auto-style30">&nbsp;</td>
                                <td class="auto-style10">&nbsp;</td>
                                <td class="auto-style23">&nbsp;</td>
                                <td class="auto-style26">&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style31"></td>
                                <td class="auto-style11"></td>
                                <td class="auto-style24"></td>
                                <td class="auto-style27"></td>
                                <td class="auto-style4"></td>
                                <td class="auto-style4"></td>
                            </tr>
                        </table>
                    </ItemTemplate>
                    <SeparatorStyle HorizontalAlign="Justify" />
                </asp:DataList>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Button ID="Button2" runat="server" BackColor="#FF5050" OnClick="Button2_Click" Text="Continue Shopping" />
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:Label ID="Label14" runat="server" ForeColor="Blue" Text="You Want to Proceed? Click Confirm to check out"></asp:Label>
            </td>
            <td class="auto-style6"></td>
            <td class="auto-style6"></td>
            <td class="auto-style6"></td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Confirm" />
            </td>
            <td class="auto-style4"></td>
            <td class="auto-style4"></td>
            <td class="auto-style4"></td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
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
        <tr>
            <td class="auto-style2">&nbsp;</td>
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
        <tr>
            <td class="auto-style2">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
                    <Columns>
                        <asp:BoundField DataField="Pro_Name" HeaderText="Product Name" />
                        <asp:ImageField DataImageUrlField="Pro_Image">
                            <ControlStyle BorderColor="White" BorderStyle="Solid" BorderWidth="5px" Height="100px" Width="100px" />
                            <ItemStyle BorderStyle="Solid" Height="50px" Width="100px" />
                        </asp:ImageField>
                        <asp:BoundField DataField="Pro_Rate" HeaderText="Product Price" />
                        <asp:TemplateField HeaderText="Quantity">
                            <ItemTemplate>
                                <asp:TextBox ID="TextBox1" runat="server" BorderColor="Black" Height="19px" Text='<%# Eval("Pro_Qty") %>' Width="50px"></asp:TextBox>
                                <asp:ImageButton ID="ImageButton2" runat="server" Height="10px" ImageAlign="Top" ImageUrl="~/img/plus.jpg" Width="10px" />
                                <asp:ImageButton ID="ImageButton3" runat="server" Height="10px" ImageAlign="Top" ImageUrl="~/img/minus.jpg" Width="10px" />
                            </ItemTemplate>
                            <ControlStyle BorderColor="Black" BorderStyle="Solid" Height="50px" Width="50px" />
                            <FooterStyle HorizontalAlign="Justify" />
                            <HeaderStyle HorizontalAlign="Justify" VerticalAlign="Top" />
                        </asp:TemplateField>
                        <asp:BoundField DataField="Subtotal" HeaderText="Total" />
                        <asp:BoundField DataField="Pro_Status" HeaderText="Current_Status" />
                        <asp:TemplateField HeaderText="Remove">
                            <ItemTemplate>
                                <asp:ImageButton ID="ImageButton1" runat="server" CommandArgument='<%# Eval("Cart_Id") %>' Height="33px" ImageUrl="~/img/del.png" OnCommand="ImageButton1_Command" Width="37px" />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <EmptyDataTemplate>
                        <asp:Label ID="Label5" runat="server" Text='<%# Eval("Pro_Name") %>'></asp:Label>
                    </EmptyDataTemplate>
                </asp:GridView>
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
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
