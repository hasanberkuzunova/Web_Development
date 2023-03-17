<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="Categories.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style11 {
            background-color: #C0C0C0;
        }
    .auto-style12 {
        text-align: right;
    }
    .auto-style13 {
        width: 325px;
    }
        .auto-style14 {
            width: 27px;
        }
        .auto-style15 {
            width: 366px;
        }
        .auto-style16 {
            text-align: center;
        }
        .auto-style17 {
            height: 29px;
        }
        .auto-style18 {
            font-size: medium;
            font-weight: bold;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Panel ID="Panel1" runat="server" CssClass="auto-style11">
        <table class="auto-style9">
            <tr>
                <td class="auto-style15">CATEGORY LIST</td>
                <td class="auto-style14">
                    <asp:Button ID="Button2" runat="server" Height="30px" Text="-" Width="30px" OnClick="Button2_Click1" />
                </td>
                <td class="auto-style16">
                    <asp:Button ID="Button1" runat="server" Height="30px"  Text="+" Width="30px" OnClick="Button1_Click" />
                </td>
            </tr>
        </table>
    </asp:Panel>
    <asp:Panel ID="Panel2" runat="server">
        <asp:DataList ID="DataList1" runat="server" Width="445px">
            <ItemTemplate>
                <table class="auto-style9">
                    <tr>
                        <td class="auto-style13">
                            <asp:Label ID="Label1" runat="server" Text='<%# Eval("CategoryName") %>'></asp:Label>
                        </td>
                        <td class="auto-style12">
                           <a href="Categories.aspx?CategoryId=<%#Eval("CategoryId") %>&operation=delete"> <asp:Image ID="Image2" runat="server" Height="30px" ImageUrl="~/Icons/delete.png" Width="30px" />
                        </a>
                               </td>
                        <td class="auto-style12">
                        <a href="CategoryAdminDetails.aspx?CategoryId=<%#Eval("CategoryId") %>">    <asp:Image ID="Image3" runat="server" Height="30px" ImageUrl="~/Icons/update.png" Width="30px" />
                        </td> </a>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
</asp:Panel>
    <asp:Panel ID="Panel3" runat="server" CssClass="auto-style11">
        <table class="auto-style9">
            <tr>
                <td class="auto-style15">ADD NEW CATEGORY</td>
                <td class="auto-style14">
                    <asp:Button ID="Button4" runat="server" Height="30px" Text="-" Width="30px" OnClick="Button4_Click" />
                </td>
                <td class="auto-style16">
                    <asp:Button ID="Button5" runat="server"  Height="30px" Text="+" Width="30px" OnClick="Button5_Click" />
                </td>
            </tr>
        </table>
    </asp:Panel>
    <asp:Panel ID="Panel4" runat="server">
        <table class="auto-style9">
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>Category Name:</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style17">Category Icon:</td>
                <td class="auto-style17">
                    <asp:FileUpload ID="FileUpload1" runat="server" />
                </td>
            </tr>
            <tr>
                <td class="auto-style17">&nbsp;</td>
                <td class="auto-style17"><strong>
                    <asp:Button ID="Button3" runat="server" CssClass="auto-style18" Text="ADD" Width="100px" OnClick="Button3_Click" />
                    </strong></td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>

