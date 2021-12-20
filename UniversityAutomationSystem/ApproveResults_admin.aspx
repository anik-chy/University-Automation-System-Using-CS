<%@ Page Title="" Language="C#" MasterPageFile="~/Master1.Master" AutoEventWireup="true" CodeBehind="ApproveResults_admin.aspx.cs" Inherits="UniversityAutomationSystem.ApproveResults_admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <h1>
        Unapproved Results</h1>
    <hr />
    <div class="panel panel-default">
        <!-- Default panel contents -->
        <div class="panel-heading">
            All UR</div>
        <asp:Repeater ID="rptrstudent" runat="server">
            <HeaderTemplate>
                <table class="table">
                    <thead>
                        <tr>
                        <th>
                                Student_id
                            </th>
                            <th>
                                Number
                            </th>
                            <th>
                                Grade
                            </th>
                                                        <th>
                                Approved
                            </th>
                        </tr>
                    </thead>
                    <tbody>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                <td>
                        <%# Eval("student_id") %>
                    </td>
                    <td>
                        <%# Eval("number") %>
                    </td>
                    <td>
                        <%# Eval("grade") %>
                    </td>
                    <td>
                        <%# Eval("approved") %>
                    </td>
                </tr>
            </ItemTemplate>
            <FooterTemplate>
                </tbody> </table>
            </FooterTemplate>
        </asp:Repeater>
    </div>
    </br>
            <div class="col-xs-11 space-vert">
            <asp:Button ID="approve_btn" runat="server" Class="btn btn-success" Text="Approve"
                OnClick="approve_btn_click" />
        </div>
        <br/>
</asp:Content>
