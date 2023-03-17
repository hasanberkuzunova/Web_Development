  <%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Course.aspx.cs" Inherits="Course" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <form runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Select a Course"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control"></asp:DropDownList>
    </div>
        <br />
         <div>
        <asp:Label ID="Label2" runat="server" Text="Student ID:"></asp:Label>
              <asp:DropDownList ID="DropDownList2" runat="server" CssClass="form-control"></asp:DropDownList>
    </div>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Apply For Course" CssClass="btn btn-success" OnClick="Button1_Click" />
        </form>
</asp:Content>

