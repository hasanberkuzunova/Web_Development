<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="AdminSuggestMeal.aspx.cs" Inherits="AdminSuggestMeal" %>

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
                <td class="auto-style15">APPROVED RECIPES LIST</td>
                <td class="auto-style14">
                    <asp:Button ID="Button2" runat="server" Height="30px" Text="-" Width="30px" OnClick="Button2_Click"   />
                </td>
                <td class="auto-style16">
                    <asp:Button ID="Button1" runat="server" Height="30px"  Text="+" Width="30px" OnClick="Button1_Click" />
                </td>
            </tr>
        </table>
    </asp:Panel>
     <asp:Panel ID="Panel2" runat="server">
        <asp:DataList ID="DataList1" runat="server" Width="445px" >
            <ItemTemplate>
                <table class="auto-style9">
                    <tr>
                        <td>
                            <asp:Label ID="Label1" runat="server" Text='<%# Eval("RecipeName") %>'></asp:Label>
                        </td>
                        <td class="auto-style17">
                      <a href="AdminSuggestMealDetails.aspx?RecipeId=<%#Eval("RecipeId")%>">
                          <asp:Image ID="Image3" runat="server" Height="30px" ImageUrl="~/Icons/sugg.png" Width="30px" /></a>
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
</asp:Panel>
    <asp:Panel ID="Panel3" runat="server" CssClass="auto-style11">
        <table class="auto-style9">
            <tr>
                <td class="auto-style15">DISAPPROVED RECIPES LIST</td>
                <td class="auto-style14">
                    <asp:Button ID="Button3" runat="server" Height="30px" Text="-" Width="30px" OnClick="Button3_Click"   />
                </td>
                <td class="auto-style16">
                    <asp:Button ID="Button4" runat="server" Height="30px"  Text="+" Width="30px" OnClick="Button4_Click" />
                </td>
            </tr>
        </table>
    </asp:Panel>
     <asp:Panel ID="Panel4" runat="server">
        <asp:DataList ID="DataList2" runat="server" Width="445px" >
            <ItemTemplate>
                <table class="auto-style9">
                    <tr>
                        <td>
                            <asp:Label ID="Label1" runat="server" Text='<%# Eval("RecipeName") %>'></asp:Label>
                        </td>
                        <td class="auto-style17">
                      <a href="AdminSuggestMealDetails.aspx?RecipeId=<%#Eval("RecipeId")%>">
                          <asp:Image ID="Image3" runat="server" Height="30px" ImageUrl="~/Icons/sugg.png" Width="30px" /></a>
                        </td>
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
</asp:Panel>
</asp:Content>

