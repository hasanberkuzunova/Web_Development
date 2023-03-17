<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="AdminSuggestMealDetails.aspx.cs" Inherits="AdminSuggestMealDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style11 {
            text-align: right;
        }
        .auto-style12 {
            text-align: left;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style9">
        <tr>
            <td><strong></strong></td>
            <td><strong></strong></td>
        </tr>
        <tr>
            <td class="auto-style11"><strong>Recipe Name:</strong></td>
            <td class="auto-style12"><strong>
                <asp:TextBox ID="TextBox1" runat="server" Width="300px" ></asp:TextBox>
                </strong></td>
        </tr>
        <tr>
            <td class="auto-style11"><strong>Ingredients:</strong></td>
            <td class="auto-style12"><strong>
                <asp:TextBox ID="TextBox2" runat="server" Height="250px" TextMode="MultiLine" Width="300px"></asp:TextBox>
                </strong></td>
        </tr>
        <tr>
            <td class="auto-style11"><strong>Recipe:</strong></td>
            <td class="auto-style12"><strong>
                <asp:TextBox ID="TextBox3" runat="server" Height="250px" TextMode="MultiLine" Width="300px"></asp:TextBox>
                </strong></td>
        </tr>
        <tr>
            <td class="auto-style11"><strong>Photo:</strong></td>
            <td class="auto-style12">
                <asp:FileUpload ID="FileUpload1" runat="server" Width="300px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style11"><strong>Recipe Owner:</strong></td>
            <td class="auto-style12">
                <asp:TextBox ID="TextBox4" runat="server" Width="300px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style11"><strong>E-mail:</strong></td>
            <td class="auto-style13">
                <asp:TextBox ID="TextBox5" runat="server" Width="300px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style11"><strong>Category:</strong></td>
            <td class="auto-style13">
                <asp:DropDownList ID="DropDownList1" runat="server" Width="300px">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style12">&nbsp;</td>
            <td class="auto-style13"><strong>
                <asp:Button ID="Button1" runat="server" CssClass="auto-style14" Height="60px" Text="CONFIRM" Width="150px" OnClick="Button1_Click" />
                </strong></td>
        </tr>
    </table>
</asp:Content>

