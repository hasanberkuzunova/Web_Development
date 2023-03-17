 <%@ Page Title="" Language="C#" MasterPageFile="~/User.master" AutoEventWireup="true" CodeFile="Contact.aspx.cs" Inherits="Contact" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .auto-style5 {
        width: 100%;
    }
    .auto-style6 {
        font-weight: bold;
        font-size: large;
    }
    .auto-style7 {
        text-align: right;
    }
        .auto-style8 {
            font-size: large;
            width: 200px;
            height: 4px;
        }
        .auto-style9 {
            font-size: 13pt;
        }
        .auto-style10 {
            width: 100%;
            font-size: 14px;
            height: 371px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style10">
    <tr>
        <td class="auto-style8" colspan="2"><strong><span class="auto-style9">Send Your Messages</span>
            
            <br />
            
            </strong></td>
    </tr>
    <tr>
        <td class="auto-style7"><strong>Name:&nbsp;</strong></td>
        <td>
            <asp:TextBox ID="TextBox1" runat="server" CssClass="tb5"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style7"><strong>E-mail:</strong></td>
        <td>
            <asp:TextBox ID="TextBox2" runat="server" CssClass="tb5"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style7"><strong>Topic:</strong></td>
        <td>
            <asp:TextBox ID="TextBox3" runat="server" CssClass="tb5"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style7"><strong>Message:</strong></td>
        <td>
            <asp:TextBox ID="TextBox4" runat="server" CssClass="tb5" Height="150px" TextMode="MultiLine"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td><strong>
            <asp:Button ID="Button1" runat="server" CssClass="auto-style6" Text="Send" Width="230px" OnClick="Button1_Click" />
            </strong></td>
    </tr>
</table>
</asp:Content>

