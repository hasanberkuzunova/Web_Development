<%@ Page Title="" Language="C#" MasterPageFile="~/User.master" AutoEventWireup="true" CodeFile="SuggestAMeal.aspx.cs" Inherits="SuggestaMeal" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .auto-style5 {
        margin-left: 40px;
    }
    .auto-style6 {
        text-align: right;
    }
    .auto-style7 {
        margin-left: 50px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style6"><strong>Recipe Name:&nbsp;</strong></td>
        <td>
            <asp:TextBox ID="TextBox1" runat="server"  Width="250px" CssClass="tb5"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style6"><strong>Ingredients:</strong></td>
        <td class="auto-style5">
            <asp:TextBox ID="TextBox2" runat="server" Height="80px" TextMode="MultiLine" Width="250px" CssClass="tb5"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style6"><strong>Description:</strong></td>
        <td class="auto-style5">
            <asp:TextBox ID="TextBox3" runat="server" Height="150px" TextMode="MultiLine" Width="250px" CssClass="tb5"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style6"><strong>Photo:</strong></td>
        <td class="auto-style5">
            <asp:FileUpload ID="FileUpload1" runat="server" Width="250px" CssClass="tb5" />
        </td>
    </tr>
    <tr>
        <td class="auto-style6"><strong>Owner:</strong></td>
        <td class="auto-style5">
            <asp:TextBox ID="TextBox4" runat="server" Width="250px" CssClass="tb5"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style6"><strong>E-Mail:</strong></td>
        <td class="auto-style5">
            <asp:TextBox ID="TextBox5" runat="server" TextMode="Email" Width="250px" CssClass="tb5"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td class="auto-style5">
            <asp:Button ID="Button1" runat="server" BackColor="White" CssClass="auto-style7" Height="40px" Text="Suggest A Meal" Width="150px" OnClick="Button1_Click" />
        </td>
    </tr>
</table>
</asp:Content>

