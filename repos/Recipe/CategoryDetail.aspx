<%@ Page Title="" Language="C#" MasterPageFile="~/User.master" AutoEventWireup="true" CodeFile="CategoryDetail.aspx.cs" Inherits="CategoryDetail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

        .auto-style5 {
            width: 100%;
            height: 182px;
        }
        .auto-style10 {
            width: 417px;
            background-color: #99CCFF;
        }
        .auto-style7 {
            font-size: x-large;
            color: #000000;
            background-color: #99CCFF;
        }
        .auto-style8 {
            width: 417px;
        }
        .auto-style9 {
            height: 26px;
            width: 417px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:DataList ID="DataList2" runat="server" CssClass="auto-style11">
    <ItemTemplate>
        <table class="auto-style5">
            <tr>
                <td class="auto-style10"><strong><a href="MealDetails.aspx?FoodId=<%# Eval("FoodId") %> ">
                    <asp:Label ID="Label3" runat="server" CssClass="auto-style7" Text='<%# Eval("FoodName") %>'></asp:Label>
                    </strong></td>
            </tr>
            <tr>
                <td class="auto-style8"><strong>Ingredients:</strong>
                    <asp:Label ID="Label4" runat="server" Text='<%# Eval("FoodIngredients") %>'></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style8"><strong>Description:</strong>
                    <asp:Label ID="Label5" runat="server" Text='<%# Eval("FoodRecipe") %>'></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style9"><em><strong>Upload Date:</strong></em><asp:Label ID="Label6" runat="server" Text='<%# Eval("FoodDate") %>'></asp:Label>
                        -<em><strong> Rating:</strong></em>
                    <asp:Label ID="Label7" runat="server" Text='<%# Eval("FoodRating") %>'></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style9" style="border-bottom-style: groove; border-bottom-width: thick; border-bottom-color: #333333">&nbsp;</td>
            </tr>
        </table>
    </ItemTemplate>
</asp:DataList>
</asp:Content>

