<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="FoodAdminDetails.aspx.cs" Inherits="FoodAdminDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .auto-style11 {
        margin-left: 40px;
    }
    .auto-style12 {
        text-align: right;
    }
    .auto-style13 {
        text-align: center;
        margin-left: 40px;
    }
    .auto-style14 {
        font-weight: bold;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style9">
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style12"><strong>Food Name:</strong></td>
        <td>
            <asp:TextBox ID="TextBox1" runat="server" Width="300px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style12"><strong>Ingredients:</strong></td>
        <td class="auto-style11">
            <asp:TextBox ID="TextBox2" runat="server" Height="250px" TextMode="MultiLine" Width="300px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style12"><strong>Recipe:</strong></td>
        <td class="auto-style11">
            <asp:TextBox ID="TextBox3" runat="server" Height="250px" TextMode="MultiLine" Width="300px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style12"><strong>Category:&nbsp;</strong></td>
        <td class="auto-style11">
            <asp:DropDownList ID="DropDownList1" runat="server" Width="300px">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="auto-style12"><strong>Photo:</strong></td>
        <td class="auto-style11">
            <asp:FileUpload ID="FileUpload1" runat="server" Width="300px" />
        </td>
    </tr>
    <tr>
        <td class="auto-style12">&nbsp;</td>
        <td class="auto-style13"><strong>
            <asp:Button ID="Button1" runat="server" CssClass="auto-style14" Height="60px" OnClick="Button1_Click" Text="UPDATE" Width="150px" />
            </strong></td>
    </tr>
    <tr>
        <td class="auto-style12">&nbsp;</td>
        <td class="auto-style13"><strong>
            <asp:Button ID="Button2" runat="server" CssClass="auto-style14" Height="60px" OnClick="Button2_Click" Text="Choose As Food of the Day" Width="250px" />
            </strong></td>
    </tr>
</table>
</asp:Content>

