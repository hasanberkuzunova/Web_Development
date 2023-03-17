<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="AdminComment.aspx.cs" Inherits="AdminComment" %>

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
        .auto-style13 {
        width: 325px;
    }
        .auto-style12 {
        text-align: right;
    }
    </style>
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <asp:Panel ID="Panel1" runat="server" CssClass="auto-style11">
        <table class="auto-style9">
            <tr>
                <td class="auto-style15">APPROVED COMMENT LIST</td>
                <td class="auto-style14">
                    <asp:Button ID="Button2" runat="server" Height="30px" Text="-" Width="30px" OnClick="Button2_Click"  />
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
                        <td class="auto-style13">
                            <asp:Label ID="Label1" runat="server" Text='<%# Eval("CommentatorName") %>'></asp:Label>
                        </td>
                        <td class="auto-style12">
                         <asp:Image ID="Image2" runat="server" Height="30px" ImageUrl="~/Icons/delete.png" Width="30px" />
                        
                               </td>
                        <td class="auto-style12">
                         <a href="CommentAdminDetail.aspx?CommentId=<%#Eval("CommentId") %>" > <asp:Image ID="Image3" runat="server" Height="30px" ImageUrl="~/Icons/update.png" Width="30px" />
                       </a> </td> 
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
</asp:Panel>
     <asp:Panel ID="Panel3" runat="server" CssClass="auto-style11">
        <table class="auto-style9">
            <tr>
                <td class="auto-style15">DISAPPROVED COMMENT LIST</td>
                <td class="auto-style14">
                    <asp:Button ID="Button3" runat="server" Height="30px" Text="-" Width="30px" OnClick="Button3_Click"   />
                </td>
                <td class="auto-style16">
                    <asp:Button ID="Button4" runat="server" Height="30px"  Text="+" Width="30px" OnClick="Button4_Click"  />
                </td>
            </tr>
        </table>
    </asp:Panel>
     <asp:Panel ID="Panel4" runat="server">
        <asp:DataList ID="DataList2" runat="server" Width="445px" >
            <ItemTemplate>
                <table class="auto-style9">
                    <tr>
                        <td class="auto-style13">
                            <asp:Label ID="Label1" runat="server" Text='<%# Eval("CommentatorName") %>'></asp:Label>
                        </td>
                        <td class="auto-style12">
                         <asp:Image ID="Image2" runat="server" Height="30px" ImageUrl="~/Icons/delete.png" Width="30px" />
                        </a>
                               </td>
                        <td class="auto-style12">
                            <a href="CommentAdminDetail.aspx?CommentId=<%#Eval("CommentId") %>" ><asp:Image ID="Image3" runat="server" Height="30px" ImageUrl="~/Icons/update.png" Width="30px" />
                       </a> </td> 
                    </tr>
                </table>
            </ItemTemplate>
        </asp:DataList>
</asp:Panel>
        
</asp:Content>

