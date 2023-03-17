<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="AdminFoodOfTheDay.aspx.cs" Inherits="AdminFoodOfTheDay" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

        .auto-style11 {
            background-color: #C0C0C0;
        }
        .auto-style15 {
            width: 366px;
        }
        .auto-style14 {
            width: 27px;
        }
        .auto-style16 {
            text-align: center;
        }
        .auto-style17 {
            text-align: right;
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
                    <asp:Button ID="Button1" runat="server" Height="30px"  Text="+" Width="30px" OnClick="Button1_Click"   />
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
                        <td class="auto-style17">
                            <a href='FoodAdminDetails.aspx?FoodId=<%#Eval("FoodId") %>'>
                            <asp:Image ID="Image3" runat="server" Height="30px" ImageUrl="~/Icons/choice.png" Width="30px" />
                            </a>
                               </td>
                        </a>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
</asp:Panel>
</asp:Content>

