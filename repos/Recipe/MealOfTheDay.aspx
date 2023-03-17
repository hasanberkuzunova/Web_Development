<%@ Page Title="" Language="C#" MasterPageFile="~/User.master" AutoEventWireup="true" CodeFile="MealOfTheDay.aspx.cs" Inherits="MealOfTheDay" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style5 {
            text-align: left;
        }
        .auto-style6 {
            text-align: right;
        }
        .auto-style8 {
            background-color: #CE7171;
            margin-right: 3px;
        }
        .auto-style10 {
            text-align: center;
            font-weight: bold;
            background-color: #CE7171;
        }
        .auto-style11 {
            background-color: #CE7171;
            margin-right: 3px;
            font-weight: normal;
            font-size: 16px;
        }
        .auto-style12 {
            background-color: #CE7171;
            margin-right: 3px;
            font-size: 16px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1" style="height: 44px; width: 100%">
        <tr>
            <td>
                <asp:DataList ID="DataList2" runat="server" OnSelectedIndexChanged="DataList2_SelectedIndexChanged" CssClass="auto-style8">
                    <ItemTemplate>
                        <div class="auto-style10">
                            <table class="auto-style1">
                                <tr>
                                    <td><span class="auto-style8">Meal Of The Day</span><br class="auto-style8" />
                                        <asp:Label ID="Label7" runat="server" Text='<%# Eval("FoodName") %>' CssClass="auto-style8"></asp:Label>
                                    </td>
                                </tr>
                            </table>
                            <br class="auto-style8" />
                            <table class="auto-style1">
                                <tr>
                                    <td class="auto-style5"><span class="auto-style11"><strong>Ingredients:</strong></span><asp:Label ID="Label3" runat="server" CssClass="auto-style8" Text='<%# Eval("FoodIngredients") %>'></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style5">&nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="auto-style5"><strong><span class="auto-style12">Recipe:</span></strong><asp:Label ID="Label4" runat="server" CssClass="auto-style8" Text='<%# Eval("FoodRecipe") %>'></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style5">&nbsp;</td>
                                </tr>
                                <tr>
                                    <td class="auto-style5">
                                        <asp:Image ID="Image1" runat="server" Height="180px" ImageUrl='<%# Eval("FoodPhoto") %>' Width="385px" CssClass="auto-style8" />
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style5">
                                        <table class="auto-style1">
                                            <tr>
                                                <td><strong><span class="auto-style12">Rating:</span></strong><asp:Label ID="Label5" runat="server" CssClass="auto-style8" Text='<%# Eval("FoodRating") %>'></asp:Label>
                                                </td>
                                                <td class="auto-style6"><strong><span class="auto-style12">Date:</span><asp:Label ID="Label6" runat="server" CssClass="auto-style8" Text='<%# Eval("FoodDate") %>'></asp:Label>
                                                    </strong></td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style5">&nbsp;</td>
                                </tr>
                            </table>
                        </div>
                    </ItemTemplate>
                </asp:DataList>
            </td>
        </tr>
      
        
      
    </table>
   
</asp:Content>


