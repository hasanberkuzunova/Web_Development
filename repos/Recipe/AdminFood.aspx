<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="AdminFood.aspx.cs" Inherits="AdminFood" %>

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
        .auto-style19 {
            height: 29px;
            text-align: right;
            font-size: medium;
        }
        .auto-style20 {
            text-align: right;
            font-size: medium;
        }
        .auto-style21 {
            height: 29px;
            text-align: center;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Panel ID="Panel1" runat="server" CssClass="auto-style11">
        <table class="auto-style9">
            <tr>
                <td class="auto-style15">FOOD LIST</td>
                <td class="auto-style14">
                    <asp:Button ID="Button2" runat="server" Height="30px" Text="-" Width="30px" OnClick="Button2_Click"  />
                </td>
                <td class="auto-style16">
                    <asp:Button ID="Button1" runat="server" Height="30px"  Text="+" Width="30px" OnClick="Button1_Click"  />
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
                            <asp:Label ID="Label1" runat="server" Text='<%# Eval("FoodName") %>'></asp:Label>
                        </td>
                        <td class="auto-style12">
                           <a href="AdminFood.aspx?FoodId=<%#Eval("FoodId") %>&operation=delete"> <asp:Image ID="Image2" runat="server" Height="30px" ImageUrl="~/Icons/delete.png" Width="30px" />
                        </a>
                               </td>
                        <td class="auto-style12">
                        <a href="FoodAdminDetails.aspx?FoodId=<%#Eval("FoodId") %>">    <asp:Image ID="Image3" runat="server" Height="30px" ImageUrl="~/Icons/update.png" Width="30px" />
                        </td> </a>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
</asp:Panel>
    <asp:Panel ID="Panel3" runat="server" CssClass="auto-style11">
        <table class="auto-style9">
            <tr>
                <td class="auto-style15">ADD NEW FOOD</td>
                <td class="auto-style14">
                    <asp:Button ID="Button4" runat="server" Height="30px" Text="-" Width="30px" OnClick="Button4_Click"  />
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
                <td class="auto-style20"><strong>Food Name:</strong></td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" Width="300px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style19"><strong>Ingredients:</strong></td>
                <td class="auto-style17">
                    <asp:TextBox ID="TextBox2" runat="server" Height="100px" TextMode="MultiLine" Width="300px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style19"><strong>Recipe:</strong></td>
                <td class="auto-style17">
                    <asp:TextBox ID="TextBox3" runat="server" Height="200px" TextMode="MultiLine" Width="300px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style19"><strong>Category:</strong></td>
                <td class="auto-style17">
                    <asp:DropDownList ID="DropDownList1" runat="server" Width="300px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style17">&nbsp;</td>
                <td class="auto-style21"><strong>
                    <asp:Button ID="Button3" runat="server" CssClass="auto-style18" Height="50px" OnClick="Button3_Click" Text="ADD" Width="200px" />
                    </strong></td>
            </tr>
            <tr>
                <td class="auto-style17">&nbsp;</td>
                <td class="auto-style21">&nbsp;</td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>


