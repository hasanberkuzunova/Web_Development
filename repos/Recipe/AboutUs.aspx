<%@ Page Title="" Language="C#" MasterPageFile="~/User.master" AutoEventWireup="true" CodeFile="AboutUs.aspx.cs" Inherits="AboutUs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style5 {
            font-size: x-large;
            margin-top: 0px;
        }
        .auto-style8 {
            font-size: large;
            margin-top: 0px;
        }
        .auto-style9 {
            margin-top: 0px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p class="auto-style8">
        <strong>About Us</strong></p><asp:DataList ID="DataList2" runat="server" Width="441px" CssClass="auto-style9">
        <ItemTemplate>
            <asp:Label ID="Label3" runat="server" Text='<%# Eval("Text") %>'></asp:Label>
        </ItemTemplate>
    </asp:DataList>

    <br />

    <asp:Image ID="Image1" runat="server" Height="221px" ImageUrl="~/Photo/how_to_start_a_travel_blog_-_article_image.jpg" Width="450px" />

</asp:Content>

