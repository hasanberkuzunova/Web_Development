<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="UpdateStudent.aspx.cs" Inherits="UpdateStudent" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <form id="Form1" runat="server">
   <div class="form-group">
       <div>
           <strong>
       <asp:Label for="TextBox6" runat="server" Text="Student ID:"></asp:Label>
           </strong>
       <asp:TextBox ID="TextBox6" runat="server" CssClass="form-control"></asp:TextBox>
           </div>
       <div>
           <strong>
       <asp:Label for="TextBox1" runat="server" Text="Student Name:"></asp:Label>
           </strong>
       <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>
           </div>
       <br />
         <div>
             <strong>
       <asp:Label for="TextBox2" runat="server" Text="Student Surname:"></asp:Label>
             </strong>
       <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control"></asp:TextBox>
           </div>
       <br />
         <div>
             <strong>
       <asp:Label for="TextBox3" runat="server" Text="Student Number:"></asp:Label>
             </strong>
       <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control"></asp:TextBox>
           </div>
       <br />
         <div>
             <strong>
       <asp:Label for="TextBox4" runat="server" Text="Student Password:"></asp:Label>
             </strong>
       <asp:TextBox ID="TextBox4" runat="server" CssClass="form-control" ></asp:TextBox>
           </div>
       <br />
         <div>
             <strong>
       <asp:Label for="TextBox5" runat="server" Text="Student Photo:"></asp:Label>
             </strong>
       <asp:TextBox ID="TextBox5" runat="server" CssClass="form-control"></asp:TextBox>
           </div>
   </div>
        <asp:Button ID="Button1" runat="server" Text="UPDATE" CssClass="btn btn-success" OnClick="Button1_Click" />
    </form>
</asp:Content>

