<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="AdminAboutUs.aspx.cs" Inherits="AdminAboutUs" %>

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
            margin-left: 40px;
        }
        .auto-style17 {
        font-size: large;
    }
    .auto-style18 {
        text-align: center;
    }
    .auto-style19 {
        font-size: medium;
        font-style: italic;
    }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Panel ID="Panel1" runat="server" CssClass="auto-style11">
        <table class="auto-style9">
            <tr>
                <td class="auto-style15">ABOUT US</td>
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
        <table class="auto-style9">
            <tr>
                <td><em>
                    <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style19" Height="200px" TextMode="MultiLine" Width="435px"></asp:TextBox>
                    </em></td>
            </tr>
            <tr>
                <td class="auto-style18"><strong>
                    <asp:Button ID="Button3" runat="server" CssClass="auto-style17" Height="50px" Text="UPDATE" Width="200px" OnClick="Button3_Click" />
                    </strong></td>
            </tr>
        </table>
</asp:Panel>
</asp:Content>

