<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="StudentList.aspx.cs" Inherits="StudentList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <table class="table table-bordered table-hover">
        <tr>
            <th>
                Student ID
            </th>
             <th>
                Student Name
            </th> 
            <th>
                Student Surname
            </th> 
            <th>
                Student Number
            </th> 
            <th>
                Student Password
            </th>
            <th>
                Student Photo
            </th>
            <th>
                Student Balance
            </th>
            <th>Operations</th>
        </tr>
        <tbody>
           
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <tr>
                            <td><%#Eval("Id") %> </td>
                            <td><%#Eval("Name") %> </td>
                            <td><%#Eval("Surname") %> </td>
                            <td><%#Eval("Number") %> </td>
                            <td><%#Eval("Password") %> </td>
                            <td><%#Eval("Photo") %> </td>
                            <td><%#Eval("Balance") %> </td>
                            <td>
                                <asp:HyperLink NavigateUrl='<%#"~/DeleteStudent.aspx?StudentID="+Eval("Id") %>' ID="HyperLink1" CssClass="btn btn-danger" runat="server">Delete</asp:HyperLink>
                                <asp:HyperLink NavigateUrl='<%#"~/UpdateStudent.aspx?StudentID="+Eval("Id") %>' ID="HyperLink2" CssClass="btn btn-success" runat="server">Update</asp:HyperLink>
                                </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            
        </tbody>
    </table>
</asp:Content>

