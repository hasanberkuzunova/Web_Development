<%@ Page Title="" Language="C#" MasterPageFile="~/User.master" AutoEventWireup="true" CodeFile="MealDetails.aspx.cs" Inherits="MealDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style6 {
            width: 100%;
        }
        .auto-style7 {
            font-size: xx-small;
        }
        .auto-style5 {
            font-size: 30pt;
            color: #FFFFFF;
        }
        .auto-style9 {
            background-color: #C0C0C0;
        }
    .auto-style10 {
        text-align: right;
    }
    .auto-style11 {
        height: 27px;
    }
    .auto-style12 {
        font-size: medium;
        font-weight: bold;
    }
        .auto-style13 {
            font-size: xx-large;
            color: #000000;
        }
        .auto-style14 {
            margin-right: 0px;
        }
        .auto-style15 {
            font-size: large;
            float: left;
        }
        .auto-style16 {
            width: 143%;
            height: 29px;
        }
        .auto-style18 {
            font-size: x-large;
            color: #000099;
            width: 445px;
        }
        .auto-style19 {
            width: 445px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style6">
        <tr>
            <td style="border-bottom-style: double; border-bottom-width: thick" class="auto-style19"><strong>
                <asp:Label ID="Label3" runat="server" CssClass="auto-style13" Text="Label"></asp:Label>
                </strong></td>
        </tr>
        
        <tr>
            <td style="border-bottom-style: double; border-bottom-width: thick" class="auto-style19">
                <asp:Image ID="Image2" runat="server" Height="243px" Width="301px" />
            </td>
        </tr>
        
        <tr>
            <td class="auto-style18"><strong><em style="border-bottom-style: groove; border-bottom-width: thick">Comments</em></strong></td>
        </tr>
    </table>
    <strong>
    <asp:DataList ID="DataList2" runat="server" CssClass="auto-style14">
        <ItemTemplate>
            <table class="auto-style16">
                <tr>
                    <td>
                        <asp:Label ID="Label4" runat="server" CssClass="auto-style15" Text='<%# Eval("CommentatorName") %>' BorderStyle="None" Width="216px"></asp:Label>
                    </td>
                </tr>
                <strong>
                <tr>
                    <td style="border-bottom-width: thin; border-bottom-style: inset; border-bottom-color: #000000;">
                        <asp:Label ID="Label5" runat="server" Text='<%# Eval("CommentContent") %>'></asp:Label>
                        &nbsp;-
                        <asp:Label ID="Label6" runat="server" CssClass="auto-style7" Text='<%# Eval("CommentDate") %>'></asp:Label>
                    </td>
                </tr>
                </strong>
            </table>
        </ItemTemplate>
    </asp:DataList>
        <div class="auto-style9">Add Your Comment</div>
        <asp:Panel ID="Panel1" runat="server">
            <table class="auto-style6">
                <tr>
                    <td class="auto-style11"></td>
                    <td class="auto-style11"></td>
                </tr>
                <tr>
                    <td class="auto-style10">Name Surname:</td>
                    <td><strong>
                        <asp:TextBox ID="TextBox2" runat="server" Height="20px" Width="200px"></asp:TextBox>
                        </strong></td>
                </tr>
                <tr>
                    <td class="auto-style10">E-mail:</td>
                    <td><strong>
                        <asp:TextBox ID="TextBox3" runat="server" Height="20px" Width="200px"></asp:TextBox>
                        </strong></td>
                </tr>
                <tr>
                    <td class="auto-style10">Comment:</td>
                    <td>
                        <asp:TextBox ID="TextBox4" runat="server" Height="101px" TextMode="MultiLine" Width="200px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style10">&nbsp;</td>
                    <td>
                        <asp:Button ID="Button1" runat="server" CssClass="auto-style12" OnClick="Button1_Click" Text="Add Your Comment" Width="200px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style10">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
</asp:Panel>
</asp:Content>

